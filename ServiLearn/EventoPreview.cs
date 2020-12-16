using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDLibrary;

namespace ServiLearn
{
    public partial class EventoPreview : Form
    {
        private Cuenta user;
        private int tipo;
        private Evento evento;
        private ONG creador;

        public EventoPreview(Cuenta u, int i, Evento ev)
        {
            user = u;
            tipo = i;
            evento = ev;
            InitializeComponent();
            Cuenta cuenta = new Cuenta(ev.IdOwner);

            if (tipo == 0)
            {
                button1.Visible = false;
            }

            label1.Text = ("Evento: " + ev.Nombre);
            label2.Text = ("Organizado por: " + cuenta.Nombre);
            textBox1.Text = ev.Descripcion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres unirte a este evento?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                InsertarCuentaEnEvento(user, evento);
                fEvento ventana = new fEvento(user, tipo, evento);



                this.Visible = false;
                ventana.ShowDialog();
            }
        }

        private void InsertarCuentaEnEvento(Cuenta cuenta, Evento eve)
        {
            MySQLDB miBD = new MySQLDB();

            int idCuenta = cuenta.id;
            int idEvento = eve.Id;

            miBD.Insert("INSERT INTO Cuenta_Evento VALUES (" + idCuenta + ", " + idEvento + ")");


        }
    }
}

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
    public partial class fEvento : Form
    {
        public Evento seleccionado;
        public fEvento(Evento eve)
        {
            InitializeComponent();
            seleccionado = eve;
            MostrarSeleccionado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fEventoMod ventana = new fEventoMod(tEvento.Text);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void MostrarSeleccionado()
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT Cuenta.nombre FROM Cuenta, Evento where id_Cuenta = id_Owner and Evento.nombre = '" +seleccionado.Nombre+ "';")[0];
            string organizador = (string)tupla[0];
            tEvento.Text = seleccionado.Nombre;
            tOrganizador.Text = organizador;
            tDescripcion.Text = seleccionado.Descripcion;
            tAdicional.Text = seleccionado.Fecha.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado.BorrarEvento();
                seleccionado = null;
                MessageBox.Show("Se ha eliminado el curso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}

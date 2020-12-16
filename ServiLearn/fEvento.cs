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
        Cuenta user;
        int tipo;
        public fEvento(Cuenta u, int t, Evento eve)
        {
            InitializeComponent();
            seleccionado = eve;
            user = u;
            tipo = t;
            label1.Text = "Evento: " + seleccionado.Nombre;
            label2.Text = "Organizado por: " + seleccionado.IdOwner;
            tDescripcion.Text = seleccionado.Descripcion;
            
                tAdicional.Text = seleccionado.Adicional;
            

            bMod.Visible = false;
            button2.Visible = false;
            if (tipo == 3 || tipo == 4)
            {
                bMod.Visible = true;
                button2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fEventoMod ventana = new fEventoMod(user, tipo, seleccionado.Nombre, seleccionado.Descripcion);
            this.Visible = false;
            ventana.ShowDialog();
            
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

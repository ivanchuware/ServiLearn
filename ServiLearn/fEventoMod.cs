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
    public partial class fEventoMod : Form
    {

        string aux;
        public fEventoMod(string evento)
        {
            InitializeComponent();
            aux = evento;
        }

        private void bUpd_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String descripcion = textBox2.Text;
            String adicional = textBox3.Text;
            if(!nombre.Equals("") && !descripcion.Equals(""))
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Evento SET nombre = '" + nombre
                        + "' WHERE nombre = '" + aux + "';");

                miBD.Update("UPDATE Evento SET descripcion = '" + descripcion
                        + "' WHERE nombre = '" + nombre + "';");

                if (!adicional.Equals(""))
                {
                    miBD.Update("UPDATE Evento SET post = '" + adicional
                        + "' WHERE nombre = '" + nombre + "';");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Introduzca los datos que faltan");
            }
        }
    }
}

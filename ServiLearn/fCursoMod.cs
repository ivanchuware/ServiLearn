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
    public partial class fCursoMod : Form
    {

        string aux;
        Cuenta user;
        int tipo;
        public fCursoMod(Cuenta u, int t, string curso, string desc, string adic)
        {
            InitializeComponent();
            user = u;
            tipo = t;
            aux = curso;
            textBox1.Text = curso;
            textBox2.Text = desc;
            textBox3.Text = adic;
        }

        private void bUpd_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String descripcion = textBox2.Text;
            String adicional = textBox3.Text;
            if(!nombre.Equals("") && !descripcion.Equals(""))
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Curso SET nombre = '" + nombre
                        + "' WHERE nombre = '" + aux + "';");

                miBD.Update("UPDATE Curso SET descripcion = '" + descripcion
                        + "' WHERE nombre = '" + nombre + "';");
                {
                    miBD.Update("UPDATE Curso SET post = '" + adicional
                        + "' WHERE nombre = '" + nombre + "';");
                }
                Curso cur = new Curso(nombre);

                PantallaCurso ventana = new PantallaCurso(user, tipo, cur);
                ventana.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduzca los datos que faltan");
            }
        }
    }
}

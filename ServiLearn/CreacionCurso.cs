using BDLibrary;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ServiLearn
{
    public partial class CreacionCurso : Form
    {
        String nombre;
        String desc;
        String adic;
        Cuenta user;
        int tipo;
        public CreacionCurso(Cuenta u, int t)
        {
            user = u;
            tipo = t;
            InitializeComponent();
        }

        public void InsertarCurso(string name, string desc, int owner)
        {
            MySQLDB miBD = new MySQLDB();

            adic = "vacio";

            miBD.Insert("INSERT INTO Curso VALUES (null, '" + owner + "', '" + name + "', '" + desc + "', '" + adic + "');");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            nombre = tbCurso.Text;
            desc = tbDescripcion.Text;
            if ((nombre == "" || nombre == "Introduzca el Nombre del Curso")
                || (desc == "" || desc == "Introduzca una descripción del curso"))
            {
                if (nombre == "" || nombre == "Introduzca el Nombre del Curso")
                {
                    MessageBox.Show("Por favor añada un nombre al curso");
                }
                else
                {
                    MessageBox.Show("Por favor añada una descripción al curso");
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("", "¿Quiere crear este curso?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    InsertarCurso(nombre, desc, user.id);
                    MessageBox.Show("Curso Creado");
                    this.Visible = false;
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

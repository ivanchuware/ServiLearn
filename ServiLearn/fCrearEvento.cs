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
    public partial class fCrearEvento : Form
    {
        public Cuenta seleccionado;
        public fCrearEvento(Cuenta u)
        {
            InitializeComponent();
            seleccionado = u;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySQLDB miBD = new MySQLDB();
            //Object[] tupla = miBD.Select("SELECT id_Cuenta FROM Cuenta WHERE Nombre = '" + seleccionado.nombre + "';")[0];
            //int id_cue = (int)tupla[0];
            int id_cue = seleccionado.id;
            string nombre = textBox1.Text;
            string descripcion = textBox2.Text;
            if (!nombre.Equals("") && !descripcion.Equals(""))
            {
                
                miBD.Insert("INSERT INTO Evento VALUES (null, '" + id_cue + "','" +nombre+ "', '" + descripcion + "', null, null);");
                //miBD.Insert("INSERT INTO Curso VALUES (null, '" + owner + "', '" + name + "', '" + desc + "', null);");
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Nombre o Descripción incorrecto");
            }
        }
    }
}

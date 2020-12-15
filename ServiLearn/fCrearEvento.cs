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
            Object[] tupla = miBD.Select("SELECT id_Cuenta FROM Cuenta WHERE Nombre = '" + seleccionado.nombre + "';")[0];
            int id_cue = (int)tupla[0];
            string nombre = textBox1.Text;
            string descripcion = textBox2.Text;
            if (!nombre.Equals("") && !descripcion.Equals(""))
            {
                miBD.Insert("INSERT INTO Evento (id_Owner, nombre, descripcion) VALUES (" + id_cue + ",'" +nombre+ "', '" + descripcion + "' ;");
            }
        }
    }
}

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
    public partial class Principal : Form
    {
        private Cuenta user;
        private int tipo;
        private Evento eventoSeleccionado;
        List<object[]> tuplasCursos;
        List<object[]> tuplasEventos;

        private void consultarCursos()
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                tuplasCursos = miBD.Select("SELECT * FROM Curso;");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void consultarEventos()
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                tuplasEventos = miBD.Select("SELECT * FROM Evento;");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void actualizarCursos()
        {
            lbCursos.Items.Clear();
            string filter = tbBuscadorCurso.Text;
            foreach (object[] tupla in tuplasCursos)
            {
                try
                {
                    string nombre = (string)tupla[2];
                    if (nombre.Contains(filter)) {
                        lbCursos.Items.Add(nombre);
                    }
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        }

        private void actualizarEventos()
        {
            lbEventos.Items.Clear();
            string filter = tbBuscadorEvento.Text;
            foreach (object[] tupla in tuplasEventos)
            {
                try
                {
                    string nombre = (string)tupla[2];
                    if (nombre.Contains(filter))
                    {
                        
                        lbEventos.Items.Add(nombre);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        }
        public Principal(Cuenta u, int t)
        {
            user = u;
            tipo = t;
            InitializeComponent();
            eventoSeleccionado = null;

            buttonCrearCurso.Visible = false;
            buttonCrearEvento.Visible = false;

            if (tipo == 2 || tipo == 4)
            {
                buttonCrearCurso.Visible = true;
            }

            if (tipo == 3 || tipo == 4)
            {
                buttonCrearEvento.Visible = true;
            }

            String tp;
            switch (tipo)
            {
                case 0:
                    tp = "Invitado";
                    break;
                case 1:
                    tp = "Alumno";
                    break;
                case 2:
                    tp = "Docente";
                    break;
                case 3:
                    tp = "ONG";
                    break;
                default:
                    tp = "Administrador";
                    break;
            }
            label1.Text = "Bienvenido " + user.nombre + ", está registrado como " + tp;

            consultarCursos();
            consultarEventos();
            actualizarCursos();
            actualizarEventos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCursos_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            actualizarEventos();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbBuscadorCurso_TextChanged(object sender, EventArgs e)
        {
            actualizarCursos();
        }

        private void lbEventos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                string aux = lbEventos.SelectedItem.ToString();
                object[] tupla = miBD.Select("SELECT nombre, descripcion, fecha FROM Evento WHERE Nombre = '" + aux + "';")[0];
                string n = (string)tupla[0];
                string d = (string)tupla[1];
                DateTime f = (DateTime)tupla[2];
                eventoSeleccionado = new Evento(n, d, f);
                fEvento ventana = new fEvento(eventoSeleccionado);
                ventana.Show();
            }
            catch
            {
                throw new Error("Error");
            }
            
        }

        private void lbEventos_Click(object sender, EventArgs e)
        {
        }

        private void buttonCrearEvento_Click(object sender, EventArgs e)
        {
            fCrearEvento ventana = new fCrearEvento(user);
            this.Visible = false;
        }
    }
}

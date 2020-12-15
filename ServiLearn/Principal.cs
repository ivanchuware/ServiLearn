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
        List<Tuple<int, int>> indiceIdCurso;
        List<Tuple<int, int>> indiceIdEvento;

        private void actualizarCursos()
        {
            lbCursos.Items.Clear();
            indiceIdCurso = new List<Tuple<int, int>>();
            int index = 0;
            string filter = tbBuscadorCurso.Text;
            foreach (object[] tupla in tuplasCursos)
            {
                try
                {

                    string nombre = (string)tupla[2];

                    if (nombre.Contains(filter))
                    {
                        lbCursos.Items.Add(nombre);
                        indiceIdCurso.Add(new Tuple<int, int>(index, (int)tupla[0]));
                        index++;
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
            indiceIdEvento = new List<Tuple<int, int>>();
            int index = 0;
            foreach (object[] tupla in tuplasEventos)
            {
                try
                {


                    string nombre = (string)tupla[2];
                    if (nombre.Contains(filter))
                    {

                        lbEventos.Items.Add(nombre);
                        indiceIdEvento.Add(new Tuple<int, int>(index, (int)tupla[0]));
                        index++;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }



        }

        private bool CuentaEnCurso(Cuenta u, Curso c)
        {
            int idCuenta = u.id;
            int idCurso = c.Id;
            bool r;
            
            MySQLDB miBD = new MySQLDB();
            try
            {
                object[] tupla = miBD.Select("SELECT * FROM Cuenta_Curso WHERE id_Cuenta = '" + idCuenta + "' and id_Curso = '" + idCurso + "';")[0];


                if (idCuenta != (int)tupla[0] || idCurso != (int)tupla[1])
                {

                    r = false;

                }
                else
                {
                    r = true;
                }
            }
            catch
            {
                r = false;
            }
           
            return r;
        }


        public Principal(Cuenta u, int t)
        {
            user = u;
            tipo = t;
            InitializeComponent();

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
            int selectedCurso = -1;
            foreach (Tuple<int, int> tupla in indiceIdCurso)
            {

                if (lbCursos.SelectedIndex == tupla.Item1)
                {
                    selectedCurso = tupla.Item2;
                }
            }
            Console.WriteLine("Sel: " + lbCursos.SelectedIndex + " Curs: " + selectedCurso);
        }

        private void tbBuscadorCurso_TextChanged(object sender, EventArgs e)
        {
            actualizarCursos();
        }

        private void lbCursos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string n = lbCursos.SelectedItem.ToString();

                Curso curso = new Curso(n);



                if (CuentaEnCurso(user, curso) == true)
                {
                    PantallaCurso ventana1 = new PantallaCurso(user, tipo, curso);
                    ventana1.ShowDialog();
                }
                else
                {
                    PreviewCurso ventana2 = new PreviewCurso(user, tipo, curso);
                    ventana2.ShowDialog();
                }
            } catch (Exception exc)
            {

            }
           
        }

        private void buttonCrearCurso_Click(object sender, EventArgs e)
        {
            CreacionCurso ventana = new CreacionCurso(user, tipo);
            ventana.ShowDialog();
        }
    }
}

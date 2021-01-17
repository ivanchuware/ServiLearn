using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDLibrary;

namespace ServiLearn
{
    public partial class Principal : Form
    {
        private Cuenta user;
        private int tipo;
        private int selectedEvento = -1;
        private int selectedCurso = -1;
        int idNoticia1 = -1;
        int idNoticia2 = -1;
        int idNoticia3 = -1;
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

        private void prepararNoticias()
        {
            lNoticias.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            try
            {
                List<Noticia> lista = Noticia.listaNoticias();

                int len = lista.Count();

                if (len > 0)
                {
                    lNoticias.Visible = true;
                    panel1.Visible = true;

                    idNoticia1 = lista[0].id;
                    label2.Text = lista[0].titulo;
                    try
                    {
                        label2.Text = lista[0].titulo.Substring(0, 19) + "...";
                    } catch (Exception ex)
                    {

                    }

                    label3.Text = Regex.Replace(lista[0].texto, ".{29}", "$0\n");
                    try
                    {
                        label3.Text = label3.Text.Substring(0, 88) + "...";
                    }
                    catch (Exception ex)
                    {

                    }
                }
                if (len > 1)
                {
                    panel2.Visible = true;
                    idNoticia2 = lista[1].id;

                    label5.Text = lista[1].titulo;
                    try
                    {
                        label5.Text = lista[1].titulo.Substring(0, 19) + "...";
                    }
                    catch (Exception ex)
                    {

                    }

                    label4.Text = Regex.Replace(lista[1].texto, ".{29}", "$0\n");
                    try
                    {
                        label4.Text = label4.Text.Substring(0, 88) + "...";
                    }
                    catch (Exception ex)
                    {

                    }

                }
                if (len > 2)
                {
                    panel3.Visible = true;
                    idNoticia3 = lista[2].id;

                    label7.Text = lista[2].titulo;
                    try
                    {
                        label7.Text = lista[2].titulo.Substring(0, 19) + "...";
                    }
                    catch (Exception ex)
                    {

                    }

                    label6.Text = Regex.Replace(lista[2].texto, ".{29}", "$0\n");
                    try
                    {
                        label6.Text = label6.Text.Substring(0, 88) + "...";
                    }
                    catch (Exception ex)
                    {

                    }
                }

            } catch (Exception exG)
            {

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

        private bool CuentaEnEvento(Cuenta u, Evento e)
        {
            int idCuenta = u.id;
            int idEvento = e.Id;
            bool r;

            MySQLDB miBD = new MySQLDB();
            try
            {
                object[] tupla = miBD.Select("SELECT * FROM Cuenta_Evento WHERE id_Cuenta = " + idCuenta + " and id_Evento = " + idEvento + ";")[0];


                if (idCuenta != (int)tupla[0] || idEvento != (int)tupla[1])
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
            bGestionUsuarios.Visible = false;

            if (tipo == 2 || tipo == 4)
            {
                buttonCrearCurso.Visible = true;
            }

            if (tipo == 3 || tipo == 4)
            {
                buttonCrearEvento.Visible = true;
            }

            if(tipo == 4)
            {
                bGestionUsuarios.Visible = true;
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
            label1.Text = "Bienvenido " + user.nombre + ", está registrado como " + tp + ".";

            consultarCursos();
            consultarEventos();
            actualizarCursos();
            actualizarEventos();

            prepararNoticias();
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
            selectedCurso = -1;
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
               

                Curso curso = new Curso(selectedCurso);



                if (CuentaEnCurso(user, curso) == true)
                {
                    PantallaCurso ventana1 = new PantallaCurso(user, tipo, curso);
                    ventana1.ShowDialog();
                    
                    consultarCursos();
                    actualizarCursos();
                }
                else
                {
                    PreviewCurso ventana2 = new PreviewCurso(user, tipo, curso);
                    ventana2.ShowDialog();
                    consultarCursos();
                    actualizarCursos();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }

        private void lbEventos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                

                Evento evento = new Evento(selectedEvento);

                if (CuentaEnEvento(user, evento) == true)
                {

                    fEvento ventana1 = new fEvento(user, tipo, evento);
                    ventana1.ShowDialog();
                    consultarEventos();
                    actualizarEventos();
                }
                else
                {

                    EventoPreview ventana2 = new EventoPreview(user, tipo, evento);
                    ventana2.ShowDialog();
                    consultarEventos();
                    actualizarEventos();
                }

            }
            catch (Exception exce)
            {
                Console.WriteLine(exce.Message);
            }
        }

      

        private void lbEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEvento = -1;
            foreach (Tuple<int, int> tupla in indiceIdEvento)
            {

                if (lbEventos.SelectedIndex == tupla.Item1)
                {
                    selectedEvento = tupla.Item2;
                }
            }
            Console.WriteLine("Sel: " + lbEventos.SelectedIndex + " Evento: " + selectedEvento);
        }

        private void buttonCrearEvento_Click_1(object sender, EventArgs e)
        {
            fCrearEvento ventana3 = new fCrearEvento(user);
            ventana3.ShowDialog();
            consultarEventos();
            actualizarEventos();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void buttonCrearCurso_Click_1(object sender, EventArgs e)
        {
            CreacionCurso ventana = new CreacionCurso(user, tipo);
            ventana.ShowDialog();
            consultarCursos();
            actualizarCursos();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            consultarCursos();
            consultarEventos();
            actualizarCursos();
            actualizarEventos();
        }

        private void bCuenta_Click(object sender, EventArgs e)
        {
            fCuenta ventana = new fCuenta(user, tipo);
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fGestionUsuario ventana = new fGestionUsuario();
            ventana.ShowDialog();
        }

        private void btMsgs_Click(object sender, EventArgs e)
        {
            Mensajes msgs = new Mensajes(user);
            msgs.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                VerNoticia vn = new VerNoticia(idNoticia1, tipo == 4);
                vn.Show();
            } catch (Exception ex)
            {

            }
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                VerNoticia vn = new VerNoticia(idNoticia2, tipo == 4);
                vn.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                VerNoticia vn = new VerNoticia(idNoticia3, tipo == 4);
                vn.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            try
            {
                VerNoticia vn = new VerNoticia(idNoticia1, tipo == 4);
                vn.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                VerNoticia vn = new VerNoticia(idNoticia2, tipo == 4);
                vn.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                VerNoticia vn = new VerNoticia(idNoticia3, tipo == 4);
                vn.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Noticias n = new Noticias(tipo == 4);
                n.Show();
            }
            catch (Exception ex)
            {

            }
        }
    }
}

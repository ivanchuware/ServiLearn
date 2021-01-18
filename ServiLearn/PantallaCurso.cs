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
    public partial class PantallaCurso : Form
    {
        private Curso seleccionado;
        private Cuenta user;
        private int tipo;
        private int selectedUsuario = -1;
        List<object[]> tuplasUsuario;
        List<Tuple<int, int>> indiceIdUsuario;

        public PantallaCurso(Cuenta u, int t, Curso cur)
        {
            InitializeComponent();
            seleccionado = cur;
            user = u;
            tipo = t;
            lCurso.Text = "Curso: " + seleccionado.Nombre;
            lProfesores.Text = "Impartido por: " + seleccionado.IdOwner;
            tvCont.Text = seleccionado.Descripcion;
            tvAdic.Text = seleccionado.Adicional;
            textBox1.Text = seleccionado.Valoracion;
            textBox2.Text = seleccionado.Opiniones;

            bModCurso.Visible = false;
            bEliCurso.Visible = false;
            bExpulsar.Visible = false;

            if (seleccionado.IdOwner == user.id || tipo == 4)

            {
                bModCurso.Visible = true;
                bEliCurso.Visible = true;
                bExpulsar.Visible = true;
            }
            consultarUsuarios();
            actualizarUsuarios();
        }

        private void consultarUsuarios()
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                tuplasUsuario = miBD.Select("SELECT Cuenta.id_Cuenta, nombre FROM Cuenta JOIN Cuenta_Curso ON Cuenta.id_Cuenta = Cuenta_Curso.id_Cuenta AND Cuenta_Curso.id_Curso =" +seleccionado.Id+ ";");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void actualizarUsuarios()
        {
            lbUsuariosInscritos.Items.Clear();
            string filter = tbBuscarUsuario.Text;
            indiceIdUsuario = new List<Tuple<int, int>>();
            int index = 0;
            foreach (object[] tupla in tuplasUsuario)
            {
                try
                {


                    string nombre = (string)tupla[1];
                    if (nombre.Contains(filter))
                    {

                        lbUsuariosInscritos.Items.Add(nombre);
                        indiceIdUsuario.Add(new Tuple<int, int>(index, (int)tupla[0]));
                        index++;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bEliCurso_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado.BorrarCurso();
                seleccionado = null;
                MessageBox.Show("Se ha eliminado el curso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void lProfesores_Click(object sender, EventArgs e)
        {

        }

        private void bModCurso_Click(object sender, EventArgs e)
        {
            fCursoMod ventana = new fCursoMod(user, tipo, seleccionado.Nombre, seleccionado.Descripcion, seleccionado.Adicional);
            this.Visible = false;
            ventana.ShowDialog();
        }

        private void PantallaCurso_Load(object sender, EventArgs e)
        {

        }

        private void tvAdic_TextChanged(object sender, EventArgs e)
        {

        }

        private void bExpulsar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que quiere expulsar al usuario seleccionado?", "Advertencia", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    user = new Cuenta(selectedUsuario);
                    tipo = obtenerTipo(user);
                    MySQLDB miBD = new MySQLDB();
                    miBD.Delete("DELETE FROM Cuenta_Curso where id_Cuenta = " + user.id + ";");
                    selectedUsuario = -1;
                    MessageBox.Show("Usuario expulsado con exito");
                    actualizarUsuarios();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private int obtenerTipo(Cuenta c)
        {
            if (Invitado.esInvitado(user.id))
            {
                tipo = 0;
            }
            else if (Alumno.esAlumno(user.id))
            {
                tipo = 1;
            }
            else if (Docente.esDocente(user.id))
            {
                tipo = 2;
            }
            else if (ONG.esOng(user.id))
            {
                tipo = 3;
            }
            else
            {
                tipo = 4;
            }

            return tipo;
        }

        private void tbBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            actualizarUsuarios();
        }

        private void lbUsuariosInscritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUsuario = -1;
            foreach (Tuple<int, int> tupla in indiceIdUsuario)
            {

                if (lbUsuariosInscritos.SelectedIndex == tupla.Item1)
                {
                    selectedUsuario = tupla.Item2;
                }
            }
        }

        private void bValorar_Click(object sender, EventArgs e)
        {
            fValoracionCurso ventana = new fValoracionCurso(user, tipo, seleccionado);
            this.Close();
            ventana.Visible = true;
        }

    }
}

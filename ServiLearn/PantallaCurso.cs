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
        Cuenta user;
        int tipo;

        public PantallaCurso(Cuenta u, int t, Curso cur)
        {
            InitializeComponent();
            seleccionado = cur;
            user = u;
            tipo = t;
            lCurso.Text = "Evento: " + seleccionado.Nombre;
            lProfesores.Text = "Impartido por: " + seleccionado.IdOwner;
            tvCont.Text = seleccionado.Descripcion;
            tvAdic.Text = seleccionado.Adicional;


            bModCurso.Visible = false;
            bEliCurso.Visible = false;
            if (seleccionado.IdOwner == user.id || tipo == 4)

            {
                bModCurso.Visible = true;
                bEliCurso.Visible = true;
            }
}


        private void bModCurso_Click(object sender, EventArgs e)
        {
            fCursoMod ventana = new fCursoMod(user, tipo, seleccionado.Nombre, seleccionado.Descripcion, seleccionado.Adicional);
            this.Visible = false;
            ventana.ShowDialog();

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
<<<<<<< Updated upstream
=======

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

        private void button1_Click(object sender, EventArgs e)
        {
            fValoracionCurso ventana = new fValoracionCurso(user, seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
>>>>>>> Stashed changes
    }
}
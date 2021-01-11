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


            bModCurso.Visible = false;
            bEliCurso.Visible = false;
            if (seleccionado.IdOwner == user.id || tipo == 4)

            {
                bModCurso.Visible = true;
                bEliCurso.Visible = true;
            }
        }


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
    }
}
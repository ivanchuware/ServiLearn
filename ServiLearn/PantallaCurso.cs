using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiLearn
{
    public partial class PantallaCurso : Form
    {
        private Cuenta user;
        private int tipo;
        private Curso curso;
        public PantallaCurso(Cuenta u, int t, Curso c)
        {
            user = u;
            tipo = t;
            curso = c;
            InitializeComponent();
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

        }

        private void lProfesores_Click(object sender, EventArgs e)
        {

        }
    }
}

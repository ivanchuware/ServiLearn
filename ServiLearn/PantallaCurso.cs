using System;
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
    }
}

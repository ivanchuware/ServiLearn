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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void cnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnf_Click(object sender, EventArgs e)
        {
            Alumno c = new Alumno(nUsuario.Text, cUsuario.Text,eUsuario.Text, true);
            MessageBox.Show("Cuenta creada");
            this.Close();
        }
    }
}

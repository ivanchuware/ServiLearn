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
    public partial class RegistroTutor : Form
    {
        public RegistroTutor()
        {
            InitializeComponent();
        }

        private void nUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tlfnTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void em_Click(object sender, EventArgs e)
        {

        }

        private void cnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnf_Click(object sender, EventArgs e)
        {
            Docente c = new Docente(nTutor.Text, cTutor.Text, eTutor.Text,dTutor.Text, tlfnTutor.Text, true);
            MessageBox.Show("Cuenta creada");
            this.Close();
        }

        private void cUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void clave_Click(object sender, EventArgs e)
        {

        }

        private void nombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

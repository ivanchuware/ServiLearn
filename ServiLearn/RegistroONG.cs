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
    public partial class RegistroONG : Form
    {
        public RegistroONG()
        {
            InitializeComponent();
        }

        private void cnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnf_Click(object sender, EventArgs e)
        {
            ONG c = new ONG(nOng.Text, cOng.Text, eOng.Text, tlfnOng.Text, dOng.Text, true);
            MessageBox.Show("Cuenta creada");
            this.Close();
        }
    }
}

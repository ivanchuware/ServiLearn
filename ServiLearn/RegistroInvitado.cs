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
    public partial class RegistroInvitado : Form
    {
        public RegistroInvitado()
        {
            InitializeComponent();
        }

        private void cnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnf_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta c = new Cuenta(nInvitado.Text, cInvitado.Text, true);
                c.InsertarInvitado(c.nombre);
                MessageBox.Show("Cuenta creada");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }
    }
}

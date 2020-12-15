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
    public partial class SeleccionRegistro : Form
    {
        public SeleccionRegistro()
        {
            InitializeComponent();
        }

        private void invitado_bt_Click(object sender, EventArgs e)
        {
            RegistroInvitado ventana = new RegistroInvitado();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void usuario_bt_Click(object sender, EventArgs e)
        {
            RegistroUsuario ventana = new RegistroUsuario();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void tutor_bt_Click(object sender, EventArgs e)
        {
            RegistroTutor ventana = new RegistroTutor();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void ong_bt_Click(object sender, EventArgs e)
        {
            RegistroONG ventana = new RegistroONG();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}

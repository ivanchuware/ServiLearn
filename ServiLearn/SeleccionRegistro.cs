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

        private Login ventanaAnterior;
        private int tipo;

        public SeleccionRegistro(Login l)
        {
            tipo = -1;
            InitializeComponent();
            ventanaAnterior = l;
        }

        private void invitado_bt_Click(object sender, EventArgs e)
        {

            tipo = 0;
            Registro ventana = new Registro(tipo);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void usuario_bt_Click(object sender, EventArgs e)
        {
            tipo = 1;
            Registro ventana = new Registro(tipo);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void tutor_bt_Click(object sender, EventArgs e)
        {
            tipo = 2;
            Registro ventana = new Registro(tipo);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void ong_bt_Click(object sender, EventArgs e)
        {
            tipo = 3;
            Registro ventana = new Registro(tipo);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button invitado_bt;
        private System.Windows.Forms.Button usuario_bt;
        private System.Windows.Forms.Button tutor_bt;
        private LinkLabel linkLabel1;
        private System.Windows.Forms.Button ong_bt;

    }
}

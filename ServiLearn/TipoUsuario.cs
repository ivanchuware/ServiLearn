using System;
using System.Windows.Forms;

namespace ServiLearn
{
    public partial class TipoUsuario : Form
    {
        private Cuenta user;
        private int tipo;
        private Login ventanaAnterior;

        public TipoUsuario(Login l)
        {
            tipo = -1;
            InitializeComponent();
            ventanaAnterior = l;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void TipoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            tipo = 0;
            Registro ventana = new Registro(tipo);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void buttonAlu_Click(object sender, EventArgs e)
        {
            tipo = 1;
            Registro ventana = new Registro(tipo);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void buttonTut_Click(object sender, EventArgs e)
        {
            tipo = 2;
            Registro ventana = new Registro(tipo);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void buttonONG_Click(object sender, EventArgs e)
        {
            tipo = 3;
            Registro ventana = new Registro(tipo);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}

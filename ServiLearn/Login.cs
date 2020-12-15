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
    public partial class Login : Form
    {
        private Cuenta cuenta;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cuenta = new Cuenta(textBox1.Text, textBox2.Text);
                Main ventana = new Main(cuenta);
                this.Visible = false;
                ventana.ShowDialog();
                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SeleccionRegistro ventana = new SeleccionRegistro();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}

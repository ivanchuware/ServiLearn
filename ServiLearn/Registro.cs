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
    public partial class Registro : Form
    {
        private Cuenta user;
        private int tipo;
        private Login ventanaAnterior;

        public Registro(int t)
        {
            InitializeComponent();
            tipo = t;

            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();

            if (t == 0) {
                label4.Show();
            }

            if (t == 3) {
                label5.Show();
                label10.Show();
                textBox2.Show();
                label9.Show();
                textBox3.Show();
                label8.Show();
                textBox4.Show();
            }

            if (t == 2) {
                label6.Show();
                label10.Show();
                textBox2.Show();
                label9.Show();
                textBox3.Show();
            }

            if (t == 1) {
                label7.Show();
                label10.Show();
                textBox2.Show();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

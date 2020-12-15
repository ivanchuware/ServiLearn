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
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }
    }
}

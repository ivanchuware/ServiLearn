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
    public partial class CrearNoticia : Form
    {
        public CrearNoticia()
        {
            InitializeComponent();
            textBox1.MaxLength = 400;
            textBox2.MaxLength = 6000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("No se pueden dejar campos vacíos.", "Alerta", MessageBoxButtons.OK);
            } else
            {
                try
                {
                    Noticia.subirNoticia(textBox1.Text, textBox2.Text);
                    MessageBox.Show("Noticia creada.", "Alerta", MessageBoxButtons.OK);
                    this.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show("¡Ha habido un error! Quizás has añadido un caracter no soportado o un título/cuerpo de noticia demasiado extenso.", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}

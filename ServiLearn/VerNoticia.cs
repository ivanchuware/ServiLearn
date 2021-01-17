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
    public partial class VerNoticia : Form
    {
        int id;
        bool permisos = false;
        public VerNoticia(int id, bool p)
        {
            InitializeComponent();
            this.id = id;
            permisos = p;

            Noticia n = new Noticia(id);
            
            label1.Text = n.titulo;
            try
            {
                label1.Text = label1.Text.Substring(0, 45) + "...";
            } catch (Exception ex)
            {

            }

            textBox1.Text = "Fecha de publicación: " + n.fecha + "\r\n" + "\r\n" + n.texto;

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Noticias n = new Noticias(permisos);
                n.Show();
                this.Close();

            } catch (Exception ex)
            {

            }
            

        }
    }
}

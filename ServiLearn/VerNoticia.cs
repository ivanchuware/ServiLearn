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
        public VerNoticia(int id)
        {
            InitializeComponent();
            this.id = id;

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
    }
}

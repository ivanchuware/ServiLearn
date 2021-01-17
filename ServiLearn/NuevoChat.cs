using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiLearn
{
    public partial class NuevoChat : Form
    {
        Mensajes form = null;
        public NuevoChat(Mensajes me)
        {
            InitializeComponent();
            label3.Visible = false;
            form = me;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    Cuenta c = new Cuenta(textBox1.Text);
                    try
                    {
                        string tex = Regex.Replace(textBox2.Text, ".{55}", "$0\n");
                        Mensaje m = new Mensaje(form.id, c.id, 0, tex, "");
                        m.subirMensaje();
                        form.actualizarManteniendoEstado();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        label3.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    label3.Visible = true;
                }
            }
            
        }
    }
}

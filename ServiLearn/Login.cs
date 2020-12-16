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
<<<<<<< Updated upstream
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
=======
            try {
                user = new Cuenta(tbUsuario.Text, tbClave.Text);

                if (Invitado.esInvitado(user.id)) {
                    tipo = 0;
                } else if (Alumno.esAlumno(user.id)) {
                    tipo = 1;
                } else if (Docente.esDocente(user.id)) {
                    tipo = 2;
                } else if (ONG.esOng(user.id)) {
                    tipo = 3;
                } else
                {
                    tipo = 4;
                }
                Principal ventana = new Principal(user, tipo);



                this.Visible = false;
                ventana.ShowDialog();
                this.Visible = true;
            } catch (Exception ex) {
                MessageBox.Show("Datos incorrectos.");
>>>>>>> Stashed changes
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

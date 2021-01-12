using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ventana de logueo

namespace ServiLearn
{
    public partial class Login : Form
    {
        // ID del usuario logueado y su tipo.
        private Cuenta user;
        private int tipo;
        SeleccionRegistro registro = null;

        public Login()
        {
            InitializeComponent();
            tbClave.PasswordChar = '*';
            registro = new SeleccionRegistro(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try {
                // Se busca cuenta en base de datos.
                user = new Cuenta(tbUsuario.Text, tbClave.Text);

                // Se mira que tipo de cuenta es.
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

                ventana.Show();
                this.Hide();
            } catch (Exception ex) {
                if (ex.Message.Contains("Too many connections"))
                {
                    MessageBox.Show("Base de datos sobrecargada, por favor, intentalo de nuevo");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
              
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registro.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}

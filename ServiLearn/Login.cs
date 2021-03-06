﻿using System;
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
            tipo = -1;
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
            intentarLogueo();
        }

        private void intentarLogueo()
        {
            try
            {
                // Se busca cuenta en base de datos.
                user = new Cuenta(tbUsuario.Text, tbClave.Text);

                // Se mira que tipo de cuenta es.
                if (Invitado.esInvitado(user.id))
                {
                    tipo = 0;
                }
                else if (Alumno.esAlumno(user.id))
                {
                    tipo = 1;
                }
                else if (Docente.esDocente(user.id))
                {
                    tipo = 2;
                }
                else if (ONG.esOng(user.id))
                {
                    tipo = 3;
                }
                else
                {
                    tipo = 4;
                }
                Principal ventana = new Principal(user, tipo);
                this.Visible = false;
                ventana.ShowDialog();
                this.Visible = true;


            }
            catch (Exception ex)
            {
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
            this.Visible = false;
            registro.ShowDialog();
            this.Visible = true;
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña ventana2 = new RecuperarContraseña();
            ventana2.ShowDialog();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                intentarLogueo();
            }
        }
    }
}


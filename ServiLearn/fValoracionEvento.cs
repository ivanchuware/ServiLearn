﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDLibrary;

namespace ServiLearn
{
    public partial class fValoracionEvento : Form
    {
        private Cuenta user;
        private Evento evento;
        private int tipo;
        public fValoracionEvento(Cuenta cu, int t, Evento ev)
        {
            InitializeComponent();
            user = cu;
            evento = ev;
            tipo = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbValoracion.Text))
            {


                if (Convert.ToInt32(tbValoracion.Text) >= 0 && Convert.ToInt32(tbValoracion.Text) <= 10)
                {
                    try
                    {
                        MySQLDB miBD = new MySQLDB();
                        miBD.Update("UPDATE Cuenta_Evento SET Valoracion = " + tbValoracion.Text + " WHERE id_Cuenta = " + user.id + " AND id_Evento = " + evento.Id + ";");
                        evento = new Evento(evento.Id);
                        fEvento ventana1 = new fEvento(user, tipo, evento);
                        ventana1.Show();
                        this.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Dato no valido");
                }
            }
            else
            {
                MessageBox.Show("Introduzca un valor dentro del rango especificado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

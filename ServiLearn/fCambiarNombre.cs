using BDLibrary;
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
    public partial class fCambiarNombre : Form
    {
        private Cuenta user;
        
        private string tipotabla;
        private string tipoidCuenta;
        string tipodato;
        
        public fCambiarNombre(Cuenta u, string tt, string ti, string td, string cambio)
        {
            InitializeComponent();
            user = u;
            
            tipotabla = tt;
            tipodato = td;
            tipoidCuenta = ti;

            if (tipodato == "nombre")
            {
                lNombre.Text = "Nombre actual: " + user.nombre;
            } else if (tipodato == "email")
            {
                lNombre.Text = "Email actual: " + cambio;
                tbNombre.Text = "Nuevo Email";
                bNombre.Text = "Cambiar Email";
            } else if (tipodato == "telefono")
            {
                lNombre.Text = "Telefono actual: " + cambio;
                tbNombre.Text = "Nuevo telefono";
                bNombre.Text = "Cambiar Telefono";
            } else
            {
                lNombre.Text = "Dirección actual: " + cambio;
                tbNombre.Text = "Nueva Dirección";
                bNombre.Text = "Cambiar Direccion";
            }

        }

        private void bNombre_Click(object sender, EventArgs e)
        {
            
            MySQLDB miBD = new MySQLDB();
            
            try {

                if (tbContraseña.Text == user.clave)
                {
                    if (tipodato == "nombre")
                    {

                        if (tbNombre.Text != "")
                        {
                            miBD.Update("UPDATE Cuenta SET Nombre = '" + tbNombre.Text
                                + "' WHERE id_cuenta = '" + user.id + "';");

                            MessageBox.Show("Nombre cambiado correctamente");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nuevo Nombre de Usuario inválido");
                        }
                    }
                    else
                    {
                        miBD.Update("UPDATE " + tipotabla + " SET " + tipodato + " = '" + tbNombre.Text
                            + "' WHERE " + tipoidCuenta + " = '" + user.id + "';");
                        MessageBox.Show("Dato cambiado correctamente");
                        this.Close();
                    }
                
                } else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

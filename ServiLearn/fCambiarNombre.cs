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
        public fCambiarNombre(Cuenta u)
        {
            InitializeComponent();
            user = u;
            lNombre.Text = "Nombre actual: " + user.nombre;

        }

        private void bNombre_Click(object sender, EventArgs e)
        {
            //object[] tupla = null;
            MySQLDB miBD = new MySQLDB();
            /*try
            {
                
                tupla = miBD.Select("SELECT * FROM Cuenta WHERE nombre = '" + tbNombre + "';")[];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string texto = tupla.Length.ToString();
                MessageBox.Show(texto);*/
            try { 

                if (tbContraseña.Text == user.clave)
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

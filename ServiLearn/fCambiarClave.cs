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
    public partial class fCambiarClave : Form
    {
        private Cuenta user;
        public fCambiarClave(Cuenta u)
        {
            InitializeComponent();
            user = u;

        }

        private void bCambiarContraseña_Click(object sender, EventArgs e)
        {
            MySQLDB miBD = new MySQLDB();
            try
            {

                if (tbContraseña.Text == user.clave)
                {
                    if (tbNuevaContraseña.Text != "Introduzca la Nueva Contraseña" && tbNuevaContraseña.Text != "")
                    {
                        miBD.Update("UPDATE Cuenta SET clave = '" + tbNuevaContraseña.Text
                            + "' WHERE id_cuenta = '" + user.id + "';");

                        MessageBox.Show("Contraseña cambiada correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nueva Contraseña inválida");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

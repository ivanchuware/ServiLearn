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
    
    public partial class fCuenta : Form
    {
        private Cuenta user;
        private int tipo;
        public fCuenta(Cuenta u, int t)
        {
            InitializeComponent();
            user = u;
            tipo = t;
            actualizarCuenta();
        }
        private void actualizarCuenta()
        {
            user = new Cuenta(user.id);
            lNombre.Text = "Nombre de usuario: " + user.nombre;
            String tp;
            switch (tipo)
            {
                case 0:
                    tp = "Invitado";
                    break;
                case 1:
                    tp = "Alumno";
                    break;
                case 2:
                    tp = "Docente";
                    break;
                case 3:
                    tp = "ONG";
                    break;
                default:
                    tp = "Administrador";
                    break;
            }
            lTipo.Text = "Tipo de cuenta: " + tp;
        }

        private void bCambiarNombre_Click(object sender, EventArgs e)
        {
            fCambiarNombre ventana = new fCambiarNombre(user);
            ventana.ShowDialog();
            actualizarCuenta();
            
        }

        private void bCambiarContraseña_Click(object sender, EventArgs e)
        {
            fCambiarClave ventana = new fCambiarClave(user);
            ventana.ShowDialog();
            actualizarCuenta();
        }
    }
}

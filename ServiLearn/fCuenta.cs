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
    
    public partial class fCuenta : Form
    {
        private Cuenta user;
        private int tipo;
        private string email;
        private int telefono;
        private string direccion;
        public fCuenta(Cuenta u, int t)
        {
            InitializeComponent();
            user = u;
            tipo = t;
            actualizarCuenta();
        }
        private void actualizarCuenta()
        {
            if (tipo > 0)
            {
                try
                {
                    lEmail.Visible = true;
                    bEmail.Visible = true;
                } catch (Exception ex)
                {

                }
                if (tipo == 2 || tipo == 3)
                {
                    lTlfn.Visible = true;
                    bTlfn.Visible = true;

                }
                
            }
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

        private void bEliminarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de que quieres eliminar esta cuenta?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    String tipoidCuenta;
                    String tipodelete;
                    switch (tipo)
                    {
                        case 0:
                            tipoidCuenta = "id_Invitado";
                            tipodelete = "Invitado";
                            break;
                        case 1:
                            tipoidCuenta = "id_Alumno";
                            tipodelete = "Alumno";
                            break;
                        case 2:
                            tipoidCuenta = "id_Docente";
                            tipodelete = "Docente";
                            break;
                        case 3:
                            tipoidCuenta = "id_Ong";
                            tipodelete = "Ong";
                            break;
                        default:
                            tipoidCuenta = "id_Admin";
                            tipodelete = "Admin";
                            break;
                    }
                    MySQLDB miBD = new MySQLDB();
                    miBD.Delete("DELETE FROM " + tipodelete + " where " + tipoidCuenta + " = " + user.Id + ";");
                    miBD.Delete("DELETE FROM Cuenta_Curso where id_Cuenta = " + user.Id + ";");
                    
                    miBD.Delete("DELETE FROM Cuenta_Evento where id_Cuenta = " + user.Id + ";");
                    
                    miBD.Delete("DELETE FROM Cuenta where id_Cuenta = " + user.Id + ";");
                    MessageBox.Show("Cuenta borrada con exito");
                    this.Close();
                    Principal p = (Principal)Application.OpenForms["Principal"];
                    p.Close();

                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

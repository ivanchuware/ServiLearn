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
        private string telefono;
        private string direccion;
        private string tipoidCuenta;
        private string tipotabla;
        public fCuenta(Cuenta u, int t)
        {
            InitializeComponent();
            user = u;
            tipo = t;
            actualizarCuenta();
        }
        private void actualizarCuenta()
        {
            switch (tipo)
            {
                case 0:
                    tipoidCuenta = "id_Invitado";
                    tipotabla = "Invitado";
                    break;
                case 1:
                    tipoidCuenta = "id_Alumno";
                    tipotabla = "Alumno";
                    break;
                case 2:
                    tipoidCuenta = "id_Docente";
                    tipotabla = "Docente";
                    break;
                case 3:
                    tipoidCuenta = "id_Ong";
                    tipotabla = "Ong";
                    break;
                default:
                    tipoidCuenta = "id_Admin";
                    tipotabla = "Admin";
                    break;
            }
            try 
            {
                if (tipo > 0)
                {
                    user = new Cuenta(user.id);
                    MySQLDB miBD = new MySQLDB();
                    object[] tupla = miBD.Select("SELECT email FROM " + tipotabla + " where " + tipoidCuenta + " = " + user.Id + ";")[0];
                    lEmail.Visible = true;
                    bEmail.Visible = true;
                    email = (string)tupla[0];
                    lEmail.Text = "Tu Email es: " + email;

                        if (tipo == 2 || tipo == 3)
                        {
                            lTlfn.Visible = true;
                            bTlfn.Visible = true;
                            object[] tupla2 = miBD.Select("SELECT telefono FROM " + tipotabla + " where " + tipoidCuenta + " = " + user.Id + ";")[0];
                            telefono = (string)tupla2[0];
                            lTlfn.Text = "Tu Telefono es: " + telefono;
                           
                            if (tipo == 3)
                            {
                                lDireccion.Visible = true;
                                bDirección.Visible = true;
                                object[] tupla3 = miBD.Select("SELECT direccion FROM Ong where " + tipoidCuenta + " = " + user.Id + ";")[0];
                                direccion = (string)tupla3[0];
                            lDireccion.Text = "Tu Direccion es: " + direccion;
                            }
                        }

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
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
            fCambiarNombre ventana = new fCambiarNombre(user, tipotabla, tipoidCuenta, "nombre", user.Nombre);
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
                    
                    MySQLDB miBD = new MySQLDB();
                    miBD.Delete("DELETE FROM " + tipotabla + " where " + tipoidCuenta + " = " + user.Id + ";");
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

        private void bEmail_Click(object sender, EventArgs e)
        {
            fCambiarNombre ventana = new fCambiarNombre(user, tipotabla, tipoidCuenta, "email", email);
            ventana.ShowDialog();
            actualizarCuenta();
        }

        private void bDirección_Click(object sender, EventArgs e)
        {
            fCambiarNombre ventana = new fCambiarNombre(user, tipotabla, tipoidCuenta, "direccion", direccion);
            ventana.ShowDialog();
            actualizarCuenta();
        }

        private void bTlfn_Click(object sender, EventArgs e)
        {
            fCambiarNombre ventana = new fCambiarNombre(user, tipotabla, tipoidCuenta, "telefono", telefono);
            ventana.ShowDialog();
            actualizarCuenta();
        }
    }
}

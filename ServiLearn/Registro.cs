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
    public partial class Registro : Form
    {

        private int tipo;
        private Cuenta user;
        private String nombreRepetido;
        private Boolean hayErrores;

        public Registro(int t)
        {
            InitializeComponent();
            tipo = t;

            errorUsuario.Hide();
            errorUsuarioExiste.Hide();
            errorContr.Hide();
            errorContrCorta.Hide();
            errorCorreo.Hide();
            errorCorreoFormato.Hide();
            errorTelefono.Hide();
            errorDireccion.Hide();
            labelInvitado.Hide();
            labelONG.Hide();
            labelTutor.Hide();
            labelAlumno.Hide();
            labelDireccion.Hide();
            labelTelefono.Hide();
            labelCorreo.Hide();
            textBoxCorreo.Hide();
            textBoxTelefono.Hide();
            textBoxDireccion.Hide();

            if (t == 0)
            {
                labelInvitado.Show();
            }

            if (t == 3)
            {
                labelONG.Show();
                labelCorreo.Show();
                textBoxCorreo.Show();
                labelTelefono.Show();
                textBoxTelefono.Show();
                labelDireccion.Show();
                textBoxDireccion.Show();
            }

            if (t == 2)
            {
                labelTutor.Show();
                labelCorreo.Show();
                textBoxCorreo.Show();
                labelTelefono.Show();
                textBoxTelefono.Show();
            }

            if (t == 1)
            {
                labelAlumno.Show();
                labelCorreo.Show();
                textBoxCorreo.Show();
            }
        }


        private void linkLabelAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void buttonAceptar_Click(object sender, EventArgs e) {

            hayErrores = false;

            errorUsuario.Hide();
            errorUsuarioExiste.Hide();
            errorContr.Hide();
            errorContrCorta.Hide();
            errorCorreo.Hide();
            errorCorreoFormato.Hide();
            errorTelefono.Hide();
            errorDireccion.Hide();

            if (textBoxUsuario.Text == "") {
               
                errorUsuario.Show();
                hayErrores = true;
            }

            if (textBoxContr.Text == "") {
               
                errorContr.Show();
                hayErrores = true;
            }

            else if (textBoxContr.Text.Length < 6){

                errorContrCorta.Show();
                textBoxContr.Clear();
                hayErrores = true;
            }

            if (textBoxCorreo.Text == "" && tipo != 0) {
                
                errorCorreo.Show();
                hayErrores = true;
            }

            if (textBoxTelefono.Text == "" && tipo != 0 && tipo != 1 ) {
                
                errorTelefono.Show();
                hayErrores = true;
            }

            if (textBoxDireccion.Text == "" && tipo == 3) {

                errorDireccion.Show();
                hayErrores = true;
            }

            
            if(hayErrores == true)
            {
                MessageBox.Show("Ha habido algún problema al crear su cuenta, revise los datos aportados.");
            }
            
            else {

                //try
                {
                    List<Cuenta> lista = Cuenta.ListaCuentas();

                    foreach (Cuenta cuenta in lista)
                    {
                        if (cuenta.nombre == textBoxUsuario.Text)
                        {
                            hayErrores = true;
                            nombreRepetido = cuenta.nombre;
                            MessageBox.Show("Ya existe un Usuario con el nombre " 
                                + nombreRepetido + ", por favor cambie su Usuario.");
                            errorUsuarioExiste.Show();
                            textBoxUsuario.Clear();
                            break;
                        }
                    }

                    if (tipo != 0)
                    {

                        String correo = textBoxCorreo.Text;
                        int posicionArroba = 0;
                        int posicionPunto = 0;

                        if (correo.Contains("@")){

                            posicionArroba = correo.IndexOf("@");
                        }

                        if (correo.Contains(".")){

                            posicionPunto = correo.IndexOf(".");
                        }

                        if (posicionArroba + 1 > posicionPunto)
                        {
                            hayErrores = true;
                            MessageBox.Show("El correo electrónico introducido no tiene un formato correcto, por favor cámbielo.");
                            errorCorreoFormato.Show();
                            textBoxCorreo.Clear();
                        }
                    }

                    MySQLDB miBD = new MySQLDB();

                    if (hayErrores == false) {
                        if (tipo == 0) {

                            miBD.Insert("INSERT INTO Cuenta (nombre, clave) VALUES ( '" + textBoxUsuario.Text +
                                "' , '" + textBoxContr.Text + "' )");

                            Object[] id = miBD.Select("SELECT * FROM Cuenta WHERE nombre = '" + textBoxUsuario.Text + "';")[0];

                            int ID = (int)id[0];

                            miBD.Update("ALTER TABLE Cuenta AUTO_INCREMENT = 0;");
                            miBD.Update("SET FOREIGN_KEY_CHECKS = 0;");
                            miBD.Insert("INSERT Invitado SET id_Invitado = '" + ID + "';");
                            miBD.Update("SET FOREIGN_KEY_CHECKS = 1;");
                            miBD.Update("ALTER TABLE Cuenta AUTO_INCREMENT = 1;");

                            MessageBox.Show("La cuenta de Invitado se ha creado correctamente");                     
                        }

                        else if (tipo == 1) {

                            miBD.Insert("INSERT INTO Cuenta (nombre, clave) VALUES ( '" + textBoxUsuario.Text +
                                "' , '" + textBoxContr.Text + "' )");

                            Object[] id = miBD.Select("SELECT * FROM Cuenta WHERE nombre = '" + textBoxUsuario.Text + "';")[0];

                            int ID = (int)id[0];

                            miBD.Update("ALTER TABLE Cuenta AUTO_INCREMENT = 0;");
                            miBD.Update("SET FOREIGN_KEY_CHECKS = 0;");
                            miBD.Insert("INSERT INTO Alumno (id_Alumno,email) VALUES ('" + ID + "','" + textBoxCorreo.Text + "');");
                            miBD.Update("SET FOREIGN_KEY_CHECKS = 1;");
                            miBD.Update("ALTER TABLE Cuenta AUTO_INCREMENT = 1;");

                            MessageBox.Show("La cuenta de Alumno se ha creado correctamente");
                        }

                        else if (tipo == 2) {

                            miBD.Insert("INSERT INTO Cuenta (nombre, clave) VALUES ( '" + textBoxUsuario.Text +
                                "' , '" + textBoxContr.Text + "' )");

                            Object[] id = miBD.Select("SELECT * FROM Cuenta WHERE nombre = '" + textBoxUsuario.Text + "';")[0];

                            int ID = (int)id[0];

                            miBD.Update("ALTER TABLE Cuenta AUTO_INCREMENT = 0;");
                            miBD.Update("SET FOREIGN_KEY_CHECKS = 0;");
                            miBD.Insert("INSERT INTO Docente (id_Docente,email,telefono) " +
                                "VALUES ('" + ID + "','" + textBoxCorreo.Text + "','" + textBoxTelefono.Text + "');");
                            miBD.Update("SET FOREIGN_KEY_CHECKS = 1;");
                            miBD.Update("ALTER TABLE Cuenta AUTO_INCREMENT = 1;");

                            MessageBox.Show("La cuenta de Docente se ha creado correctamente");
                        }

                        else if (tipo == 3) {

                            miBD.Insert("INSERT INTO Cuenta (nombre, clave) VALUES ( '" + textBoxUsuario.Text +
                                "' , '" + textBoxContr.Text + "' )");

                            Object[] id = miBD.Select("SELECT * FROM Cuenta WHERE nombre = '" + textBoxUsuario.Text + "';")[0];

                            int ID = (int)id[0];

                            miBD.Update("ALTER TABLE Cuenta AUTO_INCREMENT = 0;");
                            miBD.Update("SET FOREIGN_KEY_CHECKS = 0;");
                            miBD.Insert("INSERT INTO Ong (id_Ong,email,telefono,direccion) " +
                                "VALUES ('" + ID + "','" + textBoxCorreo.Text + "','" + textBoxTelefono.Text + "','" +
                                textBoxDireccion.Text + "');");
                            miBD.Update("SET FOREIGN_KEY_CHECKS = 1;");
                            miBD.Update("ALTER TABLE Cuenta AUTO_INCREMENT = 1;");

                            MessageBox.Show("La cuenta de ONG / Adm. Pública se ha creado correctamente");
                        }
                    }
                }

                //catch (Exception ex){

                //    MessageBox.Show("Ha habido algún error al crear su cuenta.");
                //}
            }
            
        }
    }
}
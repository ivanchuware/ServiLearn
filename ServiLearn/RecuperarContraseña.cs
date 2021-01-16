using BDLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiLearn
{
    public partial class RecuperarContraseña : Form
    {
        string email;
        string email2;
        int id;
        string correo = "servilearnnoreply@gmail.com";
        string password = "sbevesbeve";
        SmtpClient smtp;
        MailMessage mm;

        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void enviarEmail(int iden, string email)
        {
            try
            {
                id = iden;
                MySQLDB miBD = new MySQLDB();
                object[] tupla = miBD.Select("SELECT clave FROM Cuenta where id_cuenta = '" + id + "' ;")[0];
                string clave = (string)tupla[0];



                smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(correo, password);

                mm = new MailMessage();
                mm.IsBodyHtml = true;
                mm.Priority = MailPriority.Normal;
                mm.From = new MailAddress(correo);
                mm.Subject = "Recuperación de Contraseña de ServiLearn";
                mm.Body = "Tu contraseña de ServiLearn asociado a este correo es: " + clave;

                mm.To.Add(new MailAddress(email));
            } catch (Exception ex)
            {
                MessageBox.Show("Hemos encontrado su direccion de correo pero, lamentablemente, no es una dirección de correo válida");
            }

            try
            {
                smtp.Send(mm);
                MessageBox.Show("Se ha enviado el correo con la contraseña");

            } catch (Exception ex)
            {
                
                MessageBox.Show("No se ha podido enviar el correo");
            }
        }
        private void bRecuperar_Click(object sender, EventArgs e)
        {
            
                email = tbEmail.Text;
                MySQLDB miBD = new MySQLDB();
                
                try
                {
                
                    object[] tupla = miBD.Select("SELECT id_Admin, email FROM Admin where email = '" + email + "' ;")[0];
                    id = (int)tupla[0];
                 
                    email2 = (string)tupla[1];
                    enviarEmail(id, email);
            }
                catch (Exception ex)
                {
                    try
                    {
                        object[] tupla2 = miBD.Select("SELECT id_Alumno, email FROM Alumno where email = '" + email + "' ;")[0];
                        id = (int)tupla2[0];
                        email2 = (string)tupla2[1];
                        enviarEmail(id, email);
                }
                    catch (Exception ex2)
                    {
                        try
                        {
                            object[] tupla3 = miBD.Select("SELECT id_Docente, email FROM Docente where email = '" + email + "' ;")[0];
                            id = (int)tupla3[0];
                            email2 = (string)tupla3[1];
                            enviarEmail(id, email);
                    }
                        catch (Exception ex3)
                        {
                            try
                            {
                                object[] tupla4 = miBD.Select("SELECT id_Ong, email FROM Ong where email = '" + email + "' ;")[0];
                                id = (int)tupla4[0];
                                email2 = (string)tupla4[1];
                                enviarEmail(id, email);
                        }
                            catch (Exception ex4)
                            {
                            
                                MessageBox.Show("No hemos podido encontrar el email en nuestro registro");
                            }
                        }
                    }
                }
            
            
        }
    }
}

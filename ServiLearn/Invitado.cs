using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ServiLearn
{
    class Invitado : Cuenta
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PWD = Properties.Settings.Default.BD_PWD;

        private string nombre;
        private string clave;
        public Invitado(string n, string c) : base(c, c)
        {

        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);
                miBD.Update("UPDATE Invitado SET Nombre = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                nombre = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);
                miBD.Update("UPDATE Invitado SET Clave = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                clave = value;
            }
        }
    }
}

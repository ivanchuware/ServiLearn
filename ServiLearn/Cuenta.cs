using System;
using System.Collections.Generic;
using System.Linq;
using BDLibrary;
using System.Text;
using System.Threading.Tasks;

namespace ServiLearn
{
    public class Cuenta
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PWD = Properties.Settings.Default.BD_PWD;

        public string nombre;
        public string clave;



        public static List<Cuenta> ListaCuentas()
        {
            List<Cuenta> lista = new List<Cuenta>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);

            foreach (object[] tupla in miBD.Select("SELECT Nombre, Clave FROM Cuenta;"))
            {
                string n = (string)tupla[0];
                string c = (string)tupla[1];
                lista.Add(new Cuenta(n, c));
            }

            return lista;
        }

        public Cuenta(string n, string c)
        {
            try
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);
                object[] tupla = miBD.Select("SELECT * FROM Cuenta WHERE Nombre = '" + n + "';")[0];

                nombre = (string)tupla[0];
                clave = (string)tupla[1];

                if (!clave.Equals(c))
                {
                    nombre = null;
                    clave = null;
                    throw new Error("Datos incorrectos: ");
                }
            }
            catch
            {
                throw new Error("Datos incorrectos: ");
            }
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
                miBD.Update("UPDATE Cuenta SET Nombre = '" + value
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
                miBD.Update("UPDATE Cuenta SET Clave = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                clave = value;
            }
        }


    }
}

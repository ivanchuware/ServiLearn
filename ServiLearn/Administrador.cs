using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;
using System.Threading.Tasks;

namespace ServiLearn
{
    class Administrador : Cuenta
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PWD = Properties.Settings.Default.BD_PWD;

        private string email;

        public Administrador(string n, string c, string e) : base(n, c)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                object[] tupla = miBD.Select("SELECT * FROM Administrador WHERE Nombre = '" + n + "';")[0];

                email = (string)tupla[2];

                if (!clave.Equals(c))
                {
                    nombre = clave = email = null;
                    throw new Error("Usuario o Contraseña Incorrecta: ");
                }
            }
            catch
            {
                throw new Error("Usuario o Contraseña Incorrecta: ");
            }
        }

        public List<Administrador> ListaAdministradores()
        {
            List<Administrador> lista = new List<Administrador>();

            MySQLDB miBD = new MySQLDB();

            foreach (object[] tupla in miBD.Select("SELECT Nombre, Clave FROM Administrador;"))
            {
                string n = (string)tupla[0];
                string p = (string)tupla[1];
                string e = (string)tupla[2];
                lista.Add(new Administrador(n, p, e));
            }

            return lista;
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Administrador SET Email = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                email = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;
using System.Threading.Tasks;

namespace ServiLearn
{
    class Alumno : Cuenta
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PWD = Properties.Settings.Default.BD_PWD;

        private string email;

        public Alumno(string n, string c, string e) : base(n,c)
        {
            try
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);
                object[] tupla = miBD.Select("SELECT * FROM Alumno WHERE Nombre = '" + n + "';")[0];

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

        public static List<Alumno> ListaAlumnos()
        {
            List<Alumno> lista = new List<Alumno>();

            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);

            foreach (object[] tupla in miBD.Select("SELECT Nombre, Clave FROM Alumno;"))
            {
                string n = (string)tupla[0];
                string p = (string)tupla[1];
                string e = (string)tupla[2];
                lista.Add(new Alumno(n, p,e));
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);
                miBD.Update("UPDATE Alumno SET Email = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                email = value;
            }
        }
    }
}

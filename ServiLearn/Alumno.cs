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
        
        private string password;
        private string email;

        public Alumno(string n, string c, string e, bool r) : base(n,c,r) {

            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Cuenta WHERE Nombre = '" + n + "';")[0];
            int idCuenta = (int)tupla[0];
            miBD.Insert("INSERT INTO Alumno VALUES(" + idCuenta  + ", '" + e + "');");

            this.nombre = n;
            this.password = c;
            this.email = e;


        }
        public Alumno(string n, string c, string e) : base(n,c)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                object[] tupla = miBD.Select("SELECT * FROM Cuenta WHERE Nombre = '" + n + "';")[0];

                
                nombre = (string)tupla[1];
                password = (string)tupla[2];

                if (!password.Equals(c))
                {
                    nombre = password = null;
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

            MySQLDB miBD = new MySQLDB();

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
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Alumno SET Email = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                email = value;
            }
        }
    }
}

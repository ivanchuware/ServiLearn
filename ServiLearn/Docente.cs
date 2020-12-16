using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ServiLearn
{
    class Docente : Cuenta
    {

        private string email;
        private string telefono;

        public static bool esDocente(int id)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                List<object[]> tuplas = miBD.Select("SELECT * FROM Docente WHERE id_Docente = " + id + ";");
                return tuplas.Count != 0;
            }
            catch (Exception e)
            {
                throw new Error(e.Message);
            }
        }

        public Docente(string n, string c, string e, string t) : base(n, c)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                object[] tupla = miBD.Select("SELECT * FROM Docente WHERE Nombre = '" + n + "';")[0];

                email = (string)tupla[2];
                telefono = (string)tupla[3];

                if (!clave.Equals(c))
                {
                    nombre = clave = email = telefono = null;
                    throw new Error("Usuario o Contraseña Incorrecta: ");
                }
            }
            catch
            {
                throw new Error("Usuario o Contraseña Incorrecta: ");
            }
        }

        public static List<Docente> ListaDocentes()
        {
            List<Docente> lista = new List<Docente>();
            MySQLDB miBD = new MySQLDB();
            foreach (object[] tupla in miBD.Select("SELECT Nombre, Clave, Email, Telefono, Direccion FROM Docente;"))
            {
                string n = (string)tupla[0];
                string p = (string)tupla[1];
                string e = (string)tupla[2];
                string t = (string)tupla[3];
                lista.Add(new Docente(n, p, e, t));
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
                miBD.Update("UPDATE Docente SET Email = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                email = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Docente SET Telefono = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                telefono = value;
            }
        }
    }
}
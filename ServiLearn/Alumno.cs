using BDLibrary;
using System;
using System.Collections.Generic;

namespace ServiLearn
{
    class Alumno : Cuenta
    {
        private string email;

        public static bool esAlumno(int id)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                List<object[]> tuplas = miBD.Select("SELECT * FROM Alumno WHERE id_Alumno = " + id + ";");
                return tuplas.Count != 0;
            }
            catch (Exception e)
            {
                throw new Error(e.Message);
            }
        }

        public Alumno(string n, string c, string e) : base(n, c)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
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

            MySQLDB miBD = new MySQLDB();

            foreach (object[] tupla in miBD.Select("SELECT Nombre, Clave FROM Alumno;"))
            {
                string n = (string)tupla[0];
                string p = (string)tupla[1];
                string e = (string)tupla[2];
                lista.Add(new Alumno(n, p, e));
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
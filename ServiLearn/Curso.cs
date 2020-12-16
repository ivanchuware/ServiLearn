using BDLibrary;
using System;
using System.Collections.Generic;

namespace ServiLearn
{
    public class Curso
    {
        private string nombre;
        private string descripcion;
        private int idOwner;
        private int id;

        public Curso(string n)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Curso WHERE nombre = '" + n + "';")[0];

            id = (int)tupla[0];
            idOwner = (int)tupla[1];
            nombre = (string)tupla[2];
            descripcion = (string)tupla[3];
        }
        public Curso(string n, string d)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Curso WHERE nombre = '" + n + "';")[0];

            id = (int)tupla[0];
            idOwner = (int)tupla[1];
            nombre = (string)tupla[2];
            descripcion = (string)tupla[3];
        }

        public List<Curso> ListaCursos()
        {
            List<Curso> lista = new List<Curso>();
            MySQLDB miBD = new MySQLDB();

            foreach (object[] tupla in miBD.Select("SELECT nombre, descripcion FROM Curso;"))
            {
                string n = (string)tupla[2];
                string d = (string)tupla[3];
                lista.Add(new Curso(n, d));
            }
            return lista;
        }


        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Curso SET nombre = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                nombre = value;
            }
        }

        public String Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Curso SET descripcion = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                descripcion = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }


        }
        public int IdOwner
        {
            get
            {
                return idOwner;
            }
        }



    }
}
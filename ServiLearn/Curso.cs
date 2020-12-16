﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;
using System.Threading.Tasks;

namespace ServiLearn
{
    public class Curso
    {
        private string nombre;
        private string descripcion;
        private int id;
        private int idOwner;
        private string adicional;

        public Curso(string n)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Curso WHERE nombre = '" + n + "';")[0];

            id = (int)tupla[0];
            idOwner = (int)tupla[1];
            nombre = (string)tupla[2];
            descripcion = (string)tupla[3];
            adicional = (string)tupla[4];
        }

        public Curso(int id)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Curso WHERE id_Curso = " + id + ";")[0];

            try
            {
                adicional = (string)tupla[4];
            }
            catch (Exception e)
            {
                adicional = "";
                Console.WriteLine(e.Message);
            }

            this.id = id;
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
            adicional = (string)tupla[4];
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
        public String Adicional
        {
            get
            {
                return adicional;
            }

            set
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Curso SET adicional = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                descripcion = value;
            }
        }
        public int IdOwner
        {
            get
            {
                return idOwner;
            }
        }

        public void BorrarCurso()
        {
            MySQLDB miBD = new MySQLDB();
            miBD.Delete("DELETE FROM Cuenta_Curso where id_Curso = '" + id + "';");
            miBD.Delete("DELETE FROM Curso where nombre = '" + nombre + "';");
            nombre = descripcion = null;

        }




    }
}
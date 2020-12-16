using BDLibrary;
using System;
using System.Collections.Generic;

namespace ServiLearn
{
    public class Evento
    {
        private string nombre;
        private string descripcion;
        private string adicional;
        private int id;
        private int idOwner;

        public Evento(string n)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Evento WHERE nombre = '" + n + "';")[0];
            id = (int)tupla[0];
            idOwner = (int)tupla[1];
            nombre = (string)tupla[2];
            descripcion = (string)tupla[3];
            try
            {

                if (!tupla[4].GetType().Equals(System.DBNull.Value))
                {
                    adicional = (string)tupla[4];
                }
                else
                {
                    adicional = "";
                }
            }
            catch (Exception e)
            {
                adicional = "";
            }


        }
        public Evento(string n, string d)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Evento WHERE nombre = '" + n + "';")[0];
            id = (int)tupla[0];
            idOwner = (int)tupla[1];
            nombre = (string)tupla[2];
            descripcion = (string)tupla[3];
            adicional = (string)tupla[4];


        }

        public List<Evento> ListaEventos()
        {
            List<Evento> lista = new List<Evento>();
            MySQLDB miBD = new MySQLDB();

            foreach (object[] tupla in miBD.Select("SELECT Nombre, Descripcion, Fecha FROM Evento;"))
            {
                string n = (string)tupla[0];
                string d = (string)tupla[1];
                DateTime f = (DateTime)tupla[2];
                lista.Add(new Evento(n, d));
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
                miBD.Update("UPDATE Evento SET nombre = '" + value
                        + "' WHERE nombre = '" + nombre + "';");
                nombre = value;
            }
        }
        public string Adicional
        {
            get
            {
                return adicional;
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

        public String Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Evento SET Descripcion = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                descripcion = value;
            }
        }



        public void BorrarEvento()
        {
            MySQLDB miBD = new MySQLDB();
            miBD.Delete("DELETE FROM Cuenta_Evento where id_Evento = '" + id + "';");
            miBD.Delete("DELETE FROM Evento where nombre = '" + nombre + "';");
            nombre = descripcion = null;

        }
    }
}
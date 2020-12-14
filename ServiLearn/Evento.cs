﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiLearn
{
    class Evento
    {
        private string nombre;
        private string descripcion;
        private int fecha;

        public Evento(string n, string d, int fecha)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT * FROM Evento WHERE Nombre = '" + n + "';")[0];

            nombre = (string)tupla[0];
            descripcion = (string)tupla[1];
            //fecha = (int)tupla[2];
        }

        public List<Evento> ListaEventos()
        {
            List<Evento> lista = new List<Evento>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT Nombre, Descripcion, Fecha FROM Evento;"))
            {
                string n = (string)tupla[0];
                string d = (string)tupla[1];
                int f = (int)tupla[2];
                lista.Add(new Evento(n, d, f));
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Evento SET Nombre = '" + value
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Evento SET Descripcion = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                descripcion = value;
            }
        }

        public int Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Evento SET Fecha = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                fecha = value;
            }
        }
    }
}
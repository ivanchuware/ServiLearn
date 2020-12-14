﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiLearn
{
    class ONG : Cuenta
    {
        private string email;
        private string telefono;
        private string direccion;

        public ONG(string n, string c, string e, string t, string d) : base(n, c)
        {
            try
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                object[] tupla = miBD.Select("SELECT * FROM ONG WHERE Nombre = '" + n + "';")[0];

                email = (string)tupla[2];
                telefono = (string)tupla[3];
                direccion = (string)tupla[4];

                if (!clave.Equals(c))
                {
                    nombre = clave = email = telefono = direccion = null;
                    throw new Error("Usuario o Contraseña Incorrecta: ");
                }
            }
            catch
            {
                throw new Error("Usuario o Contraseña Incorrecta: ");
            }
        }

        public static List<ONG> ListaONGs()
        {
            List<ONG> lista = new List<ONG>();

            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT Nombre, Clave, Email FROM ONG;"))
            {
                string n = (string)tupla[0];
                string p = (string)tupla[1];
                string e = (string)tupla[2];
                string t = (string)tupla[3];
                string d = (string)tupla[4];
                lista.Add(new ONG(n, p, e,t,d));
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ONG SET Email = '" + value
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ONG SET Telefono = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ONG SET Direccion = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                direccion = value;
            }
        }

    }
}

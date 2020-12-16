using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ServiLearn
{
    public class Cuenta
    {

        public string nombre;
        public string clave;
        public int id;



        public static List<Cuenta> ListaCuentas()
        {
            List<Cuenta> lista = new List<Cuenta>();
            MySQLDB miBD = new MySQLDB();

            foreach (object[] tupla in miBD.Select("SELECT nombre, clave FROM Cuenta;"))
            {
                string n = (string)tupla[0];
                string c = (string)tupla[1];
                lista.Add(new Cuenta(n, c));
            }

            return lista;
        }

        public Cuenta(string n, string c)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();

                object[] tupla = miBD.Select("SELECT * FROM Cuenta WHERE nombre = '" + n + "';")[0];

                id = (int)tupla[0];

                nombre = (string)tupla[1];
                Console.Write(nombre);
                clave = (string)tupla[2];
                
                if (!clave.Equals(c))
                {
                    nombre = null;
                    clave = null;
                    throw new Error("Datos incorrectos.");
                }
            }
            catch
            {
                throw new Error("Datos incorrectos.");
            }
        }

        public Cuenta(int i)
        {
            MySQLDB miBD = new MySQLDB();

            object[] tupla = miBD.Select("SELECT * FROM Cuenta WHERE id_Cuenta = '" + i + "';")[0];

            id = (int)tupla[0];
            nombre = (string)tupla[1];
            clave = (string)tupla[2];

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
                miBD.Update("UPDATE Cuenta SET Nombre = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                nombre = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Cuenta SET Clave = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                clave = value;
            }
        }


    }
}

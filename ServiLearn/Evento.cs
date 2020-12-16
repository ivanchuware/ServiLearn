using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;
using System.Threading.Tasks;

namespace ServiLearn
{
    class Evento
    {
<<<<<<< Updated upstream
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PWD = Properties.Settings.Default.BD_PWD;

        private string nombre;
        private string descripcion;
        private int fecha;

        public Evento(string n, string d, int fecha)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Evento WHERE Nombre = '" + n + "';")[0];

            nombre = (string)tupla[0];
            descripcion = (string)tupla[1];
            //fecha = (int)tupla[2];
=======

        private string nombre;
        private string descripcion;
        private string adicional;
        private int id;
        private int idOwner;

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


>>>>>>> Stashed changes
        }

        public List<Evento> ListaEventos()
        {
            List<Evento> lista = new List<Evento>();
            MySQLDB miBD = new MySQLDB();

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
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Evento SET Nombre = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                nombre = value;
            }
        }
<<<<<<< Updated upstream
=======

        public string Adicional
        {
            get
            {
                return adicional;
            }
>>>>>>> Stashed changes

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

<<<<<<< Updated upstream
        public int Fecha
=======

        public String Descripcion
>>>>>>> Stashed changes
        {
            get
            {
                return fecha;
            }

            set
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Evento SET Fecha = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                fecha = value;
            }
        }
<<<<<<< Updated upstream
=======

        public void BorrarEvento()
        {
            MySQLDB miBD = new MySQLDB();
            miBD.Delete("DELETE FROM Cuenta_Evento where id_Evento = '" + id + "';");
            miBD.Delete("DELETE FROM Evento where nombre = '" + nombre + "';");
            nombre = descripcion = null;

        }


>>>>>>> Stashed changes
    }
}

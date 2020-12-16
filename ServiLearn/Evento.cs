using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ServiLearn
{
    public class Evento
    {
        private string nombre;
        private string descripcion;
        private DateTime fecha;

        public Evento(string n, string d, DateTime fecha)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Evento WHERE nombre = '" + n + "';")[0];
            nombre = (string)tupla[2];
            descripcion = (string)tupla[3];
            fecha = (DateTime)tupla[5];
            
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
                miBD.Update("UPDATE Evento SET nombre = '" + value
                        + "' WHERE nombre = '" + nombre + "';");
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
                miBD.Update("UPDATE Evento SET Descripcion = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                descripcion = value;
            }
        }

        public DateTime Fecha
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

        public void BorrarEvento()
        {
            MySQLDB miBD = new MySQLDB();
            miBD.Delete("DELETE FROM Evento where nombre = '" + nombre + "';");
            nombre = descripcion = null;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;
using System.Threading.Tasks;

namespace ServiLearn
{
    public class Evento
    {
        private string nombre;
        private string descripcion;
        private string adicional;
        private int id;
        private int idOwner;
        private double valoracion = 0;
        private int opiniones = 0;
        private string fecha;

        public Evento(string n, string d)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Evento WHERE nombre = '" + n + "';")[0];
            id = (int)tupla[0];
            idOwner = (int)tupla[1];
            nombre = (string)tupla[2];
            descripcion = (string)tupla[3];
            fecha = (string)tupla[5];

            try
            {
                adicional = (string)tupla[4];
            }
            catch (Exception e)
            {
                adicional = "";
                Console.WriteLine(e.Message);
            }

            int sumavaloracion = 0;

            try
            {
                List<object[]> val = miBD.Select("SELECT Valoracion FROM Cuenta_Evento WHERE id_Evento = " + this.id + " AND " +
                                    "Valoracion IS NOT NULL;");

                if (val.Count != 0)
                {
                    foreach (object[] a in val)
                    {
                        {
                            sumavaloracion += (int)a[0];
                        }

                    }

                    valoracion = Math.Round((double)sumavaloracion / (double)val.Count, 2);
                    opiniones = val.Count;

                }

                else
                {
                    valoracion = 0;
                    opiniones = 0;
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Evento(string n)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Evento WHERE nombre = '" + n + "';")[0];
            id = (int)tupla[0];
            idOwner = (int)tupla[1];
            nombre = (string)tupla[2];
            descripcion = (string)tupla[3];
            fecha = (string)tupla[5];

            try
            {
                adicional = (string)tupla[4];
            }
            catch (Exception e)
            {
                adicional = "";
                Console.WriteLine(e.Message);
            }

            int sumavaloracion = 0;

            try
            {
                List<object[]> val = miBD.Select("SELECT Valoracion FROM Cuenta_Evento WHERE id_Evento = " + this.id + " AND " +
                                    "Valoracion IS NOT NULL;");

                if (val.Count != 0)
                {
                    foreach (object[] a in val)
                    {
                        {
                            sumavaloracion += (int)a[0];
                        }

                    }

                    valoracion = Math.Round((double)sumavaloracion / (double)val.Count, 2);
                    opiniones = val.Count;

                }

                else
                {
                    valoracion = 0;
                    opiniones = 0;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Evento(int id)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Evento WHERE id_Evento = " + id + ";")[0];
            this.id = id;
            idOwner = (int)tupla[1];
            nombre = (string)tupla[2];
            descripcion = (string)tupla[3];
            fecha = (string)tupla[5];

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

            int sumavaloracion = 0;

            try
            {
                List<object[]> val = miBD.Select("SELECT Valoracion FROM Cuenta_Evento WHERE id_Evento = " + this.id + " AND " +
                                    "Valoracion IS NOT NULL;");

                if (val.Count != 0)
                {
                    foreach (object[] a in val)
                    {
                        {
                            sumavaloracion += (int)a[0];
                        }

                    }

                    valoracion = Math.Round((double)sumavaloracion / (double)val.Count, 2);
                    opiniones = val.Count;

                }

                else
                {
                    valoracion = 0;
                    opiniones = 0;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
                miBD.Update("UPDATE Evento SET Nombre = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
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

        public string Fecha
        {
            get
            {
                return fecha;
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

        public string Valoracion
        {

            get
            {
                return valoracion + " / 10";
            }
        }

        public string Opiniones
        {

            get
            {
                return opiniones + "";
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

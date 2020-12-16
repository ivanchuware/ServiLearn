using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ServiLearn
{
    class Curso
    {

        private string nombre;
        private string descripcion;

        public Curso(string n, string d)
        {
            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Curso WHERE Nombre = '" + n + "';")[0];

            nombre = (string)tupla[0];
            descripcion = (string)tupla[1];
        }

        public List<Curso> ListaCursos()
        {
            List<Curso> lista = new List<Curso>();
            MySQLDB miBD = new MySQLDB();

            foreach (object[] tupla in miBD.Select("SELECT Nombre, Descripcion FROM Curso;"))
            {
                string n = (string)tupla[0];
                string d = (string)tupla[1];
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
                miBD.Update("UPDATE Curso SET Nombre = '" + value
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
                miBD.Update("UPDATE Curso SET Descripcion = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                descripcion = value;
            }
        }
    }


}

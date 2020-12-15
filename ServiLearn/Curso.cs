using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;
using System.Threading.Tasks;

namespace ServiLearn
{
    class Curso
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PWD = Properties.Settings.Default.BD_PWD;

        private string nombre;
        private string descripcion;

        public Curso(string n, string d)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);
            object[] tupla = miBD.Select("SELECT * FROM Curso WHERE Nombre = '" + n + "';")[0];

            nombre = (string)tupla[0];
            descripcion = (string)tupla[1];
        }

        public List<Curso> ListaCursos()
        {
            List<Curso> lista = new List<Curso>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);

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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PWD);
                miBD.Update("UPDATE Curso SET Descripcion = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                descripcion = value;
            }
        }
    }


}

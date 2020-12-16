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
<<<<<<< Updated upstream
=======
        private int id;
        private int idOwner;
        private string adicional;
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
    }


}
=======
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
>>>>>>> Stashed changes

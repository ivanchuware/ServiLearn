using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ServiLearn
{
    class ONG : Cuenta
    {
        private string email;
        private string telefono;
        private string direccion;

        public static bool esOng(int id)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                List<object[]> tuplas = miBD.Select("SELECT * FROM Ong WHERE id_Ong = " + id + ";");
                return tuplas.Count != 0;
            }
            catch (Exception e)
            {
                throw new Error(e.Message);
            }
        }
        public ONG(string n, string c, string e, string t, string d) : base(n, c)
        {

        }

    }
}


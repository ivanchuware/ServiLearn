using BDLibrary;
using System;
using System.Collections.Generic;

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

        public ONG(string n, string c, string e, string t, string d, bool r) : base(n, c, r)
        {

            MySQLDB miBD = new MySQLDB();
            object[] tupla = miBD.Select("SELECT * FROM Cuenta WHERE Nombre = '" + n + "';")[0];
            int idCuenta = (int)tupla[0];
            miBD.Insert("INSERT INTO Ong VALUES(" + idCuenta + ", '" + e + "', '" + t + "', '" + d + "');");


            this.email = e;
            this.telefono = t;
            this.direccion = d;


        }

    }
}


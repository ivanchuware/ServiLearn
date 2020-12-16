using BDLibrary;
using System;
using System.Collections.Generic;

namespace ServiLearn
{

    class Invitado : Cuenta
    {

        public Invitado(string n, string c) : base(n, c)
        {

        }

        public static bool esInvitado(int id)
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                List<object[]> tuplas = miBD.Select("SELECT * FROM Invitado WHERE id_Invitado = " + id + ";");
                return tuplas.Count != 0;
            }
            catch (Exception e)
            {
                throw new Error(e.Message);
            }
        }



    }
}

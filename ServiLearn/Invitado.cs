using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ServiLearn
{
    class Invitado : Cuenta
    {
        

       
        public Invitado(string n, string c, bool r) : base(c, c, r)
        {

            
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
                miBD.Update("UPDATE Invitado SET Nombre = '" + value
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
                miBD.Update("UPDATE Invitado SET Clave = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                clave = value;
            }
        }
    }
}

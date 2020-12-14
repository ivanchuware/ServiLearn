using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiLearn
{
    class Invitado : Cuenta
    {
        private string nombre;
        private string clave;
        public Invitado(string n, string c) : base(c, c)
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Invitado SET Clave = '" + value
                        + "' WHERE Nombre = '" + nombre + "';");
                clave = value;
            }
        }
    }
}

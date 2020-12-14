using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiLearn
{
    class ONG : Cuenta
    {
        private string nombre;
        private string clave;
        private string email;
        private string telefono;
        private string direccion;

        public ONG(string n, string c, string e, string t, string d) : base(n, c)
        {

        }

    }
}

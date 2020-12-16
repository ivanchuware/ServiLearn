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
        public Invitado(string n, string c) : base(c, c)
        {

        }

    }
}

using System;


namespace ServiLearn
{
    class Error : Exception
    {
        public Error() : base() { }
        public Error(string message) : base(message) { }
    }
}

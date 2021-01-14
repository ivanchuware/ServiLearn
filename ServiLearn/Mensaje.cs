using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ServiLearn
{
    class Mensaje
    {
        //string formatForMySql = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
        public string fecha;
        public int idOrigen;
        public int idDestino;
        public int leido;
        public string texto;
        public int id;



        public Mensaje(int o, int d, int l, string t, string f, int i)
        {
            fecha = f;
            idOrigen = o;
            idDestino = d;
            leido = l;
            texto = t;
            id = i;
        }

        public Mensaje(int o, int d, int l, string t, string f)
        {
            fecha = f;
            idOrigen = o;
            idDestino = d;
            leido = l;
            texto = t;
            id = -1;
        }

        public static List<Mensaje> ListaMensajesDeUsuario(int id)
        {
            List<Mensaje> lista = new List<Mensaje>();
            MySQLDB miBD = new MySQLDB();

            foreach (object[] tupla in miBD.Select("SELECT * FROM Mensajes where idOrigen = " + id + " or idDestino = " + id + ";"))
            {
                int i = (int)tupla[0];
                int o = (int)tupla[1];
                int d = (int)tupla[2];
                string t = (string)tupla[3];
                int l = (int)tupla[4];
                string f = ((DateTime)tupla[5]).ToString("dd-MM-yyyy HH:mm:ss"); 


                lista.Add(new Mensaje(o, d, l, t, f, i));
            }

            return lista;
        }
    }
}

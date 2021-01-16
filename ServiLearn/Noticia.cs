using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ServiLearn
{
    class Noticia
    {
        public int id;
        public string titulo;
        public string texto;
        public string fecha;

        public Noticia(int id, string titulo, string texto, string fecha)
        {
            this.id = id;
            this.titulo = titulo;
            this.texto = texto;
            this.fecha = fecha;
        }

        public Noticia(int id)
        {
            MySQLDB miBD = new MySQLDB();

            object[] tupla = miBD.Select("SELECT * FROM Noticias where idNoticias = " + id + ";")[0];

            this.titulo = (string)tupla[2];
            this.texto = (string)tupla[3];
            this.fecha = ((DateTime)tupla[1]).ToString("dd-MM-yyyy HH:mm:ss");
            this.id = id;
        }

        public static List<Noticia> listaNoticias()
        {
            List<Noticia> lista = new List<Noticia>();
            MySQLDB miBD = new MySQLDB();

            foreach (object[] tupla in miBD.Select("SELECT * FROM Noticias ORDER BY fecha DESC;"))
            {
                int id = (int)tupla[0];
                string fecha = ((DateTime)tupla[1]).ToString("dd-MM-yyyy HH:mm:ss");
                string titulo = (string)tupla[2];
                string texto = (string)tupla[3];



                lista.Add(new Noticia(id, titulo, texto, fecha));
            }

            return lista;
        }

        public static void subirNoticia(string titulo, string texto)
        {
            MySQLDB miBD = new MySQLDB();

            miBD.Insert("Insert into Noticias (titulo, texto) values ('" + titulo + "','" + texto + "');");
        }

        public static void deleteNoticia(int id)
        {
            MySQLDB miBD = new MySQLDB();

            miBD.Delete("Delete from Noticias where idNoticias = " + id + ";");
        }

        public static void modificarNoticia(int id, string titulo, string texto)
        {
            MySQLDB miBD = new MySQLDB();

            miBD.Update("Update Noticias set titulo = '" + titulo + "', texto = '" + texto + "' where idNoticias = " + id + ";");
        }
    }
}

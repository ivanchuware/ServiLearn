using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDLibrary;

namespace ServiLearn
{
    public partial class Calendario : Form
    {
        bool permisos = false;
        List<Noticia> noticias;
        public Calendario()
        {
            InitializeComponent();
            actualizar();
        }

        private void actualizar()
        {
            try
            {
                mostrarCalendario();

            }
            catch (Exception ex)
            {

            }


        }
        private void mostrarCalendario()
        {
            MySQLDB miBD = new MySQLDB();

            foreach (object[] tupla in miBD.Select("SELECT Nombre, Descripcion, Fecha FROM Evento;"))
            {
                string n = (string)tupla[0];
                string d = (string)tupla[1];
                var f =
                _ = (tupla[2] != null) ? tupla[2] : "";

                var ev = new Calendar.NET.CustomEvent
                {

                    EventColor = Color.Aquamarine,
                    EventTextColor = Color.Black,
                    Date = DateTime.Parse((string)f),
                    EventText = n,

                };

                calendar1.AddEvent(ev);

            }
        }
    }
}

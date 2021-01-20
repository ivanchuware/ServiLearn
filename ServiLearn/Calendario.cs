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

        private Cuenta user;
        private int tipoCal;

        public Calendario(Cuenta u, int t)
        {
            
            InitializeComponent();
            user = u;
            tipoCal = t;

            if (t == 0)
            {
                actualizar();
            }
            else
            {
                actualizarMisEventos();
            }

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

        private void actualizarMisEventos()
        {
            //try
            {
                mostrarCalendarioUser(user);

            }
            //catch (Exception ex)
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

        private void mostrarCalendarioUser(Cuenta u)
        {
            List<Evento> misEventos = u.ListaEventosUser();

            foreach (Evento e in misEventos)
            {
                string n = e.Nombre;
                string d = e.Descripcion;
                var f =
                _ = (e.Fecha != null) ? e.Fecha : "";

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
        

        private void button1_Click(object sender, EventArgs e)
        {
            Calendario c = new Calendario(user, 0);
            c.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calendario c = new Calendario(user, 1);
            c.Show();
            this.Close();
        }
    }
}

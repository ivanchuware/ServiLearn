using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiLearn
{
    public partial class Mensajes : Form
    {
        List<Mensaje> listaMsgs = null;
        List<Tuple<int, Cuenta>> tuplaIndiceUsuario = null;
        int id;

        public Mensajes(Cuenta user)
        {
            InitializeComponent();
            id = user.id;
            actualizarMsgs();
            listarChats();

        }

        private void actualizarMsgs()
        {
            listaMsgs = Mensaje.ListaMensajesDeUsuario(id);
        }

        private void listarChats()
        {
            HashSet<int> conjuntoDeChats = new HashSet<int>();
            listBox2.Items.Clear();

            foreach (Mensaje m in listaMsgs) {
                if (m.idDestino == id)
                {
                    conjuntoDeChats.Add(m.idOrigen);
                } else
                {
                    conjuntoDeChats.Add(m.idDestino);
                }
            }

            tuplaIndiceUsuario = new List<Tuple<int, Cuenta>>();

            int i = -1;

            foreach (int idCuenta in conjuntoDeChats)
            {
                i++;
                Cuenta c = new Cuenta(idCuenta);
                tuplaIndiceUsuario.Add(new Tuple<int, Cuenta>(i, c));
                listBox2.Items.Add(c.nombre);
            }
        }

        private void listarMensajes(Cuenta c)
        {
            List<Mensaje> msgs = new List<Mensaje>();
            foreach (Mensaje m in listaMsgs)
            {
                if (m.idDestino == c.Id || m.idOrigen == c.Id)
                {
                    msgs.Add(m);
                }
                
            }
            listBox1.Items.Clear();
            foreach (Mensaje m in msgs)
            {
                string t;
                string h;
                if (m.idOrigen == c.Id)
                {
                    h = " " + c.nombre + " (" + m.fecha + ") >>\n";
                } else
                {
                    h = "                                   << Tú (" + m.fecha + ")  \n";
                }

                t = h + m.texto;
                listBox1.Items.Add(t);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tuplaIndiceUsuario != null || listBox2.SelectedIndex != -1) { 
                bool encontrado = false;
                var iter = tuplaIndiceUsuario.GetEnumerator();
                iter.MoveNext();
                while (!encontrado)
                {
                    if (iter.Current.Item1 == listBox2.SelectedIndex)
                    {
                        encontrado = true;
                    }
                    else
                    {
                        iter.MoveNext();
                    }
                }
                listarMensajes(iter.Current.Item2);
            }
        }
    }
}

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

namespace ServiLearn
{
    public partial class Mensajes : Form
    {
        List<Mensaje> listaMsgs = null;
        List<Tuple<int, Cuenta>> tuplaIndiceUsuario = null;
        public int id;
        int idDestinoChat = -1;

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
            string filter = textBox1.Text;
            foreach (int idCuenta in conjuntoDeChats)
            {
                Cuenta c = new Cuenta(idCuenta);
                if (c != null && c.nombre.Contains(filter))
                {
                    i++;
                    tuplaIndiceUsuario.Add(new Tuple<int, Cuenta>(i, c));
                    listBox2.Items.Add(c.nombre);
                }
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
            

            
            DataTable table = new DataTable();


            table.Columns.Add("Mensaje");
            table.Columns[0].ReadOnly = true;
            

            foreach (Mensaje m in msgs)
            {
                string t;
                string h;
                if (m.idOrigen == c.Id)
                {
                    h = "   " + c.nombre + " (" + m.fecha + ") >>\n\n";
                } else
                {
                    h = "                                                          << Tú (" + m.fecha + ")\n\n";
                }

                t = h + m.texto;
                table.Rows.Add(t);
            }

            dataGridView1.DataSource = table;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarChatSeleccionado();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            idDestinoChat = -1;
            dataGridView1.DataSource = null;
            listarChats();
        }

        private void actualizarChatSeleccionado()
        {
            if (listBox2.SelectedIndex == -1)
            {
                
            }
            else if (tuplaIndiceUsuario != null)
            {
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

                idDestinoChat = iter.Current.Item2.Id;

                listarMensajes(iter.Current.Item2);
            }
        }

        public void actualizarManteniendoEstado()
        {
            int sel = listBox2.SelectedIndex;
            actualizarMsgs();
            listarChats();
            actualizarChatSeleccionado();
            listBox2.SelectedIndex = sel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarManteniendoEstado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    if (idDestinoChat != -1)
                    {
                        string tex = Regex.Replace(textBox2.Text, ".{55}", "$0\n");
                        Mensaje m = new Mensaje(id, idDestinoChat, 0, tex, "");

                        m.subirMensaje();
                        textBox2.Text = "";
                        actualizarManteniendoEstado();
                    } else
                    {
                        Console.WriteLine("No se encuentra destino");
                    }
                    
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void Mensajes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoChat nc = new NuevoChat(this);
            nc.ShowDialog();
        }
    }
}

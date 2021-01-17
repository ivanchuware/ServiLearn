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
    public partial class Noticias : Form
    {
        bool permisos = false;
        List<Noticia> noticias;
        public Noticias(bool p)
        {
            InitializeComponent();
            permisos = p;
            mostrarControles();
            actualizar();
        }

        private void actualizar()
        {
            try
            {
                noticias = Noticia.listaNoticias();
                mostrarTablon();
            
            }
            catch (Exception ex)
            {

            }
    
            
        }

        private void mostrarControles()
        {
            button1.Visible = permisos;
            button2.Visible = permisos;
            button3.Visible = permisos;
        }

        private void mostrarTablon()
        {
            DataTable table = new DataTable();


            table.Columns.Add("Noticia");
            table.Columns.Add("ID");
            table.Columns[1].DataType = typeof(Int32);


            foreach (Noticia n in noticias)
            {
                string titulo = n.titulo;
                string texto = n.texto;

                if (titulo.ToUpper().Contains(textBox1.Text.ToUpper()) || texto.ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    try
                    {
                        titulo = titulo.Substring(0, 60) + "...";
                    }
                    catch (Exception ex)
                    {

                    }

                    try
                    {
                        texto = texto.Substring(0, 520) + "...";
                    }
                    catch (Exception ex)
                    {

                    }

                    texto = Regex.Replace(texto, ".{80}", "$0\n");

                    table.Rows.Add("\n" + titulo + " (" + n.fecha + ")\n\n" + texto + "\n", n.id);
                }
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
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.ClearSelection();
            





        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            try
            {
                var selectedCell = dataGridView1.SelectedCells[0];
                button1.Enabled = true;
                button2.Enabled = true;
            } catch (Exception ex)
            {

            }
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var selectedCell = dataGridView1.SelectedCells[0];
                int id = (int)dataGridView1.Rows[selectedCell.RowIndex].Cells[1].Value;

                VerNoticia vn = new VerNoticia(id, permisos);
                vn.Show();
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar la noticia?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var selectedCell = dataGridView1.SelectedCells[0];
                    int id = (int)dataGridView1.Rows[selectedCell.RowIndex].Cells[1].Value;

                    Noticia.deleteNoticia(id);

                    actualizar();
                } catch (Exception ex)
                {

                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearNoticia cn = new CrearNoticia();
            cn.ShowDialog();
            actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCell = dataGridView1.SelectedCells[0];
                int id = (int)dataGridView1.Rows[selectedCell.RowIndex].Cells[1].Value;

                ModificarNoticia mn = new ModificarNoticia(id);
                mn.ShowDialog();
                actualizar();
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}

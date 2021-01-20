using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDLibrary;

namespace ServiLearn
{
    public partial class fCrearEvento : Form
    {

        public Cuenta seleccionado;
        public fCrearEvento(Cuenta u)
        {
            InitializeComponent();
            seleccionado = u;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySQLDB miBD = new MySQLDB();
            //Object[] tupla = miBD.Select("SELECT id_Cuenta FROM Cuenta WHERE Nombre = '" + seleccionado.nombre + "';")[0];
            //int id_cue = (int)tupla[0];
            int id_cue = seleccionado.id;
            string nombre = textBox1.Text;
            string descripcion = textBox2.Text;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = " HH:mm:ss";
            string dateFinal = dateTimePicker1.Text + dateTimePicker2.Text;
            if (!nombre.Equals("") && !descripcion.Equals(""))
            {
                
                //miBD.Insert("INSERT INTO Evento VALUES (null, '" + id_cue + "','" +nombre+ "', '" + descripcion + "', null, null);");
                //miBD.Insert("INSERT INTO Curso VALUES (null, '" + owner + "', '" + name + "', '" + desc + "', null);");
                try
                {
                    miBD.Insert("INSERT INTO Evento VALUES (null, '" + id_cue + "','" + nombre + "', '" + descripcion + "', null, '" + dateFinal +"');");
                    object[] tupla = miBD.Select("SELECT id_evento FROM Evento where id_owner = " + id_cue + " AND nombre = '" + nombre + "' and descripcion = '" + descripcion + "' ;")[0];
                    int idevento = (int)tupla[0];
                    miBD.Insert("INSERT INTO Cuenta_Evento VALUES (" + id_cue + ", " + idevento + ", null);");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Nombre o Descripción incorrecto");
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCrearEvento));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el nombre del evento";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(169, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introduzca una descripcion del evento";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(169, 215);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(441, 168);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(169, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 406);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Location = new System.Drawing.Point(410, 406);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // fCrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 595);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCrearEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCrearEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;

        private void fCrearEvento_Load(object sender, EventArgs e)
        {

        }
    }
}

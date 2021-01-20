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
    public partial class fEventoMod : Form
    {

        string aux;
        Cuenta user;
        int tipo;
        public fEventoMod(Cuenta u, int t, string evento, string desc)
        {
            InitializeComponent();
            user = u;
            tipo = t;
            aux = evento;
            textBox1.Text = evento;
            textBox2.Text = desc;
        }

        private void bUpd_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String descripcion = textBox2.Text;
            String adicional = textBox3.Text;
            if(!nombre.Equals("") && !descripcion.Equals(""))
            {
                MySQLDB miBD = new MySQLDB();
                miBD.Update("UPDATE Evento SET nombre = '" + nombre
                        + "' WHERE nombre = '" + aux + "';");

                miBD.Update("UPDATE Evento SET descripcion = '" + descripcion
                        + "' WHERE nombre = '" + nombre + "';");

                if (!adicional.Equals(""))
                {
                    miBD.Update("UPDATE Evento SET post = '" + adicional
                        + "' WHERE nombre = '" + nombre + "';");
                }
                Evento eve = new Evento(nombre);

                fEvento ventana = new fEvento(user, tipo, eve);
                ventana.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduzca los datos que faltan");
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEventoMod));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bUpd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(306, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce el nombre del evento";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introduce la nueva descripcion del evento";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(306, 208);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 101);
            this.textBox2.TabIndex = 3;
            // 
            // bUpd
            // 
            this.bUpd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bUpd.Location = new System.Drawing.Point(571, 508);
            this.bUpd.Name = "bUpd";
            this.bUpd.Size = new System.Drawing.Size(75, 23);
            this.bUpd.TabIndex = 8;
            this.bUpd.Text = "Guardar";
            this.bUpd.UseVisualStyleBackColor = true;
            this.bUpd.Click += new System.EventHandler(this.bUpd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Introduzca datos adicionales (Opcional)";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(306, 366);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 101);
            this.textBox3.TabIndex = 10;
            // 
            // fEventoMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 610);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bUpd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEventoMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEventoMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bUpd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;

        private void fEventoMod_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class fEvento : Form
    {
        private Evento seleccionado;
        Cuenta user;
        private Button bValoracion;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        int tipo;
        public fEvento(Cuenta u, int t, Evento eve)
        {
            InitializeComponent();
            seleccionado = eve;
            user = u;
            tipo = t;
            label1.Text = "Evento: " + seleccionado.Nombre;
            label2.Text = "Organizado por: " + seleccionado.IdOwner;
            tDescripcion.Text = seleccionado.Descripcion;
            tAdicional.Text = seleccionado.Adicional;
            textBox1.Text = seleccionado.Valoracion;
            textBox2.Text = seleccionado.Opiniones;


            bMod.Visible = false;
            button2.Visible = false;
            if (tipo == 3 || tipo == 4)
            {
                bMod.Visible = true;
                button2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fEventoMod ventana = new fEventoMod(user, tipo, seleccionado.Nombre, seleccionado.Descripcion);
            this.Visible = false;
            ventana.ShowDialog();
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado.BorrarEvento();
                seleccionado = null;
                MessageBox.Show("Se ha eliminado el evento");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEvento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.tAdicional = new System.Windows.Forms.TextBox();
            this.bMod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bValoracion = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Organizado por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(127, 151);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(535, 103);
            this.tDescripcion.TabIndex = 3;
            // 
            // tAdicional
            // 
            this.tAdicional.Location = new System.Drawing.Point(127, 296);
            this.tAdicional.Multiline = true;
            this.tAdicional.Name = "tAdicional";
            this.tAdicional.ReadOnly = true;
            this.tAdicional.Size = new System.Drawing.Size(535, 111);
            this.tAdicional.TabIndex = 4;
            // 
            // bMod
            // 
            this.bMod.Location = new System.Drawing.Point(127, 453);
            this.bMod.Name = "bMod";
            this.bMod.Size = new System.Drawing.Size(111, 23);
            this.bMod.TabIndex = 5;
            this.bMod.Text = "Modificar Contenido";
            this.bMod.UseVisualStyleBackColor = true;
            this.bMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eliminar Evento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bValoracion
            // 
            this.bValoracion.Location = new System.Drawing.Point(334, 453);
            this.bValoracion.Name = "bValoracion";
            this.bValoracion.Size = new System.Drawing.Size(111, 23);
            this.bValoracion.TabIndex = 7;
            this.bValoracion.Text = "Valorar";
            this.bValoracion.UseVisualStyleBackColor = true;
            this.bValoracion.Click += new System.EventHandler(this.bValoracion_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(786, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(46, 24);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(651, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(65, 24);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(838, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "usuarios";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "por parte de ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Valoración del Curso:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 606);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bValoracion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bMod);
            this.Controls.Add(this.tAdicional);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fEvento_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.TextBox tAdicional;
        private System.Windows.Forms.Button bMod;
        private System.Windows.Forms.Button button2;

        private void fEvento_Load(object sender, EventArgs e)
        {

        }

        private void fEvento_Load_1(object sender, EventArgs e)
        {

        }

        private void bValoracion_Click(object sender, EventArgs e)
        {
            fValoracionEvento ventana = new fValoracionEvento(user, tipo, seleccionado);
            this.Close();
            ventana.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

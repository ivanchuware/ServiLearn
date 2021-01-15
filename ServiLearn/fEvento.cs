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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.tAdicional = new System.Windows.Forms.TextBox();
            this.bMod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bValoracion = new System.Windows.Forms.Button();
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
            // fEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 606);
            this.Controls.Add(this.bValoracion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bMod);
            this.Controls.Add(this.tAdicional);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            fValoracionEvento ventana = new fValoracionEvento(user, seleccionado);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}

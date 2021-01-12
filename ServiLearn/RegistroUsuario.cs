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
    public partial class RegistroUsuario : Form
    {
        SeleccionRegistro sr = null;
        public RegistroUsuario(SeleccionRegistro s)
        {
            InitializeComponent();
            sr = s;
        }

        private void cnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnf_Click(object sender, EventArgs e)
        {
            Alumno c = new Alumno(nUsuario.Text, cUsuario.Text,eUsuario.Text, true);
            MessageBox.Show("Cuenta creada");

            this.Close();
        }

        private void InitializeComponent()
        {
            this.cnl = new System.Windows.Forms.Button();
            this.cnf = new System.Windows.Forms.Button();
            this.cUsuario = new System.Windows.Forms.TextBox();
            this.nUsuario = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.eUsuario = new System.Windows.Forms.TextBox();
            this.em = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cnl
            // 
            this.cnl.Location = new System.Drawing.Point(476, 302);
            this.cnl.Name = "cnl";
            this.cnl.Size = new System.Drawing.Size(75, 23);
            this.cnl.TabIndex = 11;
            this.cnl.Text = "Cancelar";
            this.cnl.UseVisualStyleBackColor = true;
            this.cnl.Click += new System.EventHandler(this.cnl_Click);
            // 
            // cnf
            // 
            this.cnf.Location = new System.Drawing.Point(253, 302);
            this.cnf.Name = "cnf";
            this.cnf.Size = new System.Drawing.Size(75, 23);
            this.cnf.TabIndex = 10;
            this.cnf.Text = "Confirmar";
            this.cnf.UseVisualStyleBackColor = true;
            this.cnf.Click += new System.EventHandler(this.cnf_Click);
            // 
            // cUsuario
            // 
            this.cUsuario.Location = new System.Drawing.Point(386, 177);
            this.cUsuario.Name = "cUsuario";
            this.cUsuario.Size = new System.Drawing.Size(100, 20);
            this.cUsuario.TabIndex = 9;
            // 
            // nUsuario
            // 
            this.nUsuario.Location = new System.Drawing.Point(386, 125);
            this.nUsuario.Name = "nUsuario";
            this.nUsuario.Size = new System.Drawing.Size(100, 20);
            this.nUsuario.TabIndex = 8;
            // 
            // clave
            // 
            this.clave.AutoSize = true;
            this.clave.Location = new System.Drawing.Point(287, 177);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(64, 13);
            this.clave.TabIndex = 7;
            this.clave.Text = "Contraseña:";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Location = new System.Drawing.Point(250, 128);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(101, 13);
            this.nombreUsuario.TabIndex = 6;
            this.nombreUsuario.Text = "Nombre de Usuario:";
            // 
            // eUsuario
            // 
            this.eUsuario.Location = new System.Drawing.Point(386, 222);
            this.eUsuario.Name = "eUsuario";
            this.eUsuario.Size = new System.Drawing.Size(100, 20);
            this.eUsuario.TabIndex = 13;
            // 
            // em
            // 
            this.em.AutoSize = true;
            this.em.Location = new System.Drawing.Point(317, 222);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(34, 13);
            this.em.TabIndex = 12;
            this.em.Text = "email:";
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eUsuario);
            this.Controls.Add(this.em);
            this.Controls.Add(this.cnl);
            this.Controls.Add(this.cnf);
            this.Controls.Add(this.cUsuario);
            this.Controls.Add(this.nUsuario);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.nombreUsuario);
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiLearn - Registro Alumno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistroUsuario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Button cnl;
        private System.Windows.Forms.Button cnf;
        private System.Windows.Forms.TextBox cUsuario;
        private System.Windows.Forms.TextBox nUsuario;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.TextBox eUsuario;
        private System.Windows.Forms.Label em;

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void RegistroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            sr.Show();
        }
    }
}

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
    public partial class RegistroONG : Form
    {
        SeleccionRegistro sr = null;
        public RegistroONG(SeleccionRegistro s)
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
            ONG c = new ONG(nOng.Text, cOng.Text, eOng.Text, tlfnOng.Text, dOng.Text, true);
            MessageBox.Show("Cuenta creada");
            this.Close();
        }

        private void InitializeComponent()
        {
            this.dOng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlfnOng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eOng = new System.Windows.Forms.TextBox();
            this.em = new System.Windows.Forms.Label();
            this.cnl = new System.Windows.Forms.Button();
            this.cnf = new System.Windows.Forms.Button();
            this.cOng = new System.Windows.Forms.TextBox();
            this.nOng = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dOng
            // 
            this.dOng.Location = new System.Drawing.Point(406, 257);
            this.dOng.Name = "dOng";
            this.dOng.Size = new System.Drawing.Size(100, 20);
            this.dOng.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Dirección:";
            // 
            // tlfnOng
            // 
            this.tlfnOng.Location = new System.Drawing.Point(406, 212);
            this.tlfnOng.Name = "tlfnOng";
            this.tlfnOng.Size = new System.Drawing.Size(100, 20);
            this.tlfnOng.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Número de teléfono:";
            // 
            // eOng
            // 
            this.eOng.Location = new System.Drawing.Point(406, 168);
            this.eOng.Name = "eOng";
            this.eOng.Size = new System.Drawing.Size(100, 20);
            this.eOng.TabIndex = 33;
            // 
            // em
            // 
            this.em.AutoSize = true;
            this.em.Location = new System.Drawing.Point(337, 168);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(34, 13);
            this.em.TabIndex = 32;
            this.em.Text = "email:";
            // 
            // cnl
            // 
            this.cnl.Location = new System.Drawing.Point(474, 357);
            this.cnl.Name = "cnl";
            this.cnl.Size = new System.Drawing.Size(75, 23);
            this.cnl.TabIndex = 31;
            this.cnl.Text = "Cancelar";
            this.cnl.UseVisualStyleBackColor = true;
            this.cnl.Click += new System.EventHandler(this.cnl_Click);
            // 
            // cnf
            // 
            this.cnf.Location = new System.Drawing.Point(251, 357);
            this.cnf.Name = "cnf";
            this.cnf.Size = new System.Drawing.Size(75, 23);
            this.cnf.TabIndex = 30;
            this.cnf.Text = "Confirmar";
            this.cnf.UseVisualStyleBackColor = true;
            this.cnf.Click += new System.EventHandler(this.cnf_Click);
            // 
            // cOng
            // 
            this.cOng.Location = new System.Drawing.Point(406, 123);
            this.cOng.Name = "cOng";
            this.cOng.Size = new System.Drawing.Size(100, 20);
            this.cOng.TabIndex = 29;
            // 
            // nOng
            // 
            this.nOng.Location = new System.Drawing.Point(406, 71);
            this.nOng.Name = "nOng";
            this.nOng.Size = new System.Drawing.Size(100, 20);
            this.nOng.TabIndex = 28;
            // 
            // clave
            // 
            this.clave.AutoSize = true;
            this.clave.Location = new System.Drawing.Point(307, 123);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(64, 13);
            this.clave.TabIndex = 27;
            this.clave.Text = "Contraseña:";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Location = new System.Drawing.Point(270, 74);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(101, 13);
            this.nombreUsuario.TabIndex = 26;
            this.nombreUsuario.Text = "Nombre de Usuario:";
            // 
            // RegistroONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dOng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlfnOng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eOng);
            this.Controls.Add(this.em);
            this.Controls.Add(this.cnl);
            this.Controls.Add(this.cnf);
            this.Controls.Add(this.cOng);
            this.Controls.Add(this.nOng);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.nombreUsuario);
            this.Name = "RegistroONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiLearn - Registro ONG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistroONG_FormClosed);
            this.Load += new System.EventHandler(this.RegistroONG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.TextBox dOng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tlfnOng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eOng;
        private System.Windows.Forms.Label em;
        private System.Windows.Forms.Button cnl;
        private System.Windows.Forms.Button cnf;
        private System.Windows.Forms.TextBox cOng;
        private System.Windows.Forms.TextBox nOng;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.Label nombreUsuario;

        private void RegistroONG_Load(object sender, EventArgs e)
        {

        }

        private void RegistroONG_FormClosed(object sender, FormClosedEventArgs e)
        {
            sr.Show();
        }
    }
}

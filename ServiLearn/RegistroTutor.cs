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
    public partial class RegistroTutor : Form
    {
        SeleccionRegistro sr = null;
        public RegistroTutor(SeleccionRegistro s)
        {
            InitializeComponent();
            sr = s;
        }

        private void nUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tlfnTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void em_Click(object sender, EventArgs e)
        {

        }

        private void cnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnf_Click(object sender, EventArgs e)
        {
            Docente c = new Docente(nTutor.Text, cTutor.Text, eTutor.Text,dTutor.Text, tlfnTutor.Text, true);
            MessageBox.Show("Cuenta creada");
            this.Close();
        }

        private void cUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void clave_Click(object sender, EventArgs e)
        {

        }

        private void nombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.eTutor = new System.Windows.Forms.TextBox();
            this.em = new System.Windows.Forms.Label();
            this.cnl = new System.Windows.Forms.Button();
            this.cnf = new System.Windows.Forms.Button();
            this.cTutor = new System.Windows.Forms.TextBox();
            this.nTutor = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.dTutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlfnTutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eTutor
            // 
            this.eTutor.Location = new System.Drawing.Point(385, 174);
            this.eTutor.Name = "eTutor";
            this.eTutor.Size = new System.Drawing.Size(100, 20);
            this.eTutor.TabIndex = 21;
            this.eTutor.TextChanged += new System.EventHandler(this.eUsuario_TextChanged);
            // 
            // em
            // 
            this.em.AutoSize = true;
            this.em.Location = new System.Drawing.Point(316, 174);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(34, 13);
            this.em.TabIndex = 20;
            this.em.Text = "email:";
            this.em.Click += new System.EventHandler(this.em_Click);
            // 
            // cnl
            // 
            this.cnl.Location = new System.Drawing.Point(453, 363);
            this.cnl.Name = "cnl";
            this.cnl.Size = new System.Drawing.Size(75, 23);
            this.cnl.TabIndex = 19;
            this.cnl.Text = "Cancelar";
            this.cnl.UseVisualStyleBackColor = true;
            this.cnl.Click += new System.EventHandler(this.cnl_Click);
            // 
            // cnf
            // 
            this.cnf.Location = new System.Drawing.Point(230, 363);
            this.cnf.Name = "cnf";
            this.cnf.Size = new System.Drawing.Size(75, 23);
            this.cnf.TabIndex = 18;
            this.cnf.Text = "Confirmar";
            this.cnf.UseVisualStyleBackColor = true;
            this.cnf.Click += new System.EventHandler(this.cnf_Click);
            // 
            // cTutor
            // 
            this.cTutor.Location = new System.Drawing.Point(385, 129);
            this.cTutor.Name = "cTutor";
            this.cTutor.Size = new System.Drawing.Size(100, 20);
            this.cTutor.TabIndex = 17;
            this.cTutor.TextChanged += new System.EventHandler(this.cUsuario_TextChanged);
            // 
            // nTutor
            // 
            this.nTutor.Location = new System.Drawing.Point(385, 77);
            this.nTutor.Name = "nTutor";
            this.nTutor.Size = new System.Drawing.Size(100, 20);
            this.nTutor.TabIndex = 16;
            this.nTutor.TextChanged += new System.EventHandler(this.nUsuario_TextChanged);
            // 
            // clave
            // 
            this.clave.AutoSize = true;
            this.clave.Location = new System.Drawing.Point(286, 129);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(64, 13);
            this.clave.TabIndex = 15;
            this.clave.Text = "Contraseña:";
            this.clave.Click += new System.EventHandler(this.clave_Click);
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Location = new System.Drawing.Point(249, 80);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(101, 13);
            this.nombreUsuario.TabIndex = 14;
            this.nombreUsuario.Text = "Nombre de Usuario:";
            this.nombreUsuario.Click += new System.EventHandler(this.nombreUsuario_Click);
            // 
            // dTutor
            // 
            this.dTutor.Location = new System.Drawing.Point(385, 263);
            this.dTutor.Name = "dTutor";
            this.dTutor.Size = new System.Drawing.Size(100, 20);
            this.dTutor.TabIndex = 25;
            this.dTutor.TextChanged += new System.EventHandler(this.dTutor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dirección:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tlfnTutor
            // 
            this.tlfnTutor.Location = new System.Drawing.Point(385, 218);
            this.tlfnTutor.Name = "tlfnTutor";
            this.tlfnTutor.Size = new System.Drawing.Size(100, 20);
            this.tlfnTutor.TabIndex = 23;
            this.tlfnTutor.TextChanged += new System.EventHandler(this.tlfnTutor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Número de teléfono:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegistroTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dTutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlfnTutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eTutor);
            this.Controls.Add(this.em);
            this.Controls.Add(this.cnl);
            this.Controls.Add(this.cnf);
            this.Controls.Add(this.cTutor);
            this.Controls.Add(this.nTutor);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.nombreUsuario);
            this.Name = "RegistroTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiLearn - Registro Tutor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistroTutor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.TextBox eTutor;
        private System.Windows.Forms.Label em;
        private System.Windows.Forms.Button cnl;
        private System.Windows.Forms.Button cnf;
        private System.Windows.Forms.TextBox cTutor;
        private System.Windows.Forms.TextBox nTutor;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.TextBox dTutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tlfnTutor;
        private System.Windows.Forms.Label label2;

        private void RegistroTutor_Load(object sender, EventArgs e)
        {

        }

        private void RegistroTutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            sr.Show();
        }
    }
}

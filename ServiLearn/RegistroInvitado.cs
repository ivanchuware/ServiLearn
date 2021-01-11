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
    public partial class RegistroInvitado : Form
    {
        public RegistroInvitado()
        {
            InitializeComponent();
        }

        private void cnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnf_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta c = new Cuenta(nInvitado.Text, cInvitado.Text, true);
                c.InsertarInvitado(c.nombre);
                MessageBox.Show("Cuenta creada");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        private void InitializeComponent()
        {
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.clave = new System.Windows.Forms.Label();
            this.nInvitado = new System.Windows.Forms.TextBox();
            this.cInvitado = new System.Windows.Forms.TextBox();
            this.cnf = new System.Windows.Forms.Button();
            this.cnl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Location = new System.Drawing.Point(214, 141);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(101, 13);
            this.nombreUsuario.TabIndex = 0;
            this.nombreUsuario.Text = "Nombre de Usuario:";
            // 
            // clave
            // 
            this.clave.AutoSize = true;
            this.clave.Location = new System.Drawing.Point(251, 190);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(64, 13);
            this.clave.TabIndex = 1;
            this.clave.Text = "Contraseña:";
            // 
            // nInvitado
            // 
            this.nInvitado.Location = new System.Drawing.Point(350, 138);
            this.nInvitado.Name = "nInvitado";
            this.nInvitado.Size = new System.Drawing.Size(100, 20);
            this.nInvitado.TabIndex = 2;
            // 
            // cInvitado
            // 
            this.cInvitado.Location = new System.Drawing.Point(350, 190);
            this.cInvitado.Name = "cInvitado";
            this.cInvitado.Size = new System.Drawing.Size(100, 20);
            this.cInvitado.TabIndex = 3;
            // 
            // cnf
            // 
            this.cnf.Location = new System.Drawing.Point(217, 315);
            this.cnf.Name = "cnf";
            this.cnf.Size = new System.Drawing.Size(75, 23);
            this.cnf.TabIndex = 4;
            this.cnf.Text = "Confirmar";
            this.cnf.UseVisualStyleBackColor = true;
            this.cnf.Click += new System.EventHandler(this.cnf_Click);
            // 
            // cnl
            // 
            this.cnl.Location = new System.Drawing.Point(440, 315);
            this.cnl.Name = "cnl";
            this.cnl.Size = new System.Drawing.Size(75, 23);
            this.cnl.TabIndex = 5;
            this.cnl.Text = "Cancelar";
            this.cnl.UseVisualStyleBackColor = true;
            this.cnl.Click += new System.EventHandler(this.cnl_Click);
            // 
            // RegistroInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnl);
            this.Controls.Add(this.cnf);
            this.Controls.Add(this.cInvitado);
            this.Controls.Add(this.nInvitado);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.nombreUsuario);
            this.Name = "RegistroInvitado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroInvitado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.TextBox nInvitado;
        private System.Windows.Forms.TextBox cInvitado;
        private System.Windows.Forms.Button cnf;
        private System.Windows.Forms.Button cnl;

        private void RegistroInvitado_Load(object sender, EventArgs e)
        {

        }
    }
}

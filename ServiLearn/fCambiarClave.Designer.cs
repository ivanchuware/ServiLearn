
namespace ServiLearn
{
    partial class fCambiarClave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCambiarClave));
            this.label1 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbNuevaContraseña = new System.Windows.Forms.TextBox();
            this.bCambiarContraseña = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(29, 27);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(208, 20);
            this.tbContraseña.TabIndex = 1;
            this.tbContraseña.Text = "Introduzca tu Contraseña Actual";
            // 
            // tbNuevaContraseña
            // 
            this.tbNuevaContraseña.Location = new System.Drawing.Point(29, 63);
            this.tbNuevaContraseña.Name = "tbNuevaContraseña";
            this.tbNuevaContraseña.Size = new System.Drawing.Size(208, 20);
            this.tbNuevaContraseña.TabIndex = 2;
            this.tbNuevaContraseña.Text = "Introduzca la Nueva Contraseña";
            // 
            // bCambiarContraseña
            // 
            this.bCambiarContraseña.Location = new System.Drawing.Point(29, 107);
            this.bCambiarContraseña.Name = "bCambiarContraseña";
            this.bCambiarContraseña.Size = new System.Drawing.Size(127, 23);
            this.bCambiarContraseña.TabIndex = 3;
            this.bCambiarContraseña.Text = "Cambiar Contraseña";
            this.bCambiarContraseña.UseVisualStyleBackColor = true;
            this.bCambiarContraseña.Click += new System.EventHandler(this.bCambiarContraseña_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(162, 107);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 4;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // fCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 164);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bCambiarContraseña);
            this.Controls.Add(this.tbNuevaContraseña);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCambiarClave";
            this.Text = "fCambiarClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbNuevaContraseña;
        private System.Windows.Forms.Button bCambiarContraseña;
        private System.Windows.Forms.Button bCancelar;
    }
}
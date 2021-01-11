
namespace ServiLearn
{
    partial class fCuenta
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
            this.lNombre = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.bCambiarNombre = new System.Windows.Forms.Button();
            this.bCambiarContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(33, 43);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(92, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "NombreDeCuenta";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(33, 80);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(76, 13);
            this.lTipo.TabIndex = 1;
            this.lTipo.Text = "TipoDeCuenta";
            // 
            // bCambiarNombre
            // 
            this.bCambiarNombre.Location = new System.Drawing.Point(36, 169);
            this.bCambiarNombre.Name = "bCambiarNombre";
            this.bCambiarNombre.Size = new System.Drawing.Size(118, 23);
            this.bCambiarNombre.TabIndex = 2;
            this.bCambiarNombre.Text = "Cambiar Nombre";
            this.bCambiarNombre.UseVisualStyleBackColor = true;
            this.bCambiarNombre.Click += new System.EventHandler(this.bCambiarNombre_Click);
            // 
            // bCambiarContraseña
            // 
            this.bCambiarContraseña.Location = new System.Drawing.Point(36, 209);
            this.bCambiarContraseña.Name = "bCambiarContraseña";
            this.bCambiarContraseña.Size = new System.Drawing.Size(118, 23);
            this.bCambiarContraseña.TabIndex = 3;
            this.bCambiarContraseña.Text = "Cambiar Contraseña";
            this.bCambiarContraseña.UseVisualStyleBackColor = true;
            this.bCambiarContraseña.Click += new System.EventHandler(this.bCambiarContraseña_Click);
            // 
            // fCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.bCambiarContraseña);
            this.Controls.Add(this.bCambiarNombre);
            this.Controls.Add(this.lTipo);
            this.Controls.Add(this.lNombre);
            this.Name = "fCuenta";
            this.Text = "fCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.Button bCambiarNombre;
        private System.Windows.Forms.Button bCambiarContraseña;
    }
}
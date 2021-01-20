
namespace ServiLearn
{
    partial class fCambiarNombre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCambiarNombre));
            this.lNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.bNombre = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(33, 36);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(80, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre Actual:";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Location = new System.Drawing.Point(36, 65);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(196, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // bNombre
            // 
            this.bNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bNombre.Location = new System.Drawing.Point(36, 126);
            this.bNombre.Name = "bNombre";
            this.bNombre.Size = new System.Drawing.Size(103, 23);
            this.bNombre.TabIndex = 2;
            this.bNombre.Text = "Cambiar Nombre";
            this.bNombre.UseVisualStyleBackColor = true;
            this.bNombre.Click += new System.EventHandler(this.bNombre_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bCancelar.Location = new System.Drawing.Point(145, 126);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(87, 23);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbContraseña.Location = new System.Drawing.Point(36, 100);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(196, 20);
            this.tbContraseña.TabIndex = 4;
            this.tbContraseña.Text = "Introduzca tu Contraseña";
            // 
            // fCambiarNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 177);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCambiarNombre";
            this.Text = "ServiLearn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button bNombre;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox tbContraseña;
    }
}
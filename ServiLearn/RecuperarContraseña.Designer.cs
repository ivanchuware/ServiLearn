
namespace ServiLearn
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.bRecuperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Location = new System.Drawing.Point(71, 73);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(236, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // lEmail
            // 
            this.lEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(68, 48);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(99, 13);
            this.lEmail.TabIndex = 1;
            this.lEmail.Text = "Introduzca su Email";
            // 
            // bRecuperar
            // 
            this.bRecuperar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRecuperar.Location = new System.Drawing.Point(124, 154);
            this.bRecuperar.Name = "bRecuperar";
            this.bRecuperar.Size = new System.Drawing.Size(137, 23);
            this.bRecuperar.TabIndex = 2;
            this.bRecuperar.Text = "Recuperar Contraseña";
            this.bRecuperar.UseVisualStyleBackColor = true;
            this.bRecuperar.Click += new System.EventHandler(this.bRecuperar_Click);
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 203);
            this.Controls.Add(this.bRecuperar);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.tbEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuperarContraseña";
            this.Text = "RecuperarContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Button bRecuperar;
    }
}
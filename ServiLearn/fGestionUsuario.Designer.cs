
namespace ServiLearn
{
    partial class fGestionUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.bEliminarUsuario = new System.Windows.Forms.Button();
            this.tbBuscadorUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.Location = new System.Drawing.Point(94, 119);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(283, 121);
            this.lbUsuarios.TabIndex = 1;
            this.lbUsuarios.SelectedIndexChanged += new System.EventHandler(this.lbUsuarios_SelectedIndexChanged);
            // 
            // bEliminarUsuario
            // 
            this.bEliminarUsuario.Location = new System.Drawing.Point(460, 217);
            this.bEliminarUsuario.Name = "bEliminarUsuario";
            this.bEliminarUsuario.Size = new System.Drawing.Size(100, 23);
            this.bEliminarUsuario.TabIndex = 2;
            this.bEliminarUsuario.Text = "Eliminar Usuario";
            this.bEliminarUsuario.UseVisualStyleBackColor = true;
            this.bEliminarUsuario.Click += new System.EventHandler(this.bEliminarUsuario_Click);
            // 
            // tbBuscadorUsuario
            // 
            this.tbBuscadorUsuario.Location = new System.Drawing.Point(460, 119);
            this.tbBuscadorUsuario.Name = "tbBuscadorUsuario";
            this.tbBuscadorUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbBuscadorUsuario.TabIndex = 3;
            this.tbBuscadorUsuario.TextChanged += new System.EventHandler(this.tbBuscadorUsuario_TextChanged);
            // 
            // fGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 492);
            this.Controls.Add(this.tbBuscadorUsuario);
            this.Controls.Add(this.bEliminarUsuario);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.label1);
            this.Name = "fGestionUsuario";
            this.Text = "fGestionUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.Button bEliminarUsuario;
        private System.Windows.Forms.TextBox tbBuscadorUsuario;
    }
}
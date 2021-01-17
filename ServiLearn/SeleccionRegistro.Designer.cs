
namespace ServiLearn
{
    partial class SeleccionRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.invitado_bt = new System.Windows.Forms.Button();
            this.usuario_bt = new System.Windows.Forms.Button();
            this.tutor_bt = new System.Windows.Forms.Button();
            this.ong_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de cuenta a crear";
            // 
            // invitado_bt
            // 
            this.invitado_bt.Location = new System.Drawing.Point(347, 140);
            this.invitado_bt.Name = "invitado_bt";
            this.invitado_bt.Size = new System.Drawing.Size(75, 23);
            this.invitado_bt.TabIndex = 1;
            this.invitado_bt.Text = "Invitado";
            this.invitado_bt.UseVisualStyleBackColor = true;
            this.invitado_bt.Click += new System.EventHandler(this.invitado_bt_Click);
            // 
            // usuario_bt
            // 
            this.usuario_bt.Location = new System.Drawing.Point(347, 195);
            this.usuario_bt.Name = "usuario_bt";
            this.usuario_bt.Size = new System.Drawing.Size(75, 23);
            this.usuario_bt.TabIndex = 2;
            this.usuario_bt.Text = "Usuario";
            this.usuario_bt.UseVisualStyleBackColor = true;
            this.usuario_bt.Click += new System.EventHandler(this.usuario_bt_Click);
            // 
            // tutor_bt
            // 
            this.tutor_bt.Location = new System.Drawing.Point(347, 243);
            this.tutor_bt.Name = "tutor_bt";
            this.tutor_bt.Size = new System.Drawing.Size(75, 23);
            this.tutor_bt.TabIndex = 3;
            this.tutor_bt.Text = "Tutor";
            this.tutor_bt.UseVisualStyleBackColor = true;
            this.tutor_bt.Click += new System.EventHandler(this.tutor_bt_Click);
            // 
            // ong_bt
            // 
            this.ong_bt.Location = new System.Drawing.Point(347, 296);
            this.ong_bt.Name = "ong_bt";
            this.ong_bt.Size = new System.Drawing.Size(75, 23);
            this.ong_bt.TabIndex = 4;
            this.ong_bt.Text = "ONG";
            this.ong_bt.UseVisualStyleBackColor = true;
            this.ong_bt.Click += new System.EventHandler(this.ong_bt_Click);
            // 
            // SeleccionRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ong_bt);
            this.Controls.Add(this.tutor_bt);
            this.Controls.Add(this.usuario_bt);
            this.Controls.Add(this.invitado_bt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeleccionRegistro";
            this.Text = "SeleccionRegistro";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
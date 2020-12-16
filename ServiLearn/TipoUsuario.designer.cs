
namespace ServiLearn
{
    partial class TipoUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.LinkLabel();
            this.buttonAlu = new System.Windows.Forms.Button();
            this.buttonONG = new System.Windows.Forms.Button();
            this.buttonTut = new System.Windows.Forms.Button();
            this.buttonInv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige el tipo de usuario que quieres crear:";
            // 
            // atras
            // 
            this.atras.AutoSize = true;
            this.atras.Location = new System.Drawing.Point(49, 31);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(31, 13);
            this.atras.TabIndex = 4;
            this.atras.TabStop = true;
            this.atras.Text = "Atrás";
            this.atras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonAlu
            // 
            this.buttonAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonAlu.Location = new System.Drawing.Point(482, 165);
            this.buttonAlu.Name = "buttonAlu";
            this.buttonAlu.Size = new System.Drawing.Size(320, 160);
            this.buttonAlu.TabIndex = 7;
            this.buttonAlu.Text = "Alumno";
            this.buttonAlu.UseVisualStyleBackColor = true;
            this.buttonAlu.Click += new System.EventHandler(this.buttonAlu_Click);
            // 
            // buttonONG
            // 
            this.buttonONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonONG.Location = new System.Drawing.Point(482, 377);
            this.buttonONG.Name = "buttonONG";
            this.buttonONG.Size = new System.Drawing.Size(320, 160);
            this.buttonONG.TabIndex = 8;
            this.buttonONG.Text = "ONG / Administración Pública";
            this.buttonONG.UseVisualStyleBackColor = true;
            this.buttonONG.Click += new System.EventHandler(this.buttonONG_Click);
            // 
            // buttonTut
            // 
            this.buttonTut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonTut.Location = new System.Drawing.Point(102, 377);
            this.buttonTut.Name = "buttonTut";
            this.buttonTut.Size = new System.Drawing.Size(320, 160);
            this.buttonTut.TabIndex = 9;
            this.buttonTut.Text = "Tutor";
            this.buttonTut.UseVisualStyleBackColor = true;
            this.buttonTut.Click += new System.EventHandler(this.buttonTut_Click);
            // 
            // buttonInv
            // 
            this.buttonInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonInv.Location = new System.Drawing.Point(102, 165);
            this.buttonInv.Name = "buttonInv";
            this.buttonInv.Size = new System.Drawing.Size(320, 160);
            this.buttonInv.TabIndex = 10;
            this.buttonInv.Text = "Cuenta de Invitado";
            this.buttonInv.UseVisualStyleBackColor = true;
            this.buttonInv.Click += new System.EventHandler(this.buttonInv_Click);
            // 
            // TipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 606);
            this.Controls.Add(this.buttonInv);
            this.Controls.Add(this.buttonTut);
            this.Controls.Add(this.buttonONG);
            this.Controls.Add(this.buttonAlu);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.label1);
            this.Name = "TipoUsuario";
            this.Text = "ServiLearn - Elección Tipo Usuario";
            this.Load += new System.EventHandler(this.TipoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel atras;
        private System.Windows.Forms.Button buttonAlu;
        private System.Windows.Forms.Button buttonONG;
        private System.Windows.Forms.Button buttonTut;
        private System.Windows.Forms.Button buttonInv;
    }
}


    
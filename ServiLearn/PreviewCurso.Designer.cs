
namespace ServiLearn
{
    partial class PreviewCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewCurso));
            this.lCurso = new System.Windows.Forms.Label();
            this.lImp = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.bInscribirse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCurso
            // 
            this.lCurso.AutoSize = true;
            this.lCurso.Location = new System.Drawing.Point(41, 30);
            this.lCurso.Name = "lCurso";
            this.lCurso.Size = new System.Drawing.Size(40, 13);
            this.lCurso.TabIndex = 0;
            this.lCurso.Text = "Curso: ";
            // 
            // lImp
            // 
            this.lImp.AutoSize = true;
            this.lImp.Location = new System.Drawing.Point(41, 72);
            this.lImp.Name = "lImp";
            this.lImp.Size = new System.Drawing.Size(74, 13);
            this.lImp.TabIndex = 1;
            this.lImp.Text = "Impartido por: ";
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Location = new System.Drawing.Point(41, 119);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(66, 13);
            this.lDesc.TabIndex = 2;
            this.lDesc.Text = "Descripción:";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(44, 161);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ReadOnly = true;
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(512, 190);
            this.tbDesc.TabIndex = 3;
            // 
            // bInscribirse
            // 
            this.bInscribirse.Location = new System.Drawing.Point(243, 357);
            this.bInscribirse.Name = "bInscribirse";
            this.bInscribirse.Size = new System.Drawing.Size(75, 23);
            this.bInscribirse.TabIndex = 4;
            this.bInscribirse.Text = "Inscribirse";
            this.bInscribirse.UseVisualStyleBackColor = true;
            this.bInscribirse.Click += new System.EventHandler(this.bInscribirse_Click);
            // 
            // PreviewCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.bInscribirse);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lImp);
            this.Controls.Add(this.lCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreviewCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreviewCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCurso;
        private System.Windows.Forms.Label lImp;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Button bInscribirse;
    }
}
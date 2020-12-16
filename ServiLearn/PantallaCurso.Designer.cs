
namespace ServiLearn
{
    partial class PantallaCurso
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
            this.lCurso = new System.Windows.Forms.Label();
            this.lProfesores = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tvContenido = new System.Windows.Forms.TreeView();
            this.bModCurso = new System.Windows.Forms.Button();
            this.bEliCurso = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCurso
            // 
            this.lCurso.AutoSize = true;
            this.lCurso.Location = new System.Drawing.Point(53, 28);
            this.lCurso.Name = "lCurso";
            this.lCurso.Size = new System.Drawing.Size(37, 13);
            this.lCurso.TabIndex = 0;
            this.lCurso.Text = "Curso:";
            this.lCurso.Click += new System.EventHandler(this.label1_Click);
            // 
            // lProfesores
            // 
            this.lProfesores.AutoSize = true;
            this.lProfesores.Location = new System.Drawing.Point(53, 67);
            this.lProfesores.Name = "lProfesores";
            this.lProfesores.Size = new System.Drawing.Size(71, 13);
            this.lProfesores.TabIndex = 1;
            this.lProfesores.Text = "Impartido por:";
            this.lProfesores.Click += new System.EventHandler(this.lProfesores_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(636, 105);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Descripcion";
            // 
            // tvContenido
            // 
            this.tvContenido.Location = new System.Drawing.Point(56, 229);
            this.tvContenido.Name = "tvContenido";
            this.tvContenido.Size = new System.Drawing.Size(636, 180);
            this.tvContenido.TabIndex = 3;
            // 
            // bModCurso
            // 
            this.bModCurso.Location = new System.Drawing.Point(56, 415);
            this.bModCurso.Name = "bModCurso";
            this.bModCurso.Size = new System.Drawing.Size(105, 23);
            this.bModCurso.TabIndex = 4;
            this.bModCurso.Text = "Modificar Curso";
            this.bModCurso.UseVisualStyleBackColor = true;
            // 
            // bEliCurso
            // 
            this.bEliCurso.Location = new System.Drawing.Point(386, 415);
            this.bEliCurso.Name = "bEliCurso";
            this.bEliCurso.Size = new System.Drawing.Size(110, 23);
            this.bEliCurso.TabIndex = 5;
            this.bEliCurso.Text = "Eliminar Curso";
            this.bEliCurso.UseVisualStyleBackColor = true;
            this.bEliCurso.Click += new System.EventHandler(this.bEliCurso_Click);
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(534, 415);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(158, 23);
            this.bVolver.TabIndex = 6;
            this.bVolver.Text = "Volver a la lista de cursos";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // PantallaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bEliCurso);
            this.Controls.Add(this.bModCurso);
            this.Controls.Add(this.tvContenido);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lProfesores);
            this.Controls.Add(this.lCurso);
            this.Name = "PantallaCurso";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCurso;
        private System.Windows.Forms.Label lProfesores;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView tvContenido;
        private System.Windows.Forms.Button bModCurso;
        private System.Windows.Forms.Button bEliCurso;
        private System.Windows.Forms.Button bVolver;
    }
}
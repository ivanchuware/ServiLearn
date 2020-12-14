
namespace ServiLearn
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.bModContenido = new System.Windows.Forms.Button();
            this.bEliContenido = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCurso
            // 
            this.lCurso.AutoSize = true;
            this.lCurso.Location = new System.Drawing.Point(51, 9);
            this.lCurso.Name = "lCurso";
            this.lCurso.Size = new System.Drawing.Size(40, 13);
            this.lCurso.TabIndex = 0;
            this.lCurso.Text = "Curso: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Impartido por:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(54, 59);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(518, 74);
            this.tbDescripcion.TabIndex = 4;
            this.tbDescripcion.Text = "Descripción";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(54, 178);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(518, 257);
            this.treeView1.TabIndex = 5;
            // 
            // bModContenido
            // 
            this.bModContenido.Location = new System.Drawing.Point(54, 490);
            this.bModContenido.Name = "bModContenido";
            this.bModContenido.Size = new System.Drawing.Size(116, 23);
            this.bModContenido.TabIndex = 6;
            this.bModContenido.Text = "Modificar Contenido";
            this.bModContenido.UseVisualStyleBackColor = true;
            // 
            // bEliContenido
            // 
            this.bEliContenido.Location = new System.Drawing.Point(279, 490);
            this.bEliContenido.Name = "bEliContenido";
            this.bEliContenido.Size = new System.Drawing.Size(116, 23);
            this.bEliContenido.TabIndex = 7;
            this.bEliContenido.Text = "Eliminar Contenido";
            this.bEliContenido.UseVisualStyleBackColor = true;
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(415, 490);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(157, 23);
            this.bVolver.TabIndex = 8;
            this.bVolver.Text = "Volver a la lista de cursos";
            this.bVolver.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 525);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bEliContenido);
            this.Controls.Add(this.bModContenido);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lCurso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button bModContenido;
        private System.Windows.Forms.Button bEliContenido;
        private System.Windows.Forms.Button bVolver;
    }
}
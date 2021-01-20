
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCurso));
            this.lCurso = new System.Windows.Forms.Label();
            this.lProfesores = new System.Windows.Forms.Label();
            this.bModCurso = new System.Windows.Forms.Button();
            this.bEliCurso = new System.Windows.Forms.Button();
            this.tvCont = new System.Windows.Forms.TextBox();
            this.tvAdic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsuariosInscritos = new System.Windows.Forms.ListBox();
            this.bExpulsar = new System.Windows.Forms.Button();
            this.tbBuscarUsuario = new System.Windows.Forms.TextBox();
            this.bValorar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lCurso
            // 
            this.lCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCurso.AutoSize = true;
            this.lCurso.Location = new System.Drawing.Point(53, 28);
            this.lCurso.Name = "lCurso";
            this.lCurso.Size = new System.Drawing.Size(37, 13);
            this.lCurso.TabIndex = 0;
            this.lCurso.Text = "Curso:";
            // 
            // lProfesores
            // 
            this.lProfesores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lProfesores.AutoSize = true;
            this.lProfesores.Location = new System.Drawing.Point(53, 67);
            this.lProfesores.Name = "lProfesores";
            this.lProfesores.Size = new System.Drawing.Size(71, 13);
            this.lProfesores.TabIndex = 1;
            this.lProfesores.Text = "Impartido por:";
            // 
            // bModCurso
            // 
            this.bModCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bModCurso.Location = new System.Drawing.Point(56, 415);
            this.bModCurso.Name = "bModCurso";
            this.bModCurso.Size = new System.Drawing.Size(105, 23);
            this.bModCurso.TabIndex = 4;
            this.bModCurso.Text = "Modificar Curso";
            this.bModCurso.UseVisualStyleBackColor = true;
            this.bModCurso.Click += new System.EventHandler(this.bModCurso_Click);
            // 
            // bEliCurso
            // 
            this.bEliCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bEliCurso.Location = new System.Drawing.Point(373, 415);
            this.bEliCurso.Name = "bEliCurso";
            this.bEliCurso.Size = new System.Drawing.Size(110, 23);
            this.bEliCurso.TabIndex = 5;
            this.bEliCurso.Text = "Eliminar Curso";
            this.bEliCurso.UseVisualStyleBackColor = true;
            this.bEliCurso.Click += new System.EventHandler(this.bEliCurso_Click);
            // 
            // tvCont
            // 
            this.tvCont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tvCont.Location = new System.Drawing.Point(56, 134);
            this.tvCont.Multiline = true;
            this.tvCont.Name = "tvCont";
            this.tvCont.ReadOnly = true;
            this.tvCont.Size = new System.Drawing.Size(427, 70);
            this.tvCont.TabIndex = 6;
            // 
            // tvAdic
            // 
            this.tvAdic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tvAdic.Location = new System.Drawing.Point(56, 243);
            this.tvAdic.Multiline = true;
            this.tvAdic.Name = "tvAdic";
            this.tvAdic.ReadOnly = true;
            this.tvAdic.Size = new System.Drawing.Size(427, 141);
            this.tvAdic.TabIndex = 7;
            this.tvAdic.TextChanged += new System.EventHandler(this.tvAdic_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Detalles adicionales:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista de usuarios";
            // 
            // lbUsuariosInscritos
            // 
            this.lbUsuariosInscritos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsuariosInscritos.FormattingEnabled = true;
            this.lbUsuariosInscritos.Location = new System.Drawing.Point(564, 134);
            this.lbUsuariosInscritos.Name = "lbUsuariosInscritos";
            this.lbUsuariosInscritos.Size = new System.Drawing.Size(140, 199);
            this.lbUsuariosInscritos.TabIndex = 11;
            this.lbUsuariosInscritos.SelectedIndexChanged += new System.EventHandler(this.lbUsuariosInscritos_SelectedIndexChanged);
            // 
            // bExpulsar
            // 
            this.bExpulsar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bExpulsar.Location = new System.Drawing.Point(564, 415);
            this.bExpulsar.Name = "bExpulsar";
            this.bExpulsar.Size = new System.Drawing.Size(75, 23);
            this.bExpulsar.TabIndex = 12;
            this.bExpulsar.Text = "Expulsar Usuario";
            this.bExpulsar.UseVisualStyleBackColor = true;
            this.bExpulsar.Click += new System.EventHandler(this.bExpulsar_Click);
            // 
            // tbBuscarUsuario
            // 
            this.tbBuscarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscarUsuario.Location = new System.Drawing.Point(564, 364);
            this.tbBuscarUsuario.Name = "tbBuscarUsuario";
            this.tbBuscarUsuario.Size = new System.Drawing.Size(140, 20);
            this.tbBuscarUsuario.TabIndex = 13;
            this.tbBuscarUsuario.TextChanged += new System.EventHandler(this.tbBuscarUsuario_TextChanged);
            // 
            // bValorar
            // 
            this.bValorar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bValorar.Location = new System.Drawing.Point(222, 415);
            this.bValorar.Name = "bValorar";
            this.bValorar.Size = new System.Drawing.Size(101, 23);
            this.bValorar.TabIndex = 14;
            this.bValorar.Text = "Valorar";
            this.bValorar.UseVisualStyleBackColor = true;
            this.bValorar.Click += new System.EventHandler(this.bValorar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valoración del Curso:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "por parte de ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "usuarios";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(490, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(65, 24);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(625, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(46, 24);
            this.textBox2.TabIndex = 19;
            // 
            // PantallaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bValorar);
            this.Controls.Add(this.tbBuscarUsuario);
            this.Controls.Add(this.bExpulsar);
            this.Controls.Add(this.lbUsuariosInscritos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvCont);
            this.Controls.Add(this.bEliCurso);
            this.Controls.Add(this.bModCurso);
            this.Controls.Add(this.tvAdic);
            this.Controls.Add(this.lProfesores);
            this.Controls.Add(this.lCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servilearn - Curso";
            this.Load += new System.EventHandler(this.PantallaCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCurso;
        private System.Windows.Forms.Label lProfesores;
        private System.Windows.Forms.TextBox tvAdic;
        private System.Windows.Forms.TextBox tvCont;
        private System.Windows.Forms.Button bModCurso;
        private System.Windows.Forms.Button bEliCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbUsuariosInscritos;
        private System.Windows.Forms.Button bExpulsar;
        private System.Windows.Forms.TextBox tbBuscarUsuario;
        private System.Windows.Forms.Button bValorar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
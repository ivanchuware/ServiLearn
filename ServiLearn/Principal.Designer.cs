namespace ServiLearn
{
    partial class Principal
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCursos = new System.Windows.Forms.Label();
            this.labelEventos = new System.Windows.Forms.Label();
            this.tbBuscadorCurso = new System.Windows.Forms.TextBox();
            this.tbBuscadorEvento = new System.Windows.Forms.TextBox();
            this.buttonCrearCurso = new System.Windows.Forms.Button();
            this.buttonCrearEvento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCursos = new System.Windows.Forms.ListBox();
            this.lbEventos = new System.Windows.Forms.ListBox();
            this.refresh = new System.Windows.Forms.Button();
            this.bCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(306, 47);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(195, 39);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "ServiLearn";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCursos
            // 
            this.labelCursos.AutoSize = true;
            this.labelCursos.Location = new System.Drawing.Point(127, 169);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(94, 13);
            this.labelCursos.TabIndex = 1;
            this.labelCursos.Text = "Cursos disponibles";
            this.labelCursos.Click += new System.EventHandler(this.labelCursos_Click);
            // 
            // labelEventos
            // 
            this.labelEventos.AutoSize = true;
            this.labelEventos.Location = new System.Drawing.Point(550, 169);
            this.labelEventos.Name = "labelEventos";
            this.labelEventos.Size = new System.Drawing.Size(101, 13);
            this.labelEventos.TabIndex = 2;
            this.labelEventos.Text = "Eventos disponibles";
            // 
            // tbBuscadorCurso
            // 
            this.tbBuscadorCurso.Location = new System.Drawing.Point(121, 134);
            this.tbBuscadorCurso.Name = "tbBuscadorCurso";
            this.tbBuscadorCurso.Size = new System.Drawing.Size(100, 20);
            this.tbBuscadorCurso.TabIndex = 3;
            this.tbBuscadorCurso.TextChanged += new System.EventHandler(this.tbBuscadorCurso_TextChanged);
            // 
            // tbBuscadorEvento
            // 
            this.tbBuscadorEvento.Location = new System.Drawing.Point(553, 134);
            this.tbBuscadorEvento.Name = "tbBuscadorEvento";
            this.tbBuscadorEvento.Size = new System.Drawing.Size(93, 20);
            this.tbBuscadorEvento.TabIndex = 4;
            this.tbBuscadorEvento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCrearCurso
            // 
            this.buttonCrearCurso.Location = new System.Drawing.Point(79, 426);
            this.buttonCrearCurso.Name = "buttonCrearCurso";
            this.buttonCrearCurso.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearCurso.TabIndex = 7;
            this.buttonCrearCurso.Text = "Crear curso";
            this.buttonCrearCurso.UseVisualStyleBackColor = true;
            this.buttonCrearCurso.Click += new System.EventHandler(this.buttonCrearCurso_Click_1);
            // 
            // buttonCrearEvento
            // 
            this.buttonCrearEvento.Location = new System.Drawing.Point(517, 425);
            this.buttonCrearEvento.Name = "buttonCrearEvento";
            this.buttonCrearEvento.Size = new System.Drawing.Size(84, 23);
            this.buttonCrearEvento.TabIndex = 8;
            this.buttonCrearEvento.Text = "Crear evento";
            this.buttonCrearEvento.UseVisualStyleBackColor = true;
            this.buttonCrearEvento.Click += new System.EventHandler(this.buttonCrearEvento_Click_1);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Tipo de cuenta:";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "¡Bienvenido!";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbCursos
            // 
            this.lbCursos.FormattingEnabled = true;
            this.lbCursos.Location = new System.Drawing.Point(89, 206);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(169, 173);
            this.lbCursos.TabIndex = 10;
            this.lbCursos.SelectedIndexChanged += new System.EventHandler(this.lbCursos_SelectedIndexChanged);
            this.lbCursos.DoubleClick += new System.EventHandler(this.lbCursos_DoubleClick);
            // 
            // lbEventos
            // 
            this.lbEventos.FormattingEnabled = true;
            this.lbEventos.Location = new System.Drawing.Point(517, 206);
            this.lbEventos.Name = "lbEventos";
            this.lbEventos.Size = new System.Drawing.Size(163, 173);
            this.lbEventos.TabIndex = 11;
            this.lbEventos.SelectedIndexChanged += new System.EventHandler(this.lbEventos_SelectedIndexChanged);
            this.lbEventos.DoubleClick += new System.EventHandler(this.lbEventos_DoubleClick);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(183, 425);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 12;
            this.refresh.Text = "Actualizar";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // bCuenta
            // 
            this.bCuenta.Location = new System.Drawing.Point(79, 63);
            this.bCuenta.Name = "bCuenta";
            this.bCuenta.Size = new System.Drawing.Size(75, 23);
            this.bCuenta.TabIndex = 13;
            this.bCuenta.Text = "Mi Cuenta";
            this.bCuenta.UseVisualStyleBackColor = true;
            this.bCuenta.Click += new System.EventHandler(this.bCuenta_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 492);
            this.Controls.Add(this.bCuenta);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.lbEventos);
            this.Controls.Add(this.lbCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCrearEvento);
            this.Controls.Add(this.buttonCrearCurso);
            this.Controls.Add(this.tbBuscadorEvento);
            this.Controls.Add(this.tbBuscadorCurso);
            this.Controls.Add(this.labelEventos);
            this.Controls.Add(this.labelCursos);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiLearn";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCursos;
        private System.Windows.Forms.Label labelEventos;
        private System.Windows.Forms.TextBox tbBuscadorCurso;
        private System.Windows.Forms.TextBox tbBuscadorEvento;
        private System.Windows.Forms.Button buttonCrearCurso;
        private System.Windows.Forms.Button buttonCrearEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCursos;
        private System.Windows.Forms.ListBox lbEventos;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button bCuenta;
    }
}
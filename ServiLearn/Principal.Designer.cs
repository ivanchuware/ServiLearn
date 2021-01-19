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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
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
            this.bGestionUsuarios = new System.Windows.Forms.Button();
            this.btMsgs = new System.Windows.Forms.Button();
            this.lNoticias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calendar1 = new Calendar.NET.Calendar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.labelCursos.Location = new System.Drawing.Point(238, 182);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(94, 13);
            this.labelCursos.TabIndex = 1;
            this.labelCursos.Text = "Cursos disponibles";
            this.labelCursos.Click += new System.EventHandler(this.labelCursos_Click);
            // 
            // labelEventos
            // 
            this.labelEventos.AutoSize = true;
            this.labelEventos.Location = new System.Drawing.Point(400, 182);
            this.labelEventos.Name = "labelEventos";
            this.labelEventos.Size = new System.Drawing.Size(101, 13);
            this.labelEventos.TabIndex = 2;
            this.labelEventos.Text = "Eventos disponibles";
            // 
            // tbBuscadorCurso
            // 
            this.tbBuscadorCurso.Location = new System.Drawing.Point(241, 134);
            this.tbBuscadorCurso.Name = "tbBuscadorCurso";
            this.tbBuscadorCurso.Size = new System.Drawing.Size(100, 20);
            this.tbBuscadorCurso.TabIndex = 3;
            this.tbBuscadorCurso.TextChanged += new System.EventHandler(this.tbBuscadorCurso_TextChanged);
            // 
            // tbBuscadorEvento
            // 
            this.tbBuscadorEvento.Location = new System.Drawing.Point(408, 134);
            this.tbBuscadorEvento.Name = "tbBuscadorEvento";
            this.tbBuscadorEvento.Size = new System.Drawing.Size(93, 20);
            this.tbBuscadorEvento.TabIndex = 4;
            this.tbBuscadorEvento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCrearCurso
            // 
            this.buttonCrearCurso.Location = new System.Drawing.Point(257, 401);
            this.buttonCrearCurso.Name = "buttonCrearCurso";
            this.buttonCrearCurso.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearCurso.TabIndex = 7;
            this.buttonCrearCurso.Text = "Crear curso";
            this.buttonCrearCurso.UseVisualStyleBackColor = true;
            this.buttonCrearCurso.Click += new System.EventHandler(this.buttonCrearCurso_Click_1);
            // 
            // buttonCrearEvento
            // 
            this.buttonCrearEvento.Location = new System.Drawing.Point(417, 401);
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
            this.label1.Location = new System.Drawing.Point(24, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "¡Bienvenido!";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbCursos
            // 
            this.lbCursos.FormattingEnabled = true;
            this.lbCursos.Location = new System.Drawing.Point(198, 208);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(169, 173);
            this.lbCursos.TabIndex = 10;
            this.lbCursos.SelectedIndexChanged += new System.EventHandler(this.lbCursos_SelectedIndexChanged);
            this.lbCursos.DoubleClick += new System.EventHandler(this.lbCursos_DoubleClick);
            // 
            // lbEventos
            // 
            this.lbEventos.FormattingEnabled = true;
            this.lbEventos.Location = new System.Drawing.Point(376, 208);
            this.lbEventos.Name = "lbEventos";
            this.lbEventos.Size = new System.Drawing.Size(163, 173);
            this.lbEventos.TabIndex = 11;
            this.lbEventos.SelectedIndexChanged += new System.EventHandler(this.lbEventos_SelectedIndexChanged);
            this.lbEventos.DoubleClick += new System.EventHandler(this.lbEventos_DoubleClick);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(257, 430);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 12;
            this.refresh.Text = "Actualizar";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // bCuenta
            // 
            this.bCuenta.Location = new System.Drawing.Point(15, 12);
            this.bCuenta.Name = "bCuenta";
            this.bCuenta.Size = new System.Drawing.Size(122, 23);
            this.bCuenta.TabIndex = 13;
            this.bCuenta.Text = "Mi Cuenta";
            this.bCuenta.UseVisualStyleBackColor = true;
            this.bCuenta.Click += new System.EventHandler(this.bCuenta_Click);
            // 
            // bGestionUsuarios
            // 
            this.bGestionUsuarios.Location = new System.Drawing.Point(15, 70);
            this.bGestionUsuarios.Name = "bGestionUsuarios";
            this.bGestionUsuarios.Size = new System.Drawing.Size(122, 23);
            this.bGestionUsuarios.TabIndex = 14;
            this.bGestionUsuarios.Text = "Gestionar Usuarios";
            this.bGestionUsuarios.UseVisualStyleBackColor = true;
            this.bGestionUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btMsgs
            // 
            this.btMsgs.Location = new System.Drawing.Point(15, 41);
            this.btMsgs.Name = "btMsgs";
            this.btMsgs.Size = new System.Drawing.Size(122, 23);
            this.btMsgs.TabIndex = 15;
            this.btMsgs.Text = "Mis mensajes";
            this.btMsgs.UseVisualStyleBackColor = true;
            this.btMsgs.Click += new System.EventHandler(this.btMsgs_Click);
            // 
            // lNoticias
            // 
            this.lNoticias.AutoSize = true;
            this.lNoticias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoticias.Location = new System.Drawing.Point(57, 182);
            this.lNoticias.Name = "lNoticias";
            this.lNoticias.Size = new System.Drawing.Size(84, 24);
            this.lNoticias.TabIndex = 16;
            this.lNoticias.Text = "Noticias";
            this.lNoticias.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titulo";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cuerpo de noticia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 72);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(4, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 56);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.DoubleClick += new System.EventHandler(this.panel2_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cuerpo de noticia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Titulo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(4, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 75);
            this.panel3.TabIndex = 21;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.DoubleClick += new System.EventHandler(this.panel3_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cuerpo de noticia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Titulo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ver todas las noticias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // calendar1
            // 
            this.calendar1.AllowEditingEvents = true;
            this.calendar1.CalendarDate = new System.DateTime(2021, 1, 19, 16, 53, 14, 691);
            this.calendar1.CalendarView = Calendar.NET.CalendarViews.Month;
            this.calendar1.DateHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.calendar1.DayOfWeekFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DaysFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calendar1.DimDisabledEvents = true;
            this.calendar1.HighlightCurrentDay = true;
            this.calendar1.LoadPresetHolidays = false;
            this.calendar1.Location = new System.Drawing.Point(545, 208);
            this.calendar1.Name = "calendar1";
            this.calendar1.ShowArrowControls = true;
            this.calendar1.ShowDashedBorderOnDisabledEvents = true;
            this.calendar1.ShowDateInHeader = true;
            this.calendar1.ShowDisabledEvents = false;
            this.calendar1.ShowEventTooltips = true;
            this.calendar1.ShowTodayButton = true;
            this.calendar1.Size = new System.Drawing.Size(266, 245);
            this.calendar1.TabIndex = 23;
            this.calendar1.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calendar1.Load += new System.EventHandler(this.calendar1_Load);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 492);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lNoticias);
            this.Controls.Add(this.btMsgs);
            this.Controls.Add(this.bGestionUsuarios);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiLearn";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button bGestionUsuarios;
        private System.Windows.Forms.Button btMsgs;
        private System.Windows.Forms.Label lNoticias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private Calendar.NET.Calendar calendar1;
    }
}
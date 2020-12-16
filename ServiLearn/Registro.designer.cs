
namespace ServiLearn
{
    partial class Registro
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContr = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContr = new System.Windows.Forms.Label();
            this.labelInvitado = new System.Windows.Forms.Label();
            this.labelONG = new System.Windows.Forms.Label();
            this.labelTutor = new System.Windows.Forms.Label();
            this.labelAlumno = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.errorUsuario = new System.Windows.Forms.Label();
            this.errorContr = new System.Windows.Forms.Label();
            this.errorCorreo = new System.Windows.Forms.Label();
            this.errorTelefono = new System.Windows.Forms.Label();
            this.errorDireccion = new System.Windows.Forms.Label();
            this.errorContrCorta = new System.Windows.Forms.Label();
            this.errorCorreoFormato = new System.Windows.Forms.Label();
            this.errorUsuarioExiste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Completa los datos para crear tu cuenta";
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
            this.atras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAtras_LinkClicked);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonAceptar.Location = new System.Drawing.Point(364, 491);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(171, 49);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(479, 147);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(134, 20);
            this.textBoxUsuario.TabIndex = 9;
            // 
            // textBoxContr
            // 
            this.textBoxContr.Location = new System.Drawing.Point(479, 206);
            this.textBoxContr.Name = "textBoxContr";
            this.textBoxContr.Size = new System.Drawing.Size(134, 20);
            this.textBoxContr.TabIndex = 10;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(250, 142);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(197, 25);
            this.labelUsuario.TabIndex = 11;
            this.labelUsuario.Text = "Nombre de Usuario";
            // 
            // labelContr
            // 
            this.labelContr.AutoSize = true;
            this.labelContr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr.Location = new System.Drawing.Point(290, 201);
            this.labelContr.Name = "labelContr";
            this.labelContr.Size = new System.Drawing.Size(123, 25);
            this.labelContr.TabIndex = 12;
            this.labelContr.Text = "Contraseña";
            // 
            // labelInvitado
            // 
            this.labelInvitado.AutoSize = true;
            this.labelInvitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvitado.Location = new System.Drawing.Point(561, 60);
            this.labelInvitado.Name = "labelInvitado";
            this.labelInvitado.Size = new System.Drawing.Size(117, 25);
            this.labelInvitado.TabIndex = 13;
            this.labelInvitado.Text = "de Invitado";
            // 
            // labelONG
            // 
            this.labelONG.AutoSize = true;
            this.labelONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelONG.Location = new System.Drawing.Point(561, 60);
            this.labelONG.Name = "labelONG";
            this.labelONG.Size = new System.Drawing.Size(233, 25);
            this.labelONG.TabIndex = 14;
            this.labelONG.Text = "de ONG / Adm. Pública";
            // 
            // labelTutor
            // 
            this.labelTutor.AutoSize = true;
            this.labelTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutor.Location = new System.Drawing.Point(561, 60);
            this.labelTutor.Name = "labelTutor";
            this.labelTutor.Size = new System.Drawing.Size(92, 25);
            this.labelTutor.TabIndex = 15;
            this.labelTutor.Text = "de Tutor";
            // 
            // labelAlumno
            // 
            this.labelAlumno.AutoSize = true;
            this.labelAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumno.Location = new System.Drawing.Point(561, 60);
            this.labelAlumno.Name = "labelAlumno";
            this.labelAlumno.Size = new System.Drawing.Size(114, 25);
            this.labelAlumno.TabIndex = 16;
            this.labelAlumno.Text = "de Alumno";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(479, 266);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(134, 20);
            this.textBoxCorreo.TabIndex = 17;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(479, 328);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(134, 20);
            this.textBoxTelefono.TabIndex = 18;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(479, 390);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(134, 20);
            this.textBoxDireccion.TabIndex = 19;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(296, 385);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(102, 25);
            this.labelDireccion.TabIndex = 20;
            this.labelDireccion.Text = "Dirección";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(302, 323);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(96, 25);
            this.labelTelefono.TabIndex = 21;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(257, 261);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(190, 25);
            this.labelCorreo.TabIndex = 22;
            this.labelCorreo.Text = "Correo Electrónico";
            // 
            // errorUsuario
            // 
            this.errorUsuario.AutoSize = true;
            this.errorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.errorUsuario.ForeColor = System.Drawing.Color.Red;
            this.errorUsuario.Location = new System.Drawing.Point(476, 131);
            this.errorUsuario.Name = "errorUsuario";
            this.errorUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorUsuario.Size = new System.Drawing.Size(142, 13);
            this.errorUsuario.TabIndex = 24;
            this.errorUsuario.Text = "Nombre de Usuario no válido";
            // 
            // errorContr
            // 
            this.errorContr.AutoSize = true;
            this.errorContr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.errorContr.ForeColor = System.Drawing.Color.Red;
            this.errorContr.Location = new System.Drawing.Point(490, 190);
            this.errorContr.Name = "errorContr";
            this.errorContr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorContr.Size = new System.Drawing.Size(107, 13);
            this.errorContr.TabIndex = 25;
            this.errorContr.Text = "Contraseña no válida";
            // 
            // errorCorreo
            // 
            this.errorCorreo.AutoSize = true;
            this.errorCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.errorCorreo.ForeColor = System.Drawing.Color.Red;
            this.errorCorreo.Location = new System.Drawing.Point(476, 250);
            this.errorCorreo.Name = "errorCorreo";
            this.errorCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorCorreo.Size = new System.Drawing.Size(138, 13);
            this.errorCorreo.TabIndex = 26;
            this.errorCorreo.Text = "Correo Electrónico no válido";
            // 
            // errorTelefono
            // 
            this.errorTelefono.AutoSize = true;
            this.errorTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.errorTelefono.ForeColor = System.Drawing.Color.Red;
            this.errorTelefono.Location = new System.Drawing.Point(471, 312);
            this.errorTelefono.Name = "errorTelefono";
            this.errorTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorTelefono.Size = new System.Drawing.Size(147, 13);
            this.errorTelefono.TabIndex = 27;
            this.errorTelefono.Text = "Número de Teléfono no válido";
            // 
            // errorDireccion
            // 
            this.errorDireccion.AutoSize = true;
            this.errorDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.errorDireccion.ForeColor = System.Drawing.Color.Red;
            this.errorDireccion.Location = new System.Drawing.Point(501, 374);
            this.errorDireccion.Name = "errorDireccion";
            this.errorDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorDireccion.Size = new System.Drawing.Size(87, 13);
            this.errorDireccion.TabIndex = 28;
            this.errorDireccion.Text = "Falta la Dirección";
            // 
            // errorContrCorta
            // 
            this.errorContrCorta.AutoSize = true;
            this.errorContrCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.errorContrCorta.ForeColor = System.Drawing.Color.Red;
            this.errorContrCorta.Location = new System.Drawing.Point(619, 210);
            this.errorContrCorta.Name = "errorContrCorta";
            this.errorContrCorta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorContrCorta.Size = new System.Drawing.Size(238, 13);
            this.errorContrCorta.TabIndex = 29;
            this.errorContrCorta.Text = "La contraseña debe ser de al menos 6 caracteres";
            // 
            // errorCorreoFormato
            // 
            this.errorCorreoFormato.AutoSize = true;
            this.errorCorreoFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.errorCorreoFormato.ForeColor = System.Drawing.Color.Red;
            this.errorCorreoFormato.Location = new System.Drawing.Point(619, 270);
            this.errorCorreoFormato.Name = "errorCorreoFormato";
            this.errorCorreoFormato.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorCorreoFormato.Size = new System.Drawing.Size(223, 13);
            this.errorCorreoFormato.TabIndex = 30;
            this.errorCorreoFormato.Text = "El correo debe ser de la forma ____@____.__";
            // 
            // errorUsuarioExiste
            // 
            this.errorUsuarioExiste.AutoSize = true;
            this.errorUsuarioExiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.errorUsuarioExiste.ForeColor = System.Drawing.Color.Red;
            this.errorUsuarioExiste.Location = new System.Drawing.Point(619, 151);
            this.errorUsuarioExiste.Name = "errorUsuarioExiste";
            this.errorUsuarioExiste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorUsuarioExiste.Size = new System.Drawing.Size(201, 13);
            this.errorUsuarioExiste.TabIndex = 31;
            this.errorUsuarioExiste.Text = "El Usuario ya existe, introduce uno nuevo";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 606);
            this.Controls.Add(this.errorUsuarioExiste);
            this.Controls.Add(this.errorCorreoFormato);
            this.Controls.Add(this.errorContrCorta);
            this.Controls.Add(this.errorDireccion);
            this.Controls.Add(this.errorTelefono);
            this.Controls.Add(this.errorCorreo);
            this.Controls.Add(this.errorContr);
            this.Controls.Add(this.errorUsuario);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.labelAlumno);
            this.Controls.Add(this.labelTutor);
            this.Controls.Add(this.labelONG);
            this.Controls.Add(this.labelInvitado);
            this.Controls.Add(this.labelContr);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxContr);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "ServiLearn - Registro de Cuentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel atras;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContr;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContr;
        private System.Windows.Forms.Label labelInvitado;
        private System.Windows.Forms.Label labelONG;
        private System.Windows.Forms.Label labelTutor;
        private System.Windows.Forms.Label labelAlumno;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label errorUsuario;
        private System.Windows.Forms.Label errorContr;
        private System.Windows.Forms.Label errorCorreo;
        private System.Windows.Forms.Label errorTelefono;
        private System.Windows.Forms.Label errorDireccion;
        private System.Windows.Forms.Label errorContrCorta;
        private System.Windows.Forms.Label errorCorreoFormato;
        private System.Windows.Forms.Label errorUsuarioExiste;
    }


}



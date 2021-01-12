
namespace ServiLearn
{
    partial class fCuenta
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
            this.lNombre = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.bCambiarNombre = new System.Windows.Forms.Button();
            this.bCambiarContraseña = new System.Windows.Forms.Button();
            this.bEliminarCuenta = new System.Windows.Forms.Button();
            this.lDireccion = new System.Windows.Forms.Label();
            this.bDirección = new System.Windows.Forms.Button();
            this.lEmail = new System.Windows.Forms.Label();
            this.bEmail = new System.Windows.Forms.Button();
            this.lTlfn = new System.Windows.Forms.Label();
            this.bTlfn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(33, 43);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(92, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "NombreDeCuenta";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(33, 75);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(76, 13);
            this.lTipo.TabIndex = 1;
            this.lTipo.Text = "TipoDeCuenta";
            // 
            // bCambiarNombre
            // 
            this.bCambiarNombre.Location = new System.Drawing.Point(36, 267);
            this.bCambiarNombre.Name = "bCambiarNombre";
            this.bCambiarNombre.Size = new System.Drawing.Size(118, 23);
            this.bCambiarNombre.TabIndex = 2;
            this.bCambiarNombre.Text = "Cambiar Nombre";
            this.bCambiarNombre.UseVisualStyleBackColor = true;
            this.bCambiarNombre.Click += new System.EventHandler(this.bCambiarNombre_Click);
            // 
            // bCambiarContraseña
            // 
            this.bCambiarContraseña.Location = new System.Drawing.Point(36, 296);
            this.bCambiarContraseña.Name = "bCambiarContraseña";
            this.bCambiarContraseña.Size = new System.Drawing.Size(118, 23);
            this.bCambiarContraseña.TabIndex = 3;
            this.bCambiarContraseña.Text = "Cambiar Contraseña";
            this.bCambiarContraseña.UseVisualStyleBackColor = true;
            this.bCambiarContraseña.Click += new System.EventHandler(this.bCambiarContraseña_Click);
            // 
            // bEliminarCuenta
            // 
            this.bEliminarCuenta.Location = new System.Drawing.Point(36, 344);
            this.bEliminarCuenta.Name = "bEliminarCuenta";
            this.bEliminarCuenta.Size = new System.Drawing.Size(118, 23);
            this.bEliminarCuenta.TabIndex = 4;
            this.bEliminarCuenta.Text = "Eliminar Cuenta";
            this.bEliminarCuenta.UseVisualStyleBackColor = true;
            this.bEliminarCuenta.Click += new System.EventHandler(this.bEliminarCuenta_Click);
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(33, 141);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(52, 13);
            this.lDireccion.TabIndex = 5;
            this.lDireccion.Text = "Dirección";
            this.lDireccion.Visible = false;
            // 
            // bDirección
            // 
            this.bDirección.Location = new System.Drawing.Point(251, 136);
            this.bDirección.Name = "bDirección";
            this.bDirección.Size = new System.Drawing.Size(107, 23);
            this.bDirección.TabIndex = 6;
            this.bDirección.Text = "Cambiar Direccion";
            this.bDirección.UseVisualStyleBackColor = true;
            this.bDirección.Visible = false;
            this.bDirección.Click += new System.EventHandler(this.bDirección_Click);
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(33, 112);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(31, 13);
            this.lEmail.TabIndex = 7;
            this.lEmail.Text = "email";
            this.lEmail.Visible = false;
            // 
            // bEmail
            // 
            this.bEmail.Location = new System.Drawing.Point(251, 107);
            this.bEmail.Name = "bEmail";
            this.bEmail.Size = new System.Drawing.Size(107, 23);
            this.bEmail.TabIndex = 8;
            this.bEmail.Text = "Cambiar Email";
            this.bEmail.UseVisualStyleBackColor = true;
            this.bEmail.Visible = false;
            this.bEmail.Click += new System.EventHandler(this.bEmail_Click);
            // 
            // lTlfn
            // 
            this.lTlfn.AutoSize = true;
            this.lTlfn.Location = new System.Drawing.Point(33, 171);
            this.lTlfn.Name = "lTlfn";
            this.lTlfn.Size = new System.Drawing.Size(49, 13);
            this.lTlfn.TabIndex = 9;
            this.lTlfn.Text = "Telefono";
            this.lTlfn.Visible = false;
            // 
            // bTlfn
            // 
            this.bTlfn.Location = new System.Drawing.Point(251, 165);
            this.bTlfn.Name = "bTlfn";
            this.bTlfn.Size = new System.Drawing.Size(107, 23);
            this.bTlfn.TabIndex = 10;
            this.bTlfn.Text = "Cambiar Telefono";
            this.bTlfn.UseVisualStyleBackColor = true;
            this.bTlfn.Visible = false;
            this.bTlfn.Click += new System.EventHandler(this.bTlfn_Click);
            // 
            // fCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.bTlfn);
            this.Controls.Add(this.lTlfn);
            this.Controls.Add(this.bEmail);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.bDirección);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.bEliminarCuenta);
            this.Controls.Add(this.bCambiarContraseña);
            this.Controls.Add(this.bCambiarNombre);
            this.Controls.Add(this.lTipo);
            this.Controls.Add(this.lNombre);
            this.Name = "fCuenta";
            this.Text = "ServiLearn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.Button bCambiarNombre;
        private System.Windows.Forms.Button bCambiarContraseña;
        private System.Windows.Forms.Button bEliminarCuenta;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Button bDirección;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Button bEmail;
        private System.Windows.Forms.Label lTlfn;
        private System.Windows.Forms.Button bTlfn;
    }
}
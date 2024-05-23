namespace Litterium
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblAdministradores = new System.Windows.Forms.Label();
            this.lblJavi = new System.Windows.Forms.Label();
            this.lblVictor = new System.Windows.Forms.Label();
            this.lblGabriel = new System.Windows.Forms.Label();
            this.lblMartin = new System.Windows.Forms.Label();
            this.lblAdrian = new System.Windows.Forms.Label();
            this.pcbAtras = new System.Windows.Forms.PictureBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(479, 190);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(595, 190);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(479, 234);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 19);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirrecion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(479, 278);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(61, 19);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(479, 366);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(479, 410);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(95, 19);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(479, 322);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 19);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(595, 233);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(157, 22);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(595, 274);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(157, 22);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(595, 321);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(157, 22);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(595, 366);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(157, 22);
            this.txtUsuario.TabIndex = 12;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(595, 410);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(157, 22);
            this.txtContraseña.TabIndex = 13;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Gold;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(578, 460);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(156, 42);
            this.btnCrear.TabIndex = 22;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = global::registro_mockup.Properties.Resources.logo_removebg_preview;
            this.pcbLogo.Location = new System.Drawing.Point(163, 127);
            this.pcbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(285, 82);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 25;
            this.pcbLogo.TabStop = false;
            // 
            // lblAdministradores
            // 
            this.lblAdministradores.AutoSize = true;
            this.lblAdministradores.BackColor = System.Drawing.Color.Transparent;
            this.lblAdministradores.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministradores.Location = new System.Drawing.Point(221, 231);
            this.lblAdministradores.Name = "lblAdministradores";
            this.lblAdministradores.Size = new System.Drawing.Size(191, 26);
            this.lblAdministradores.TabIndex = 26;
            this.lblAdministradores.Text = "Administradores";
            // 
            // lblJavi
            // 
            this.lblJavi.AutoSize = true;
            this.lblJavi.BackColor = System.Drawing.Color.Transparent;
            this.lblJavi.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJavi.Location = new System.Drawing.Point(241, 272);
            this.lblJavi.Name = "lblJavi";
            this.lblJavi.Size = new System.Drawing.Size(112, 22);
            this.lblJavi.TabIndex = 27;
            this.lblJavi.Text = "Javi Armero";
            // 
            // lblVictor
            // 
            this.lblVictor.AutoSize = true;
            this.lblVictor.BackColor = System.Drawing.Color.Transparent;
            this.lblVictor.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictor.Location = new System.Drawing.Point(233, 366);
            this.lblVictor.Name = "lblVictor";
            this.lblVictor.Size = new System.Drawing.Size(132, 22);
            this.lblVictor.TabIndex = 28;
            this.lblVictor.Text = "Victor Bermell";
            // 
            // lblGabriel
            // 
            this.lblGabriel.AutoSize = true;
            this.lblGabriel.BackColor = System.Drawing.Color.Transparent;
            this.lblGabriel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGabriel.Location = new System.Drawing.Point(219, 414);
            this.lblGabriel.Name = "lblGabriel";
            this.lblGabriel.Size = new System.Drawing.Size(154, 22);
            this.lblGabriel.TabIndex = 30;
            this.lblGabriel.Text = "Gabriel Carmona";
            // 
            // lblMartin
            // 
            this.lblMartin.AutoSize = true;
            this.lblMartin.BackColor = System.Drawing.Color.Transparent;
            this.lblMartin.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMartin.Location = new System.Drawing.Point(217, 319);
            this.lblMartin.Name = "lblMartin";
            this.lblMartin.Size = new System.Drawing.Size(162, 22);
            this.lblMartin.TabIndex = 29;
            this.lblMartin.Text = "Martin Barrachina";
            this.lblMartin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdrian
            // 
            this.lblAdrian.AutoSize = true;
            this.lblAdrian.BackColor = System.Drawing.Color.Transparent;
            this.lblAdrian.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdrian.Location = new System.Drawing.Point(239, 460);
            this.lblAdrian.Name = "lblAdrian";
            this.lblAdrian.Size = new System.Drawing.Size(116, 22);
            this.lblAdrian.TabIndex = 31;
            this.lblAdrian.Text = "Adrian Soler";
            this.lblAdrian.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pcbAtras
            // 
            this.pcbAtras.BackColor = System.Drawing.Color.Transparent;
            this.pcbAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAtras.Image = global::registro_mockup.Properties.Resources.atras;
            this.pcbAtras.Location = new System.Drawing.Point(163, 498);
            this.pcbAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbAtras.Name = "pcbAtras";
            this.pcbAtras.Size = new System.Drawing.Size(83, 41);
            this.pcbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAtras.TabIndex = 32;
            this.pcbAtras.TabStop = false;
            this.pcbAtras.Click += new System.EventHandler(this.pcbAtras_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(521, 137);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(200, 26);
            this.lblDatos.TabIndex = 33;
            this.lblDatos.Text = "Datos de Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::registro_mockup.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 607);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.pcbAtras);
            this.Controls.Add(this.lblAdrian);
            this.Controls.Add(this.lblGabriel);
            this.Controls.Add(this.lblMartin);
            this.Controls.Add(this.lblVictor);
            this.Controls.Add(this.lblJavi);
            this.Controls.Add(this.lblAdministradores);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Registro_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblAdministradores;
        private System.Windows.Forms.Label lblJavi;
        private System.Windows.Forms.Label lblVictor;
        private System.Windows.Forms.Label lblGabriel;
        private System.Windows.Forms.Label lblMartin;
        private System.Windows.Forms.Label lblAdrian;
        private System.Windows.Forms.PictureBox pcbAtras;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


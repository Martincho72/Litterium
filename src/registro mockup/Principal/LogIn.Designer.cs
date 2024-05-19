namespace Litterium
{
    partial class FrmLogIn
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
            this.components = new System.ComponentModel.Container();
            this.lblContrasenaOlvidada = new System.Windows.Forms.Label();
            this.btnIogin = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblMensajesError = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pcbSalir = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblRegistrase = new System.Windows.Forms.Label();
            this.lblTextoRegistrase = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pcbIdioma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContrasenaOlvidada
            // 
            this.lblContrasenaOlvidada.AutoSize = true;
            this.lblContrasenaOlvidada.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenaOlvidada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContrasenaOlvidada.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaOlvidada.Location = new System.Drawing.Point(108, 358);
            this.lblContrasenaOlvidada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasenaOlvidada.Name = "lblContrasenaOlvidada";
            this.lblContrasenaOlvidada.Size = new System.Drawing.Size(216, 18);
            this.lblContrasenaOlvidada.TabIndex = 18;
            this.lblContrasenaOlvidada.Text = "¿Has olvidado tu contraseña?";
            this.lblContrasenaOlvidada.Click += new System.EventHandler(this.lblContrasenaOlvidada_Click);
            // 
            // btnIogin
            // 
            this.btnIogin.BackColor = System.Drawing.Color.Gold;
            this.btnIogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIogin.Location = new System.Drawing.Point(161, 388);
            this.btnIogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIogin.Name = "btnIogin";
            this.btnIogin.Size = new System.Drawing.Size(149, 49);
            this.btnIogin.TabIndex = 17;
            this.btnIogin.Text = "Iniciar Sesión";
            this.btnIogin.UseVisualStyleBackColor = false;
            this.btnIogin.Click += new System.EventHandler(this.btnIogin_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(237, 309);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(133, 30);
            this.txtClave.TabIndex = 16;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasena.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(64, 309);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(157, 28);
            this.lblContrasena.TabIndex = 15;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(237, 253);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(133, 30);
            this.txtUsuario.TabIndex = 14;
            // 
            // lblMensajesError
            // 
            this.lblMensajesError.AutoSize = true;
            this.lblMensajesError.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajesError.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajesError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajesError.Location = new System.Drawing.Point(163, 216);
            this.lblMensajesError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajesError.Name = "lblMensajesError";
            this.lblMensajesError.Size = new System.Drawing.Size(128, 15);
            this.lblMensajesError.TabIndex = 13;
            this.lblMensajesError.Text = "Mensajes de Error";
            this.lblMensajesError.Visible = false;
            this.lblMensajesError.Click += new System.EventHandler(this.lblMensajesError_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(106, 253);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 28);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario:";
            // 
            // pcbSalir
            // 
            this.pcbSalir.BackColor = System.Drawing.Color.Transparent;
            this.pcbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSalir.Image = global::registro_mockup.Properties.Resources._402720;
            this.pcbSalir.Location = new System.Drawing.Point(323, 46);
            this.pcbSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pcbSalir.Name = "pcbSalir";
            this.pcbSalir.Size = new System.Drawing.Size(39, 39);
            this.pcbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSalir.TabIndex = 19;
            this.pcbSalir.TabStop = false;
            this.pcbSalir.Click += new System.EventHandler(this.pcbSalir_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.BackgroundImage = global::registro_mockup.Properties.Resources.litteriumSinFondo3;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLogo.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo31;
            this.pcbLogo.Location = new System.Drawing.Point(124, 30);
            this.pcbLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(186, 183);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 11;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.Click += new System.EventHandler(this.pcbLogo_Click);
            // 
            // lblRegistrase
            // 
            this.lblRegistrase.AutoSize = true;
            this.lblRegistrase.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrase.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrase.Location = new System.Drawing.Point(281, 450);
            this.lblRegistrase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrase.Name = "lblRegistrase";
            this.lblRegistrase.Size = new System.Drawing.Size(80, 18);
            this.lblRegistrase.TabIndex = 21;
            this.lblRegistrase.Text = "Regístrate";
            this.lblRegistrase.Click += new System.EventHandler(this.lblRegistrase_Click);
            // 
            // lblTextoRegistrase
            // 
            this.lblTextoRegistrase.AutoSize = true;
            this.lblTextoRegistrase.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoRegistrase.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoRegistrase.Location = new System.Drawing.Point(75, 450);
            this.lblTextoRegistrase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextoRegistrase.Name = "lblTextoRegistrase";
            this.lblTextoRegistrase.Size = new System.Drawing.Size(200, 18);
            this.lblTextoRegistrase.TabIndex = 20;
            this.lblTextoRegistrase.Text = "¿No te has registrado aún?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pcbIdioma
            // 
            this.pcbIdioma.Image = global::registro_mockup.Properties.Resources.espanol;
            this.pcbIdioma.Location = new System.Drawing.Point(16, 91);
            this.pcbIdioma.Name = "pcbIdioma";
            this.pcbIdioma.Size = new System.Drawing.Size(88, 45);
            this.pcbIdioma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIdioma.TabIndex = 23;
            this.pcbIdioma.TabStop = false;
            this.pcbIdioma.Click += new System.EventHandler(this.pcbIdioma_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::registro_mockup.Properties.Resources.png_transparent_gold_paper_paper_paper_sheet_miscellaneous_ink_sunrise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 493);
            this.Controls.Add(this.pcbIdioma);
            this.Controls.Add(this.lblRegistrase);
            this.Controls.Add(this.lblTextoRegistrase);
            this.Controls.Add(this.pcbSalir);
            this.Controls.Add(this.lblContrasenaOlvidada);
            this.Controls.Add(this.btnIogin);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblMensajesError);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pcbLogo);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIdioma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSalir;
        private System.Windows.Forms.Label lblContrasenaOlvidada;
        private System.Windows.Forms.Button btnIogin;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblMensajesError;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblRegistrase;
        private System.Windows.Forms.Label lblTextoRegistrase;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pcbIdioma;
    }
}
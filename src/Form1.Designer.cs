namespace Login
{
    partial class FrmLogIn
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
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMensajesError = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblTextoRegistrase = new System.Windows.Forms.Label();
            this.lblRegistrase = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.lblContrasenaOlvidada = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = global::Login.Properties.Resources.litteriumSinFondo3;
            this.pcbLogo.Location = new System.Drawing.Point(122, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(248, 226);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(98, 287);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(145, 35);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblMensajesError
            // 
            this.lblMensajesError.AutoSize = true;
            this.lblMensajesError.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajesError.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajesError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajesError.Location = new System.Drawing.Point(174, 241);
            this.lblMensajesError.Name = "lblMensajesError";
            this.lblMensajesError.Size = new System.Drawing.Size(142, 16);
            this.lblMensajesError.TabIndex = 2;
            this.lblMensajesError.Text = "Mensajes de Error";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(273, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 35);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(273, 356);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(176, 35);
            this.textBox2.TabIndex = 5;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasena.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(42, 356);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(201, 35);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // lblTextoRegistrase
            // 
            this.lblTextoRegistrase.AutoSize = true;
            this.lblTextoRegistrase.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoRegistrase.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoRegistrase.Location = new System.Drawing.Point(55, 539);
            this.lblTextoRegistrase.Name = "lblTextoRegistrase";
            this.lblTextoRegistrase.Size = new System.Drawing.Size(232, 22);
            this.lblTextoRegistrase.TabIndex = 6;
            this.lblTextoRegistrase.Text = "No te has registrado aun?";
            // 
            // lblRegistrase
            // 
            this.lblRegistrase.AutoSize = true;
            this.lblRegistrase.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrase.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrase.Location = new System.Drawing.Point(329, 539);
            this.lblRegistrase.Name = "lblRegistrase";
            this.lblRegistrase.Size = new System.Drawing.Size(98, 22);
            this.lblRegistrase.TabIndex = 7;
            this.lblRegistrase.Text = "Registrate";
            this.lblRegistrase.Click += new System.EventHandler(this.lblRegistrase_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.Gold;
            this.btnImagen.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(197, 455);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(119, 60);
            this.btnImagen.TabIndex = 8;
            this.btnImagen.Text = "Log In";
            this.btnImagen.UseVisualStyleBackColor = false;
            // 
            // lblContrasenaOlvidada
            // 
            this.lblContrasenaOlvidada.AutoSize = true;
            this.lblContrasenaOlvidada.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenaOlvidada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContrasenaOlvidada.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaOlvidada.Location = new System.Drawing.Point(129, 415);
            this.lblContrasenaOlvidada.Name = "lblContrasenaOlvidada";
            this.lblContrasenaOlvidada.Size = new System.Drawing.Size(253, 22);
            this.lblContrasenaOlvidada.TabIndex = 9;
            this.lblContrasenaOlvidada.Text = "Has olvidado tu contraseña?";
            this.lblContrasenaOlvidada.Click += new System.EventHandler(this.lblContrasenaOlvidada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Login.Properties.Resources._402720;
            this.pictureBox1.Location = new System.Drawing.Point(388, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.png_transparent_gold_paper_paper_paper_sheet_miscellaneous_ink_sunrise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblContrasenaOlvidada);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.lblRegistrase);
            this.Controls.Add(this.lblTextoRegistrase);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMensajesError);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pcbLogo);
            this.Name = "FrmLogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMensajesError;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblTextoRegistrase;
        private System.Windows.Forms.Label lblRegistrase;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label lblContrasenaOlvidada;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


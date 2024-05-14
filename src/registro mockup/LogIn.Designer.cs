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
            this.lblContrasenaOlvidada = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMensajesError = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblRegistrase = new System.Windows.Forms.Label();
            this.lblTextoRegistrase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContrasenaOlvidada
            // 
            this.lblContrasenaOlvidada.AutoSize = true;
            this.lblContrasenaOlvidada.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenaOlvidada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContrasenaOlvidada.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaOlvidada.Location = new System.Drawing.Point(172, 440);
            this.lblContrasenaOlvidada.Name = "lblContrasenaOlvidada";
            this.lblContrasenaOlvidada.Size = new System.Drawing.Size(253, 22);
            this.lblContrasenaOlvidada.TabIndex = 18;
            this.lblContrasenaOlvidada.Text = "Has olvidado tu contraseña?";
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.Gold;
            this.btnImagen.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(240, 480);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(119, 60);
            this.btnImagen.TabIndex = 17;
            this.btnImagen.Text = "Log In";
            this.btnImagen.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(316, 381);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(176, 35);
            this.textBox2.TabIndex = 16;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasena.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(85, 381);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(201, 35);
            this.lblContrasena.TabIndex = 15;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(316, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 35);
            this.textBox1.TabIndex = 14;
            // 
            // lblMensajesError
            // 
            this.lblMensajesError.AutoSize = true;
            this.lblMensajesError.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajesError.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajesError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajesError.Location = new System.Drawing.Point(217, 266);
            this.lblMensajesError.Name = "lblMensajesError";
            this.lblMensajesError.Size = new System.Drawing.Size(142, 16);
            this.lblMensajesError.TabIndex = 13;
            this.lblMensajesError.Text = "Mensajes de Error";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(141, 312);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(145, 35);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::registro_mockup.Properties.Resources._402720;
            this.pictureBox1.Location = new System.Drawing.Point(431, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.BackgroundImage = global::registro_mockup.Properties.Resources.litteriumSinFondo3;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLogo.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo31;
            this.pcbLogo.Location = new System.Drawing.Point(165, 37);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(248, 226);
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
            this.lblRegistrase.Location = new System.Drawing.Point(374, 554);
            this.lblRegistrase.Name = "lblRegistrase";
            this.lblRegistrase.Size = new System.Drawing.Size(98, 22);
            this.lblRegistrase.TabIndex = 21;
            this.lblRegistrase.Text = "Registrate";
            // 
            // lblTextoRegistrase
            // 
            this.lblTextoRegistrase.AutoSize = true;
            this.lblTextoRegistrase.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoRegistrase.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoRegistrase.Location = new System.Drawing.Point(100, 554);
            this.lblTextoRegistrase.Name = "lblTextoRegistrase";
            this.lblTextoRegistrase.Size = new System.Drawing.Size(232, 22);
            this.lblTextoRegistrase.TabIndex = 20;
            this.lblTextoRegistrase.Text = "No te has registrado aun?";
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::registro_mockup.Properties.Resources.png_transparent_gold_paper_paper_paper_sheet_miscellaneous_ink_sunrise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 606);
            this.Controls.Add(this.lblRegistrase);
            this.Controls.Add(this.lblTextoRegistrase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblContrasenaOlvidada);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMensajesError);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pcbLogo);
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContrasenaOlvidada;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMensajesError;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblRegistrase;
        private System.Windows.Forms.Label lblTextoRegistrase;
    }
}
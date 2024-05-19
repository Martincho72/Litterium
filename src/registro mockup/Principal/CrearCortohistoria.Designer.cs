namespace registro_mockup.Principal
{
    partial class CrearCortohistoria
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCortohistoria = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblContadorPalabras = new System.Windows.Forms.Label();
            this.chbContinuarCortohistoria = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubirCortohistoria = new FontAwesome.Sharp.IconButton();
            this.btnBorradoresCortohistorias = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo : ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(109, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(561, 35);
            this.textBox1.TabIndex = 1;
            // 
            // lblCortohistoria
            // 
            this.lblCortohistoria.AutoSize = true;
            this.lblCortohistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCortohistoria.Location = new System.Drawing.Point(12, 58);
            this.lblCortohistoria.Name = "lblCortohistoria";
            this.lblCortohistoria.Size = new System.Drawing.Size(162, 29);
            this.lblCortohistoria.TabIndex = 2;
            this.lblCortohistoria.Text = "Cortohistoria :";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(17, 90);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(771, 288);
            this.textBox2.TabIndex = 3;
            // 
            // lblContadorPalabras
            // 
            this.lblContadorPalabras.AutoSize = true;
            this.lblContadorPalabras.Location = new System.Drawing.Point(694, 378);
            this.lblContadorPalabras.Name = "lblContadorPalabras";
            this.lblContadorPalabras.Size = new System.Drawing.Size(0, 13);
            this.lblContadorPalabras.TabIndex = 4;
            this.lblContadorPalabras.Click += new System.EventHandler(this.label1_Click);
            // 
            // chbContinuarCortohistoria
            // 
            this.chbContinuarCortohistoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbContinuarCortohistoria.AutoSize = true;
            this.chbContinuarCortohistoria.Location = new System.Drawing.Point(353, 435);
            this.chbContinuarCortohistoria.Name = "chbContinuarCortohistoria";
            this.chbContinuarCortohistoria.Size = new System.Drawing.Size(94, 17);
            this.chbContinuarCortohistoria.TabIndex = 5;
            this.chbContinuarCortohistoria.Text = "Seguir Historia";
            this.chbContinuarCortohistoria.UseVisualStyleBackColor = true;
            this.chbContinuarCortohistoria.CheckedChanged += new System.EventHandler(this.chbContinuarCortohistoria_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::registro_mockup.Properties.Resources.pregunta_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(441, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubirCortohistoria
            // 
            this.btnSubirCortohistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSubirCortohistoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubirCortohistoria.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.btnSubirCortohistoria.IconColor = System.Drawing.Color.Black;
            this.btnSubirCortohistoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubirCortohistoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirCortohistoria.Location = new System.Drawing.Point(17, 384);
            this.btnSubirCortohistoria.Name = "btnSubirCortohistoria";
            this.btnSubirCortohistoria.Size = new System.Drawing.Size(106, 68);
            this.btnSubirCortohistoria.TabIndex = 7;
            this.btnSubirCortohistoria.Text = "Subir";
            this.btnSubirCortohistoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirCortohistoria.UseVisualStyleBackColor = false;
            // 
            // btnBorradoresCortohistorias
            // 
            this.btnBorradoresCortohistorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBorradoresCortohistorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorradoresCortohistorias.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            this.btnBorradoresCortohistorias.IconColor = System.Drawing.Color.Black;
            this.btnBorradoresCortohistorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorradoresCortohistorias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorradoresCortohistorias.Location = new System.Drawing.Point(129, 384);
            this.btnBorradoresCortohistorias.Name = "btnBorradoresCortohistorias";
            this.btnBorradoresCortohistorias.Size = new System.Drawing.Size(106, 68);
            this.btnBorradoresCortohistorias.TabIndex = 8;
            this.btnBorradoresCortohistorias.Text = "Borradores";
            this.btnBorradoresCortohistorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorradoresCortohistorias.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.Location = new System.Drawing.Point(241, 384);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(106, 68);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // CrearCortohistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBorradoresCortohistorias);
            this.Controls.Add(this.btnSubirCortohistoria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chbContinuarCortohistoria);
            this.Controls.Add(this.lblContadorPalabras);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCortohistoria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CrearCortohistoria";
            this.Text = "CrearCortohistoria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCortohistoria;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblContadorPalabras;
        private System.Windows.Forms.CheckBox chbContinuarCortohistoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnSubirCortohistoria;
        private FontAwesome.Sharp.IconButton btnBorradoresCortohistorias;
        private FontAwesome.Sharp.IconButton btnBorrar;
    }
}
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblCortohistoria = new System.Windows.Forms.Label();
            this.txtCortohistoriaCrear = new System.Windows.Forms.TextBox();
            this.lblContadorPalabras = new System.Windows.Forms.Label();
            this.chbContinuarCortohistoria = new System.Windows.Forms.CheckBox();
            this.btnPictureSeguirHistoria = new System.Windows.Forms.PictureBox();
            this.btnSubirCortohistoria = new FontAwesome.Sharp.IconButton();
            this.btnBorradoresCortohistorias = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcbPortada = new System.Windows.Forms.PictureBox();
            this.btnCargarImagenCortohistoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureSeguirHistoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo : ";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(145, 10);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(747, 41);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblCortohistoria
            // 
            this.lblCortohistoria.AutoSize = true;
            this.lblCortohistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCortohistoria.Location = new System.Drawing.Point(16, 71);
            this.lblCortohistoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCortohistoria.Name = "lblCortohistoria";
            this.lblCortohistoria.Size = new System.Drawing.Size(201, 36);
            this.lblCortohistoria.TabIndex = 2;
            this.lblCortohistoria.Text = "Cortohistoria :";
            // 
            // txtCortohistoriaCrear
            // 
            this.txtCortohistoriaCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCortohistoriaCrear.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCortohistoriaCrear.Location = new System.Drawing.Point(23, 111);
            this.txtCortohistoriaCrear.Margin = new System.Windows.Forms.Padding(4);
            this.txtCortohistoriaCrear.Multiline = true;
            this.txtCortohistoriaCrear.Name = "txtCortohistoriaCrear";
            this.txtCortohistoriaCrear.Size = new System.Drawing.Size(1017, 354);
            this.txtCortohistoriaCrear.TabIndex = 3;
            // 
            // lblContadorPalabras
            // 
            this.lblContadorPalabras.AutoSize = true;
            this.lblContadorPalabras.Location = new System.Drawing.Point(925, 465);
            this.lblContadorPalabras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContadorPalabras.Name = "lblContadorPalabras";
            this.lblContadorPalabras.Size = new System.Drawing.Size(0, 16);
            this.lblContadorPalabras.TabIndex = 4;
            this.lblContadorPalabras.Click += new System.EventHandler(this.label1_Click);
            // 
            // chbContinuarCortohistoria
            // 
            this.chbContinuarCortohistoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbContinuarCortohistoria.AutoSize = true;
            this.chbContinuarCortohistoria.Location = new System.Drawing.Point(510, 537);
            this.chbContinuarCortohistoria.Margin = new System.Windows.Forms.Padding(4);
            this.chbContinuarCortohistoria.Name = "chbContinuarCortohistoria";
            this.chbContinuarCortohistoria.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.chbContinuarCortohistoria.Size = new System.Drawing.Size(122, 20);
            this.chbContinuarCortohistoria.TabIndex = 5;
            this.chbContinuarCortohistoria.Text = "Seguir Historia";
            this.chbContinuarCortohistoria.UseVisualStyleBackColor = true;
            this.chbContinuarCortohistoria.CheckedChanged += new System.EventHandler(this.chbContinuarCortohistoria_CheckedChanged);
            // 
            // btnPictureSeguirHistoria
            // 
            this.btnPictureSeguirHistoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPictureSeguirHistoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPictureSeguirHistoria.Image = global::registro_mockup.Properties.Resources.pregunta_removebg_preview;
            this.btnPictureSeguirHistoria.Location = new System.Drawing.Point(663, 532);
            this.btnPictureSeguirHistoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnPictureSeguirHistoria.Name = "btnPictureSeguirHistoria";
            this.btnPictureSeguirHistoria.Size = new System.Drawing.Size(33, 25);
            this.btnPictureSeguirHistoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictureSeguirHistoria.TabIndex = 6;
            this.btnPictureSeguirHistoria.TabStop = false;
            this.btnPictureSeguirHistoria.Click += new System.EventHandler(this.btnPictureSeguirHistoria_Click);
            // 
            // btnSubirCortohistoria
            // 
            this.btnSubirCortohistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSubirCortohistoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirCortohistoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubirCortohistoria.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.btnSubirCortohistoria.IconColor = System.Drawing.Color.Black;
            this.btnSubirCortohistoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubirCortohistoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirCortohistoria.Location = new System.Drawing.Point(22, 473);
            this.btnSubirCortohistoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubirCortohistoria.Name = "btnSubirCortohistoria";
            this.btnSubirCortohistoria.Size = new System.Drawing.Size(141, 84);
            this.btnSubirCortohistoria.TabIndex = 7;
            this.btnSubirCortohistoria.Text = "Subir";
            this.btnSubirCortohistoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirCortohistoria.UseVisualStyleBackColor = false;
            this.btnSubirCortohistoria.Click += new System.EventHandler(this.btnSubirCortohistoria_Click);
            // 
            // btnBorradoresCortohistorias
            // 
            this.btnBorradoresCortohistorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBorradoresCortohistorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorradoresCortohistorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorradoresCortohistorias.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            this.btnBorradoresCortohistorias.IconColor = System.Drawing.Color.Black;
            this.btnBorradoresCortohistorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorradoresCortohistorias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorradoresCortohistorias.Location = new System.Drawing.Point(171, 473);
            this.btnBorradoresCortohistorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorradoresCortohistorias.Name = "btnBorradoresCortohistorias";
            this.btnBorradoresCortohistorias.Size = new System.Drawing.Size(182, 84);
            this.btnBorradoresCortohistorias.TabIndex = 8;
            this.btnBorradoresCortohistorias.Text = "Borradores";
            this.btnBorradoresCortohistorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorradoresCortohistorias.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.Location = new System.Drawing.Point(361, 473);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(141, 84);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // pcbPortada
            // 
            this.pcbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPortada.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo34;
            this.pcbPortada.Location = new System.Drawing.Point(967, 127);
            this.pcbPortada.Margin = new System.Windows.Forms.Padding(4);
            this.pcbPortada.Name = "pcbPortada";
            this.pcbPortada.Size = new System.Drawing.Size(161, 151);
            this.pcbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPortada.TabIndex = 56;
            this.pcbPortada.TabStop = false;
            // 
            // btnCargarImagenCortohistoria
            // 
            this.btnCargarImagenCortohistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCargarImagenCortohistoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagenCortohistoria.Location = new System.Drawing.Point(967, 284);
            this.btnCargarImagenCortohistoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarImagenCortohistoria.Name = "btnCargarImagenCortohistoria";
            this.btnCargarImagenCortohistoria.Size = new System.Drawing.Size(161, 60);
            this.btnCargarImagenCortohistoria.TabIndex = 70;
            this.btnCargarImagenCortohistoria.Text = "Cargar";
            this.btnCargarImagenCortohistoria.UseVisualStyleBackColor = false;
            this.btnCargarImagenCortohistoria.Click += new System.EventHandler(this.btnCargarImagenCortohistoria_Click);
            // 
            // CrearCortohistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1191, 623);
            this.Controls.Add(this.btnCargarImagenCortohistoria);
            this.Controls.Add(this.pcbPortada);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBorradoresCortohistorias);
            this.Controls.Add(this.btnSubirCortohistoria);
            this.Controls.Add(this.btnPictureSeguirHistoria);
            this.Controls.Add(this.chbContinuarCortohistoria);
            this.Controls.Add(this.lblContadorPalabras);
            this.Controls.Add(this.txtCortohistoriaCrear);
            this.Controls.Add(this.lblCortohistoria);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CrearCortohistoria";
            this.Text = "CrearCortohistoria";
            this.Load += new System.EventHandler(this.CrearCortohistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureSeguirHistoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblCortohistoria;
        private System.Windows.Forms.TextBox txtCortohistoriaCrear;
        private System.Windows.Forms.Label lblContadorPalabras;
        private System.Windows.Forms.CheckBox chbContinuarCortohistoria;
        private System.Windows.Forms.PictureBox btnPictureSeguirHistoria;
        private FontAwesome.Sharp.IconButton btnSubirCortohistoria;
        private FontAwesome.Sharp.IconButton btnBorradoresCortohistorias;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pcbPortada;
        private System.Windows.Forms.Button btnCargarImagenCortohistoria;
    }
}
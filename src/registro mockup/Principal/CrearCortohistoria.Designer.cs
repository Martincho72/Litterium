﻿namespace registro_mockup.Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCortohistoria));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblCortohistoria = new System.Windows.Forms.Label();
            this.txtCortohistoriaCrear = new System.Windows.Forms.TextBox();
            this.lblContadorPalabras = new System.Windows.Forms.Label();
            this.chbContinuarCortohistoria = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.pcbPortada = new System.Windows.Forms.PictureBox();
            this.btnCargarImagenCortohistorias = new FontAwesome.Sharp.IconButton();
            this.btnVerPDF = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnBorradoresCortohistorias = new FontAwesome.Sharp.IconButton();
            this.btnSubirCortohistoria = new FontAwesome.Sharp.IconButton();
            this.btnPictureSeguirHistoria = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureSeguirHistoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(109, 8);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(561, 35);
            this.txtTitulo.TabIndex = 1;
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
            // txtCortohistoriaCrear
            // 
            this.txtCortohistoriaCrear.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCortohistoriaCrear.Location = new System.Drawing.Point(17, 90);
            this.txtCortohistoriaCrear.Multiline = true;
            this.txtCortohistoriaCrear.Name = "txtCortohistoriaCrear";
            this.txtCortohistoriaCrear.Size = new System.Drawing.Size(653, 288);
            this.txtCortohistoriaCrear.TabIndex = 3;
            this.txtCortohistoriaCrear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCortohistoriaCrear_KeyPress_1);
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
            this.chbContinuarCortohistoria.AutoSize = true;
            this.chbContinuarCortohistoria.Location = new System.Drawing.Point(541, 384);
            this.chbContinuarCortohistoria.Name = "chbContinuarCortohistoria";
            this.chbContinuarCortohistoria.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.chbContinuarCortohistoria.Size = new System.Drawing.Size(98, 17);
            this.chbContinuarCortohistoria.TabIndex = 5;
            this.chbContinuarCortohistoria.Text = "Seguir Historia";
            this.chbContinuarCortohistoria.UseVisualStyleBackColor = true;
            this.chbContinuarCortohistoria.CheckedChanged += new System.EventHandler(this.chbContinuarCortohistoria_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(708, 277);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(721, 224);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 16;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(699, 243);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(76, 20);
            this.txtAutor.TabIndex = 15;
            // 
            // pcbPortada
            // 
            this.pcbPortada.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo3;
            this.pcbPortada.Location = new System.Drawing.Point(699, 90);
            this.pcbPortada.Margin = new System.Windows.Forms.Padding(2);
            this.pcbPortada.Name = "pcbPortada";
            this.pcbPortada.Size = new System.Drawing.Size(82, 76);
            this.pcbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPortada.TabIndex = 14;
            this.pcbPortada.TabStop = false;
            // 
            // btnCargarImagenCortohistorias
            // 
            this.btnCargarImagenCortohistorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCargarImagenCortohistorias.IconColor = System.Drawing.Color.Black;
            this.btnCargarImagenCortohistorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarImagenCortohistorias.Location = new System.Drawing.Point(704, 180);
            this.btnCargarImagenCortohistorias.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarImagenCortohistorias.Name = "btnCargarImagenCortohistorias";
            this.btnCargarImagenCortohistorias.Size = new System.Drawing.Size(70, 31);
            this.btnCargarImagenCortohistorias.TabIndex = 13;
            this.btnCargarImagenCortohistorias.Text = "Cargar";
            this.btnCargarImagenCortohistorias.UseVisualStyleBackColor = true;
            this.btnCargarImagenCortohistorias.Click += new System.EventHandler(this.btnCargarImagenCortohistorias_Click);
            // 
            // btnVerPDF
            // 
            this.btnVerPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnVerPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnVerPDF.IconColor = System.Drawing.Color.Black;
            this.btnVerPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerPDF.Location = new System.Drawing.Point(689, 8);
            this.btnVerPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerPDF.Name = "btnVerPDF";
            this.btnVerPDF.Size = new System.Drawing.Size(100, 55);
            this.btnVerPDF.TabIndex = 10;
            this.btnVerPDF.Text = "Ver Como ";
            this.btnVerPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVerPDF.UseVisualStyleBackColor = false;
            this.btnVerPDF.Click += new System.EventHandler(this.btnVerPDF_Click);
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
            this.btnBorrar.Location = new System.Drawing.Point(271, 384);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(106, 68);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
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
            this.btnBorradoresCortohistorias.Location = new System.Drawing.Point(128, 384);
            this.btnBorradoresCortohistorias.Name = "btnBorradoresCortohistorias";
            this.btnBorradoresCortohistorias.Size = new System.Drawing.Size(136, 68);
            this.btnBorradoresCortohistorias.TabIndex = 8;
            this.btnBorradoresCortohistorias.Text = "Borradores";
            this.btnBorradoresCortohistorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorradoresCortohistorias.UseVisualStyleBackColor = false;
            this.btnBorradoresCortohistorias.Click += new System.EventHandler(this.btnBorradoresCortohistorias_Click);
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
            this.btnSubirCortohistoria.Location = new System.Drawing.Point(16, 384);
            this.btnSubirCortohistoria.Name = "btnSubirCortohistoria";
            this.btnSubirCortohistoria.Size = new System.Drawing.Size(106, 68);
            this.btnSubirCortohistoria.TabIndex = 7;
            this.btnSubirCortohistoria.Text = "Subir";
            this.btnSubirCortohistoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirCortohistoria.UseVisualStyleBackColor = false;
            this.btnSubirCortohistoria.Click += new System.EventHandler(this.btnSubirCortohistoria_Click);
            // 
            // btnPictureSeguirHistoria
            // 
            this.btnPictureSeguirHistoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPictureSeguirHistoria.Image = global::registro_mockup.Properties.Resources.pregunta_removebg_preview;
            this.btnPictureSeguirHistoria.Location = new System.Drawing.Point(645, 381);
            this.btnPictureSeguirHistoria.Name = "btnPictureSeguirHistoria";
            this.btnPictureSeguirHistoria.Size = new System.Drawing.Size(25, 20);
            this.btnPictureSeguirHistoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictureSeguirHistoria.TabIndex = 6;
            this.btnPictureSeguirHistoria.TabStop = false;
            this.btnPictureSeguirHistoria.Click += new System.EventHandler(this.btnPictureSeguirHistoria_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Miedo",
            "Drama",
            "Romance",
            "Aventura",
            "Accion",
            "Infantil",
            "Otro"});
            this.cmbCategoria.Location = new System.Drawing.Point(700, 301);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(73, 21);
            this.cmbCategoria.TabIndex = 54;
            // 
            // CrearCortohistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.pcbPortada);
            this.Controls.Add(this.btnCargarImagenCortohistorias);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnVerPDF);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearCortohistoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearCortohistoria";
            this.Load += new System.EventHandler(this.CrearCortohistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureSeguirHistoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnVerPDF;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox pcbPortada;
        private FontAwesome.Sharp.IconButton btnCargarImagenCortohistorias;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}
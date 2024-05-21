namespace registro_mockup.Principal
{
    partial class Comprar
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
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblUbicacionEntrega = new System.Windows.Forms.Label();
            this.txtUbicacionEntrega = new System.Windows.Forms.TextBox();
            this.lblDatosDeTarjeta = new System.Windows.Forms.Label();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.lblFechaCaducidad = new System.Windows.Forms.Label();
            this.lblCCV = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.txtCCV = new System.Windows.Forms.TextBox();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.btnPagar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.txtInformacionCompra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(89, 352);
            this.lblImporteTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(171, 24);
            this.lblImporteTotal.TabIndex = 2;
            this.lblImporteTotal.Text = "Importe total : 0,00€";
            // 
            // lblUbicacionEntrega
            // 
            this.lblUbicacionEntrega.AutoSize = true;
            this.lblUbicacionEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacionEntrega.Location = new System.Drawing.Point(93, 398);
            this.lblUbicacionEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicacionEntrega.Name = "lblUbicacionEntrega";
            this.lblUbicacionEntrega.Size = new System.Drawing.Size(170, 18);
            this.lblUbicacionEntrega.TabIndex = 3;
            this.lblUbicacionEntrega.Text = "Ubicacion de la entrega :";
            // 
            // txtUbicacionEntrega
            // 
            this.txtUbicacionEntrega.Location = new System.Drawing.Point(292, 396);
            this.txtUbicacionEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUbicacionEntrega.Name = "txtUbicacionEntrega";
            this.txtUbicacionEntrega.Size = new System.Drawing.Size(263, 22);
            this.txtUbicacionEntrega.TabIndex = 4;
            // 
            // lblDatosDeTarjeta
            // 
            this.lblDatosDeTarjeta.AutoSize = true;
            this.lblDatosDeTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDeTarjeta.Location = new System.Drawing.Point(89, 436);
            this.lblDatosDeTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosDeTarjeta.Name = "lblDatosDeTarjeta";
            this.lblDatosDeTarjeta.Size = new System.Drawing.Size(124, 18);
            this.lblDatosDeTarjeta.TabIndex = 5;
            this.lblDatosDeTarjeta.Text = "Datos de tarjeta : ";
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(148, 479);
            this.lblNumeroTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(114, 18);
            this.lblNumeroTarjeta.TabIndex = 6;
            this.lblNumeroTarjeta.Text = "Numero tarjeta :";
            // 
            // lblFechaCaducidad
            // 
            this.lblFechaCaducidad.AutoSize = true;
            this.lblFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCaducidad.Location = new System.Drawing.Point(97, 564);
            this.lblFechaCaducidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCaducidad.Name = "lblFechaCaducidad";
            this.lblFechaCaducidad.Size = new System.Drawing.Size(148, 18);
            this.lblFechaCaducidad.TabIndex = 7;
            this.lblFechaCaducidad.Text = "Fecha de caducidad :";
            // 
            // lblCCV
            // 
            this.lblCCV.AutoSize = true;
            this.lblCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCV.Location = new System.Drawing.Point(221, 518);
            this.lblCCV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(47, 18);
            this.lblCCV.TabIndex = 8;
            this.lblCCV.Text = "CCV :";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(277, 479);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(263, 22);
            this.txtNumeroTarjeta.TabIndex = 10;
            // 
            // txtCCV
            // 
            this.txtCCV.Location = new System.Drawing.Point(277, 518);
            this.txtCCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCCV.Name = "txtCCV";
            this.txtCCV.Size = new System.Drawing.Size(100, 22);
            this.txtCCV.TabIndex = 11;
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(277, 564);
            this.dtpFechaCaducidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(129, 22);
            this.dtpFechaCaducidad.TabIndex = 12;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btnPagar.IconColor = System.Drawing.Color.Black;
            this.btnPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.Location = new System.Drawing.Point(461, 661);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(145, 50);
            this.btnPagar.TabIndex = 13;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 85);
            this.panel2.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(112, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 85);
            this.panel3.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(31, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(280, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Información de compra";
            this.lblTitulo.Click += new System.EventHandler(this.lblMensaje_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo312;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::registro_mockup.Properties.Resources.lecha;
            this.btnSalir.Location = new System.Drawing.Point(12, 661);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 41);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 51;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtInformacionCompra
            // 
            this.txtInformacionCompra.BackColor = System.Drawing.Color.White;
            this.txtInformacionCompra.Location = new System.Drawing.Point(92, 166);
            this.txtInformacionCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInformacionCompra.Multiline = true;
            this.txtInformacionCompra.Name = "txtInformacionCompra";
            this.txtInformacionCompra.ReadOnly = true;
            this.txtInformacionCompra.Size = new System.Drawing.Size(463, 166);
            this.txtInformacionCompra.TabIndex = 52;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(168, 136);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Usuario:";
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(632, 761);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInformacionCompra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dtpFechaCaducidad);
            this.Controls.Add(this.txtCCV);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.lblCCV);
            this.Controls.Add(this.lblFechaCaducidad);
            this.Controls.Add(this.lblNumeroTarjeta);
            this.Controls.Add(this.lblDatosDeTarjeta);
            this.Controls.Add(this.txtUbicacionEntrega);
            this.Controls.Add(this.lblUbicacionEntrega);
            this.Controls.Add(this.lblImporteTotal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Comprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblUbicacionEntrega;
        private System.Windows.Forms.TextBox txtUbicacionEntrega;
        private System.Windows.Forms.Label lblDatosDeTarjeta;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.Label lblFechaCaducidad;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.TextBox txtCCV;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
        private FontAwesome.Sharp.IconButton btnPagar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.TextBox txtInformacionCompra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
    }
}
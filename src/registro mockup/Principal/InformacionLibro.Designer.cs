namespace registro_mockup.Principal
{
    partial class InformacionLibro
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
            this.pcbPortadaLibro = new System.Windows.Forms.PictureBox();
            this.lblValoracionLibro = new System.Windows.Forms.Label();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.lblAutorLibro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAñadirCarrito = new FontAwesome.Sharp.IconButton();
            this.btnComprarAhora = new FontAwesome.Sharp.IconButton();
            this.rbtCopiaOnline = new System.Windows.Forms.RadioButton();
            this.rbtCopiaFisica = new System.Windows.Forms.RadioButton();
            this.lblEjemplaresLibro = new System.Windows.Forms.Label();
            this.nudEjemplares = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioLibro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSinopsisLibro = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblComentarioLibro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortadaLibro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEjemplares)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbPortadaLibro
            // 
            this.pcbPortadaLibro.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo31;
            this.pcbPortadaLibro.Location = new System.Drawing.Point(12, 12);
            this.pcbPortadaLibro.Name = "pcbPortadaLibro";
            this.pcbPortadaLibro.Size = new System.Drawing.Size(196, 191);
            this.pcbPortadaLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPortadaLibro.TabIndex = 0;
            this.pcbPortadaLibro.TabStop = false;
            // 
            // lblValoracionLibro
            // 
            this.lblValoracionLibro.AutoSize = true;
            this.lblValoracionLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblValoracionLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoracionLibro.Location = new System.Drawing.Point(13, 278);
            this.lblValoracionLibro.Name = "lblValoracionLibro";
            this.lblValoracionLibro.Size = new System.Drawing.Size(195, 24);
            this.lblValoracionLibro.TabIndex = 1;
            this.lblValoracionLibro.Text = "Valoracion :                 ";
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTituloLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.Location = new System.Drawing.Point(13, 206);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(116, 24);
            this.lblTituloLibro.TabIndex = 2;
            this.lblTituloLibro.Text = "TITULO :      ";
            this.lblTituloLibro.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.AutoSize = true;
            this.lblAutorLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblAutorLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorLibro.Location = new System.Drawing.Point(13, 246);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(86, 24);
            this.lblAutorLibro.TabIndex = 3;
            this.lblAutorLibro.Text = "AUTOR :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAñadirCarrito);
            this.panel1.Controls.Add(this.btnComprarAhora);
            this.panel1.Controls.Add(this.rbtCopiaOnline);
            this.panel1.Controls.Add(this.rbtCopiaFisica);
            this.panel1.Controls.Add(this.lblEjemplaresLibro);
            this.panel1.Controls.Add(this.nudEjemplares);
            this.panel1.Controls.Add(this.lblPrecioLibro);
            this.panel1.Location = new System.Drawing.Point(527, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 296);
            this.panel1.TabIndex = 4;
            // 
            // btnAñadirCarrito
            // 
            this.btnAñadirCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAñadirCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCarrito.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.btnAñadirCarrito.IconColor = System.Drawing.Color.Black;
            this.btnAñadirCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadirCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirCarrito.Location = new System.Drawing.Point(3, 224);
            this.btnAñadirCarrito.Name = "btnAñadirCarrito";
            this.btnAñadirCarrito.Size = new System.Drawing.Size(255, 57);
            this.btnAñadirCarrito.TabIndex = 9;
            this.btnAñadirCarrito.Text = "AÑADIR AL CARRITO";
            this.btnAñadirCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirCarrito.UseVisualStyleBackColor = false;
            // 
            // btnComprarAhora
            // 
            this.btnComprarAhora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnComprarAhora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprarAhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarAhora.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnComprarAhora.IconColor = System.Drawing.Color.Black;
            this.btnComprarAhora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprarAhora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprarAhora.Location = new System.Drawing.Point(3, 161);
            this.btnComprarAhora.Name = "btnComprarAhora";
            this.btnComprarAhora.Size = new System.Drawing.Size(255, 57);
            this.btnComprarAhora.TabIndex = 8;
            this.btnComprarAhora.Text = "COMPRAR AHORA";
            this.btnComprarAhora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprarAhora.UseVisualStyleBackColor = false;
            // 
            // rbtCopiaOnline
            // 
            this.rbtCopiaOnline.AutoSize = true;
            this.rbtCopiaOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCopiaOnline.Location = new System.Drawing.Point(134, 138);
            this.rbtCopiaOnline.Name = "rbtCopiaOnline";
            this.rbtCopiaOnline.Size = new System.Drawing.Size(112, 17);
            this.rbtCopiaOnline.TabIndex = 7;
            this.rbtCopiaOnline.TabStop = true;
            this.rbtCopiaOnline.Text = "COPIA ONLINE";
            this.rbtCopiaOnline.UseVisualStyleBackColor = true;
            // 
            // rbtCopiaFisica
            // 
            this.rbtCopiaFisica.AutoSize = true;
            this.rbtCopiaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCopiaFisica.Location = new System.Drawing.Point(20, 138);
            this.rbtCopiaFisica.Name = "rbtCopiaFisica";
            this.rbtCopiaFisica.Size = new System.Drawing.Size(105, 17);
            this.rbtCopiaFisica.TabIndex = 6;
            this.rbtCopiaFisica.TabStop = true;
            this.rbtCopiaFisica.Text = "COPIA FISICA";
            this.rbtCopiaFisica.UseVisualStyleBackColor = true;
            // 
            // lblEjemplaresLibro
            // 
            this.lblEjemplaresLibro.AutoSize = true;
            this.lblEjemplaresLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplaresLibro.Location = new System.Drawing.Point(16, 106);
            this.lblEjemplaresLibro.Name = "lblEjemplaresLibro";
            this.lblEjemplaresLibro.Size = new System.Drawing.Size(96, 20);
            this.lblEjemplaresLibro.TabIndex = 5;
            this.lblEjemplaresLibro.Text = "Ejemplares :";
            // 
            // nudEjemplares
            // 
            this.nudEjemplares.Location = new System.Drawing.Point(118, 106);
            this.nudEjemplares.Name = "nudEjemplares";
            this.nudEjemplares.Size = new System.Drawing.Size(120, 20);
            this.nudEjemplares.TabIndex = 4;
            // 
            // lblPrecioLibro
            // 
            this.lblPrecioLibro.AutoSize = true;
            this.lblPrecioLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioLibro.Location = new System.Drawing.Point(41, 40);
            this.lblPrecioLibro.Name = "lblPrecioLibro";
            this.lblPrecioLibro.Size = new System.Drawing.Size(71, 29);
            this.lblPrecioLibro.TabIndex = 2;
            this.lblPrecioLibro.Text = "0,00€";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSinopsisLibro);
            this.panel2.Location = new System.Drawing.Point(214, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 296);
            this.panel2.TabIndex = 5;
            // 
            // lblSinopsisLibro
            // 
            this.lblSinopsisLibro.AutoSize = true;
            this.lblSinopsisLibro.Location = new System.Drawing.Point(99, 140);
            this.lblSinopsisLibro.Name = "lblSinopsisLibro";
            this.lblSinopsisLibro.Size = new System.Drawing.Size(46, 13);
            this.lblSinopsisLibro.TabIndex = 1;
            this.lblSinopsisLibro.Text = "Sinopsis";
            this.lblSinopsisLibro.Click += new System.EventHandler(this.label5_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblComentarioLibro);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 315);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 123);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblComentarioLibro
            // 
            this.lblComentarioLibro.AutoSize = true;
            this.lblComentarioLibro.Location = new System.Drawing.Point(3, 0);
            this.lblComentarioLibro.Name = "lblComentarioLibro";
            this.lblComentarioLibro.Size = new System.Drawing.Size(65, 13);
            this.lblComentarioLibro.TabIndex = 0;
            this.lblComentarioLibro.Text = "Comentarios";
            // 
            // InformacionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAutorLibro);
            this.Controls.Add(this.lblTituloLibro);
            this.Controls.Add(this.lblValoracionLibro);
            this.Controls.Add(this.pcbPortadaLibro);
            this.Name = "InformacionLibro";
            this.Text = "InformacionLibro";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortadaLibro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEjemplares)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPortadaLibro;
        private System.Windows.Forms.Label lblValoracionLibro;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.Label lblAutorLibro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSinopsisLibro;
        private System.Windows.Forms.Label lblComentarioLibro;
        private System.Windows.Forms.Label lblPrecioLibro;
        private System.Windows.Forms.Label lblEjemplaresLibro;
        private System.Windows.Forms.NumericUpDown nudEjemplares;
        private System.Windows.Forms.RadioButton rbtCopiaOnline;
        private System.Windows.Forms.RadioButton rbtCopiaFisica;
        private FontAwesome.Sharp.IconButton btnComprarAhora;
        private FontAwesome.Sharp.IconButton btnAñadirCarrito;
    }
}
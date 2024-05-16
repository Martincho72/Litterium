namespace registro_mockup
{
    partial class MenuPrincipal
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblinicio = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelescritorio = new System.Windows.Forms.Panel();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.btnCortohistoria = new FontAwesome.Sharp.IconButton();
            this.btnLibros = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.PCBlogo = new System.Windows.Forms.PictureBox();
            this.btnPictureMaximizar = new System.Windows.Forms.PictureBox();
            this.btnPictureMinimizar = new System.Windows.Forms.PictureBox();
            this.btnPictureSalir = new System.Windows.Forms.PictureBox();
            this.IconActual = new FontAwesome.Sharp.IconPictureBox();
            this.BTNinicio = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelescritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNinicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogo.Controls.Add(this.btnPictureMaximizar);
            this.panelLogo.Controls.Add(this.btnPictureMinimizar);
            this.panelLogo.Controls.Add(this.btnPictureSalir);
            this.panelLogo.Controls.Add(this.lblinicio);
            this.panelLogo.Controls.Add(this.IconActual);
            this.panelLogo.Controls.Add(this.BTNinicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1559, 110);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblinicio.Location = new System.Drawing.Point(308, 43);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(56, 16);
            this.lblinicio.TabIndex = 3;
            this.lblinicio.Text = "Litterium";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1559, 110);
            this.panelMenu.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.iconButton10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCortohistoria, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLibros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iconButton7, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 635);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelescritorio
            // 
            this.panelescritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelescritorio.Controls.Add(this.tableLayoutPanel1);
            this.panelescritorio.Controls.Add(this.PCBlogo);
            this.panelescritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelescritorio.Location = new System.Drawing.Point(0, 110);
            this.panelescritorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelescritorio.MinimumSize = new System.Drawing.Size(1556, 628);
            this.panelescritorio.Name = "panelescritorio";
            this.panelescritorio.Size = new System.Drawing.Size(1559, 635);
            this.panelescritorio.TabIndex = 8;
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.GlobeEurope;
            this.iconButton10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.Location = new System.Drawing.Point(3, 476);
            this.iconButton10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.iconButton10.Size = new System.Drawing.Size(216, 157);
            this.iconButton10.TabIndex = 6;
            this.iconButton10.Text = "Idioma";
            this.iconButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton10.UseVisualStyleBackColor = false;
            // 
            // btnCortohistoria
            // 
            this.btnCortohistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCortohistoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCortohistoria.FlatAppearance.BorderSize = 0;
            this.btnCortohistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCortohistoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCortohistoria.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnCortohistoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCortohistoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCortohistoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCortohistoria.Location = new System.Drawing.Point(3, 318);
            this.btnCortohistoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCortohistoria.Name = "btnCortohistoria";
            this.btnCortohistoria.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnCortohistoria.Size = new System.Drawing.Size(216, 154);
            this.btnCortohistoria.TabIndex = 5;
            this.btnCortohistoria.Text = "Cortohistorias";
            this.btnCortohistoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCortohistoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCortohistoria.UseVisualStyleBackColor = false;
            this.btnCortohistoria.Click += new System.EventHandler(this.btnCortohistoria_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLibros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.Location = new System.Drawing.Point(3, 160);
            this.btnLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnLibros.Size = new System.Drawing.Size(216, 154);
            this.btnLibros.TabIndex = 4;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibros.UseVisualStyleBackColor = false;
            this.btnLibros.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(3, 2);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.iconButton7.Size = new System.Drawing.Size(216, 154);
            this.iconButton7.TabIndex = 3;
            this.iconButton7.Text = "Mi carrito";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // PCBlogo
            // 
            this.PCBlogo.Image = global::registro_mockup.Properties.Resources.logo_removebg_preview;
            this.PCBlogo.InitialImage = global::registro_mockup.Properties.Resources.logo_removebg_preview;
            this.PCBlogo.Location = new System.Drawing.Point(311, 160);
            this.PCBlogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PCBlogo.Name = "PCBlogo";
            this.PCBlogo.Size = new System.Drawing.Size(1092, 343);
            this.PCBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBlogo.TabIndex = 0;
            this.PCBlogo.TabStop = false;
            // 
            // btnPictureMaximizar
            // 
            this.btnPictureMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPictureMaximizar.Image = global::registro_mockup.Properties.Resources.maximizar_tamano;
            this.btnPictureMaximizar.Location = new System.Drawing.Point(1446, 10);
            this.btnPictureMaximizar.Name = "btnPictureMaximizar";
            this.btnPictureMaximizar.Size = new System.Drawing.Size(45, 35);
            this.btnPictureMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictureMaximizar.TabIndex = 6;
            this.btnPictureMaximizar.TabStop = false;
            this.btnPictureMaximizar.Click += new System.EventHandler(this.btnPictureMaximizar_Click);
            // 
            // btnPictureMinimizar
            // 
            this.btnPictureMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPictureMinimizar.Image = global::registro_mockup.Properties.Resources.menos;
            this.btnPictureMinimizar.Location = new System.Drawing.Point(1372, 10);
            this.btnPictureMinimizar.Name = "btnPictureMinimizar";
            this.btnPictureMinimizar.Size = new System.Drawing.Size(45, 35);
            this.btnPictureMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictureMinimizar.TabIndex = 5;
            this.btnPictureMinimizar.TabStop = false;
            this.btnPictureMinimizar.Click += new System.EventHandler(this.btnPictureMinimizar_Click);
            // 
            // btnPictureSalir
            // 
            this.btnPictureSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPictureSalir.Image = global::registro_mockup.Properties.Resources.x;
            this.btnPictureSalir.Location = new System.Drawing.Point(1517, 14);
            this.btnPictureSalir.Name = "btnPictureSalir";
            this.btnPictureSalir.Size = new System.Drawing.Size(30, 26);
            this.btnPictureSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictureSalir.TabIndex = 4;
            this.btnPictureSalir.TabStop = false;
            this.btnPictureSalir.Click += new System.EventHandler(this.btnPictureSalir_Click);
            // 
            // IconActual
            // 
            this.IconActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.IconActual.ForeColor = System.Drawing.Color.OrangeRed;
            this.IconActual.IconChar = FontAwesome.Sharp.IconChar.House;
            this.IconActual.IconColor = System.Drawing.Color.OrangeRed;
            this.IconActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconActual.IconSize = 26;
            this.IconActual.Location = new System.Drawing.Point(274, 43);
            this.IconActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconActual.Name = "IconActual";
            this.IconActual.Size = new System.Drawing.Size(28, 26);
            this.IconActual.TabIndex = 2;
            this.IconActual.TabStop = false;
            // 
            // BTNinicio
            // 
            this.BTNinicio.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo3;
            this.BTNinicio.Location = new System.Drawing.Point(32, 10);
            this.BTNinicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNinicio.Name = "BTNinicio";
            this.BTNinicio.Size = new System.Drawing.Size(133, 90);
            this.BTNinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNinicio.TabIndex = 1;
            this.BTNinicio.TabStop = false;
            this.BTNinicio.Click += new System.EventHandler(this.BTNinicio_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 745);
            this.Controls.Add(this.panelescritorio);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1577, 792);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelescritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCBlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNinicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox BTNinicio;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox PCBlogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton btnCortohistoria;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.Panel panelescritorio;
        private System.Windows.Forms.Label lblinicio;
        private FontAwesome.Sharp.IconPictureBox IconActual;
        private System.Windows.Forms.PictureBox btnPictureMaximizar;
        private System.Windows.Forms.PictureBox btnPictureMinimizar;
        private System.Windows.Forms.PictureBox btnPictureSalir;
    }
}
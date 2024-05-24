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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.cmbLibroCortohistoria = new System.Windows.Forms.ComboBox();
            this.pcbIdioma = new System.Windows.Forms.PictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnPictureMaximizar = new System.Windows.Forms.PictureBox();
            this.btnPictureMinimizar = new System.Windows.Forms.PictureBox();
            this.btnPictureCerrar = new System.Windows.Forms.PictureBox();
            this.BTNinicio = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnCortohistorias = new FontAwesome.Sharp.IconButton();
            this.btnLibros = new FontAwesome.Sharp.IconButton();
            this.btnMiCarrito = new FontAwesome.Sharp.IconButton();
            this.panelescritorio = new System.Windows.Forms.Panel();
            this.PCBlogo = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIdioma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNinicio)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelescritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogo.Controls.Add(this.cmbLibroCortohistoria);
            this.panelLogo.Controls.Add(this.pcbIdioma);
            this.panelLogo.Controls.Add(this.txtBuscador);
            this.panelLogo.Controls.Add(this.btnBuscar);
            this.panelLogo.Controls.Add(this.btnPictureMaximizar);
            this.panelLogo.Controls.Add(this.btnPictureMinimizar);
            this.panelLogo.Controls.Add(this.btnPictureCerrar);
            this.panelLogo.Controls.Add(this.BTNinicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1192, 90);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // cmbLibroCortohistoria
            // 
            this.cmbLibroCortohistoria.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLibroCortohistoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibroCortohistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLibroCortohistoria.FormattingEnabled = true;
            this.cmbLibroCortohistoria.Items.AddRange(new object[] {
            "Libros",
            "Cortohistorias"});
            this.cmbLibroCortohistoria.Location = new System.Drawing.Point(166, 28);
            this.cmbLibroCortohistoria.Name = "cmbLibroCortohistoria";
            this.cmbLibroCortohistoria.Size = new System.Drawing.Size(172, 37);
            this.cmbLibroCortohistoria.TabIndex = 12;
            this.cmbLibroCortohistoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pcbIdioma
            // 
            this.pcbIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbIdioma.Image = global::registro_mockup.Properties.Resources.espanol;
            this.pcbIdioma.Location = new System.Drawing.Point(1007, 27);
            this.pcbIdioma.Name = "pcbIdioma";
            this.pcbIdioma.Size = new System.Drawing.Size(76, 38);
            this.pcbIdioma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIdioma.TabIndex = 24;
            this.pcbIdioma.TabStop = false;
            this.pcbIdioma.Click += new System.EventHandler(this.pcbIdioma_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(357, 29);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(576, 35);
            this.txtBuscador.TabIndex = 11;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(949, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 44);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPictureMaximizar
            // 
            this.btnPictureMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPictureMaximizar.Image = global::registro_mockup.Properties.Resources.maximizar_tamano;
            this.btnPictureMaximizar.Location = new System.Drawing.Point(1132, 10);
            this.btnPictureMaximizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPictureMaximizar.Name = "btnPictureMaximizar";
            this.btnPictureMaximizar.Size = new System.Drawing.Size(19, 20);
            this.btnPictureMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictureMaximizar.TabIndex = 8;
            this.btnPictureMaximizar.TabStop = false;
            this.btnPictureMaximizar.Click += new System.EventHandler(this.btnPictureMaximizar_Click);
            // 
            // btnPictureMinimizar
            // 
            this.btnPictureMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPictureMinimizar.Image = global::registro_mockup.Properties.Resources.menos;
            this.btnPictureMinimizar.Location = new System.Drawing.Point(1099, 10);
            this.btnPictureMinimizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPictureMinimizar.Name = "btnPictureMinimizar";
            this.btnPictureMinimizar.Size = new System.Drawing.Size(19, 20);
            this.btnPictureMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictureMinimizar.TabIndex = 7;
            this.btnPictureMinimizar.TabStop = false;
            this.btnPictureMinimizar.Click += new System.EventHandler(this.btnPictureMinimizar_Click);
            // 
            // btnPictureCerrar
            // 
            this.btnPictureCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPictureCerrar.Image = global::registro_mockup.Properties.Resources.x;
            this.btnPictureCerrar.Location = new System.Drawing.Point(1165, 10);
            this.btnPictureCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPictureCerrar.Name = "btnPictureCerrar";
            this.btnPictureCerrar.Size = new System.Drawing.Size(19, 20);
            this.btnPictureCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictureCerrar.TabIndex = 4;
            this.btnPictureCerrar.TabStop = false;
            this.btnPictureCerrar.Click += new System.EventHandler(this.btnPictureCerrar_Click);
            // 
            // BTNinicio
            // 
            this.BTNinicio.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo3;
            this.BTNinicio.Location = new System.Drawing.Point(24, 8);
            this.BTNinicio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BTNinicio.Name = "BTNinicio";
            this.BTNinicio.Size = new System.Drawing.Size(100, 73);
            this.BTNinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNinicio.TabIndex = 1;
            this.BTNinicio.TabStop = false;
            this.BTNinicio.Click += new System.EventHandler(this.BTNinicio_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1192, 90);
            this.panelMenu.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnUser, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCortohistorias, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLibros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMiCarrito, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(167, 642);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(2, 481);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btnUser.Size = new System.Drawing.Size(163, 160);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "Mi Perfil";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCortohistorias
            // 
            this.btnCortohistorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCortohistorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCortohistorias.FlatAppearance.BorderSize = 0;
            this.btnCortohistorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCortohistorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCortohistorias.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnCortohistorias.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCortohistorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCortohistorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCortohistorias.Location = new System.Drawing.Point(2, 321);
            this.btnCortohistorias.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCortohistorias.Name = "btnCortohistorias";
            this.btnCortohistorias.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btnCortohistorias.Size = new System.Drawing.Size(163, 158);
            this.btnCortohistorias.TabIndex = 5;
            this.btnCortohistorias.Text = "Cortohistorias";
            this.btnCortohistorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCortohistorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCortohistorias.UseVisualStyleBackColor = false;
            this.btnCortohistorias.Click += new System.EventHandler(this.btnCortohistorias_Click);
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
            this.btnLibros.Location = new System.Drawing.Point(2, 161);
            this.btnLibros.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btnLibros.Size = new System.Drawing.Size(163, 158);
            this.btnLibros.TabIndex = 4;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibros.UseVisualStyleBackColor = false;
            this.btnLibros.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // btnMiCarrito
            // 
            this.btnMiCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMiCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMiCarrito.FlatAppearance.BorderSize = 0;
            this.btnMiCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMiCarrito.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnMiCarrito.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMiCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMiCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiCarrito.Location = new System.Drawing.Point(2, 1);
            this.btnMiCarrito.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMiCarrito.Name = "btnMiCarrito";
            this.btnMiCarrito.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btnMiCarrito.Size = new System.Drawing.Size(163, 158);
            this.btnMiCarrito.TabIndex = 3;
            this.btnMiCarrito.Text = "Mi carrito";
            this.btnMiCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMiCarrito.UseVisualStyleBackColor = false;
            this.btnMiCarrito.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // panelescritorio
            // 
            this.panelescritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelescritorio.Controls.Add(this.tableLayoutPanel1);
            this.panelescritorio.Controls.Add(this.PCBlogo);
            this.panelescritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelescritorio.Location = new System.Drawing.Point(0, 90);
            this.panelescritorio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelescritorio.MinimumSize = new System.Drawing.Size(1167, 510);
            this.panelescritorio.Name = "panelescritorio";
            this.panelescritorio.Size = new System.Drawing.Size(1192, 642);
            this.panelescritorio.TabIndex = 8;
            this.panelescritorio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelescritorio_Paint);
            // 
            // PCBlogo
            // 
            this.PCBlogo.Image = global::registro_mockup.Properties.Resources.logo_removebg_preview;
            this.PCBlogo.InitialImage = global::registro_mockup.Properties.Resources.logo_removebg_preview;
            this.PCBlogo.Location = new System.Drawing.Point(233, 130);
            this.PCBlogo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PCBlogo.Name = "PCBlogo";
            this.PCBlogo.Size = new System.Drawing.Size(819, 279);
            this.PCBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBlogo.TabIndex = 0;
            this.PCBlogo.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 732);
            this.Controls.Add(this.panelescritorio);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(914, 483);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIdioma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNinicio)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelescritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCBlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox BTNinicio;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox PCBlogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnCortohistorias;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnMiCarrito;
        private System.Windows.Forms.Panel panelescritorio;
        private System.Windows.Forms.PictureBox btnPictureCerrar;
        private System.Windows.Forms.PictureBox btnPictureMaximizar;
        private System.Windows.Forms.PictureBox btnPictureMinimizar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnUser;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.ComboBox cmbLibroCortohistoria;
        private System.Windows.Forms.PictureBox pcbIdioma;
    }
}
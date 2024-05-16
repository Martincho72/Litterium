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
            this.BTNinicio = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.PCBlogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.panelescritorio = new System.Windows.Forms.Panel();
            this.lblinicio = new System.Windows.Forms.Label();
            this.IconActual = new FontAwesome.Sharp.IconPictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNinicio)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBlogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelescritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconActual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogo.Controls.Add(this.lblinicio);
            this.panelLogo.Controls.Add(this.IconActual);
            this.panelLogo.Controls.Add(this.BTNinicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1750, 137);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // BTNinicio
            // 
            this.BTNinicio.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo3;
            this.BTNinicio.Location = new System.Drawing.Point(36, 12);
            this.BTNinicio.Name = "BTNinicio";
            this.BTNinicio.Size = new System.Drawing.Size(150, 112);
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
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1750, 137);
            this.panelMenu.TabIndex = 5;
            // 
            // PCBlogo
            // 
            this.PCBlogo.Image = global::registro_mockup.Properties.Resources.logo_removebg_preview;
            this.PCBlogo.InitialImage = global::registro_mockup.Properties.Resources.logo_removebg_preview;
            this.PCBlogo.Location = new System.Drawing.Point(350, 200);
            this.PCBlogo.Name = "PCBlogo";
            this.PCBlogo.Size = new System.Drawing.Size(1228, 429);
            this.PCBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBlogo.TabIndex = 0;
            this.PCBlogo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.iconButton10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.iconButton9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.iconButton8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iconButton7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 785);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.iconButton7.Location = new System.Drawing.Point(3, 3);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton7.Size = new System.Drawing.Size(244, 190);
            this.iconButton7.TabIndex = 3;
            this.iconButton7.Text = "Mi carrito";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(3, 199);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton8.Size = new System.Drawing.Size(244, 190);
            this.iconButton8.TabIndex = 4;
            this.iconButton8.Text = "Libros";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = false;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton9.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(3, 395);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton9.Size = new System.Drawing.Size(244, 190);
            this.iconButton9.TabIndex = 5;
            this.iconButton9.Text = "Cortohistorias";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = false;
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
            this.iconButton10.Location = new System.Drawing.Point(3, 591);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton10.Size = new System.Drawing.Size(244, 191);
            this.iconButton10.TabIndex = 6;
            this.iconButton10.Text = "Idioma";
            this.iconButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton10.UseVisualStyleBackColor = false;
            // 
            // panelescritorio
            // 
            this.panelescritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelescritorio.Controls.Add(this.tableLayoutPanel1);
            this.panelescritorio.Controls.Add(this.PCBlogo);
            this.panelescritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelescritorio.Location = new System.Drawing.Point(0, 137);
            this.panelescritorio.MinimumSize = new System.Drawing.Size(1750, 785);
            this.panelescritorio.Name = "panelescritorio";
            this.panelescritorio.Size = new System.Drawing.Size(1750, 785);
            this.panelescritorio.TabIndex = 8;
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblinicio.Location = new System.Drawing.Point(346, 54);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(70, 20);
            this.lblinicio.TabIndex = 3;
            this.lblinicio.Text = "Litterium";
            // 
            // IconActual
            // 
            this.IconActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.IconActual.ForeColor = System.Drawing.Color.OrangeRed;
            this.IconActual.IconChar = FontAwesome.Sharp.IconChar.House;
            this.IconActual.IconColor = System.Drawing.Color.OrangeRed;
            this.IconActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconActual.Location = new System.Drawing.Point(308, 54);
            this.IconActual.Name = "IconActual";
            this.IconActual.Size = new System.Drawing.Size(32, 32);
            this.IconActual.TabIndex = 2;
            this.IconActual.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 922);
            this.Controls.Add(this.panelescritorio);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1772, 978);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNinicio)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCBlogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelescritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox BTNinicio;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox PCBlogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.Panel panelescritorio;
        private System.Windows.Forms.Label lblinicio;
        private FontAwesome.Sharp.IconPictureBox IconActual;
    }
}
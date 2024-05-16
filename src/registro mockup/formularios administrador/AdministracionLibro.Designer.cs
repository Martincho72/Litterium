namespace registro_mockup.formularios_administrador
{
    partial class AdministracionLibro
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
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditarLibro = new FontAwesome.Sharp.IconButton();
            this.btnEliminarLibro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarLibro = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibro
            // 
            this.dgvLibro.AllowUserToAddRows = false;
            this.dgvLibro.AllowUserToDeleteRows = false;
            this.dgvLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibro.Location = new System.Drawing.Point(0, 100);
            this.dgvLibro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.ReadOnly = true;
            this.dgvLibro.RowHeadersWidth = 51;
            this.dgvLibro.Size = new System.Drawing.Size(800, 350);
            this.dgvLibro.TabIndex = 3;
            this.dgvLibro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibro_CellContentClick);
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.Controls.Add(this.btnEditarLibro, 0, 0);
            this.tlpBotones.Controls.Add(this.btnEliminarLibro, 0, 0);
            this.tlpBotones.Controls.Add(this.btnAgregarLibro, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotones.Location = new System.Drawing.Point(0, 0);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(800, 100);
            this.tlpBotones.TabIndex = 2;
            // 
            // btnEditarLibro
            // 
            this.btnEditarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarLibro.FlatAppearance.BorderSize = 0;
            this.btnEditarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarLibro.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditarLibro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarLibro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarLibro.Location = new System.Drawing.Point(535, 2);
            this.btnEditarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.Padding = new System.Windows.Forms.Padding(9, 0, 19, 0);
            this.btnEditarLibro.Size = new System.Drawing.Size(262, 96);
            this.btnEditarLibro.TabIndex = 6;
            this.btnEditarLibro.Text = "Editar Libro";
            this.btnEditarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarLibro.UseVisualStyleBackColor = false;
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarLibro.FlatAppearance.BorderSize = 0;
            this.btnEliminarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminarLibro.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnEliminarLibro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminarLibro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarLibro.Location = new System.Drawing.Point(269, 2);
            this.btnEliminarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Padding = new System.Windows.Forms.Padding(9, 0, 19, 0);
            this.btnEliminarLibro.Size = new System.Drawing.Size(260, 96);
            this.btnEliminarLibro.TabIndex = 5;
            this.btnEliminarLibro.Text = "Eliminar Libro";
            this.btnEliminarLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarLibro.UseVisualStyleBackColor = false;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarLibro.FlatAppearance.BorderSize = 0;
            this.btnAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregarLibro.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btnAgregarLibro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregarLibro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarLibro.Location = new System.Drawing.Point(3, 2);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Padding = new System.Windows.Forms.Padding(9, 0, 19, 0);
            this.btnAgregarLibro.Size = new System.Drawing.Size(260, 96);
            this.btnAgregarLibro.TabIndex = 4;
            this.btnAgregarLibro.Text = "Agregar Libro";
            this.btnAgregarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            // 
            // AdministracionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.tlpBotones);
            this.Name = "AdministracionLibro";
            this.Text = "AdministracionLibro";
            this.Load += new System.EventHandler(this.AdministracionLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.tlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private FontAwesome.Sharp.IconButton btnEditarLibro;
        private FontAwesome.Sharp.IconButton btnEliminarLibro;
        private FontAwesome.Sharp.IconButton btnAgregarLibro;
    }
}
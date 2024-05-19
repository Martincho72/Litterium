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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditarLibro = new FontAwesome.Sharp.IconButton();
            this.btnEliminarLibro = new FontAwesome.Sharp.IconButton();
            this.btnAgregarLibro = new FontAwesome.Sharp.IconButton();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.Gray;
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.Controls.Add(this.btnEditarLibro, 0, 0);
            this.tlpBotones.Controls.Add(this.btnEliminarLibro, 0, 0);
            this.tlpBotones.Controls.Add(this.btnAgregarLibro, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotones.Location = new System.Drawing.Point(0, 0);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(2);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpBotones.Size = new System.Drawing.Size(600, 81);
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
            this.btnEditarLibro.Location = new System.Drawing.Point(400, 2);
            this.btnEditarLibro.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.btnEditarLibro.Size = new System.Drawing.Size(198, 77);
            this.btnEditarLibro.TabIndex = 6;
            this.btnEditarLibro.Text = "Editar Libro";
            this.btnEditarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarLibro.UseVisualStyleBackColor = false;
            this.btnEditarLibro.Click += new System.EventHandler(this.btnEditarLibro_Click);
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
            this.btnEliminarLibro.Location = new System.Drawing.Point(201, 2);
            this.btnEliminarLibro.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.btnEliminarLibro.Size = new System.Drawing.Size(195, 77);
            this.btnEliminarLibro.TabIndex = 5;
            this.btnEliminarLibro.Text = "Eliminar Libro";
            this.btnEliminarLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarLibro.UseVisualStyleBackColor = false;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
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
            this.btnAgregarLibro.Location = new System.Drawing.Point(2, 2);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.btnAgregarLibro.Size = new System.Drawing.Size(195, 77);
            this.btnAgregarLibro.TabIndex = 4;
            this.btnAgregarLibro.Text = "Agregar Libro";
            this.btnAgregarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // dgvLibro
            // 
            this.dgvLibro.AllowUserToAddRows = false;
            this.dgvLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(168)))));
            this.dgvLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibro.ColumnHeadersHeight = 35;
            this.dgvLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibro.EnableHeadersVisualStyles = false;
            this.dgvLibro.Location = new System.Drawing.Point(0, 81);
            this.dgvLibro.Margin = new System.Windows.Forms.Padding(20, 130, 20, 20);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibro.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLibro.RowHeadersVisible = false;
            this.dgvLibro.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dgvLibro.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLibro.RowTemplate.Height = 48;
            this.dgvLibro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLibro.Size = new System.Drawing.Size(600, 285);
            this.dgvLibro.TabIndex = 6;
            // 
            // AdministracionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.tlpBotones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministracionLibro";
            this.Text = "AdministracionLibro";
            this.Load += new System.EventHandler(this.AdministracionLibro_Load);
            this.tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private FontAwesome.Sharp.IconButton btnEditarLibro;
        private FontAwesome.Sharp.IconButton btnEliminarLibro;
        private FontAwesome.Sharp.IconButton btnAgregarLibro;
        private System.Windows.Forms.DataGridView dgvLibro;
    }
}
﻿namespace registro_mockup.formularios_Usuario
{
    partial class MisCortoHistorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisCortoHistorias));
            this.dgvCortoHistorias = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Continuable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Finalizada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortoHistorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCortoHistorias
            // 
            this.dgvCortoHistorias.AllowUserToAddRows = false;
            this.dgvCortoHistorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCortoHistorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(168)))));
            this.dgvCortoHistorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCortoHistorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCortoHistorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCortoHistorias.ColumnHeadersHeight = 35;
            this.dgvCortoHistorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.FechaPublicacion,
            this.Catagoria,
            this.Continuable,
            this.Finalizada,
            this.Imagen});
            this.dgvCortoHistorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCortoHistorias.EnableHeadersVisualStyles = false;
            this.dgvCortoHistorias.Location = new System.Drawing.Point(0, 0);
            this.dgvCortoHistorias.Margin = new System.Windows.Forms.Padding(20, 130, 20, 20);
            this.dgvCortoHistorias.Name = "dgvCortoHistorias";
            this.dgvCortoHistorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCortoHistorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCortoHistorias.RowHeadersVisible = false;
            this.dgvCortoHistorias.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dgvCortoHistorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCortoHistorias.RowTemplate.Height = 48;
            this.dgvCortoHistorias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCortoHistorias.Size = new System.Drawing.Size(533, 292);
            this.dgvCortoHistorias.TabIndex = 8;
            this.dgvCortoHistorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCortoHistorias_CellDoubleClick);
            this.dgvCortoHistorias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCortoHistorias_CellFormatting_1);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // FechaPublicacion
            // 
            this.FechaPublicacion.HeaderText = "Fecha Publicacion";
            this.FechaPublicacion.Name = "FechaPublicacion";
            this.FechaPublicacion.ReadOnly = true;
            // 
            // Catagoria
            // 
            this.Catagoria.HeaderText = "Categoria";
            this.Catagoria.Name = "Catagoria";
            this.Catagoria.ReadOnly = true;
            // 
            // Continuable
            // 
            this.Continuable.HeaderText = "Continuable";
            this.Continuable.Name = "Continuable";
            this.Continuable.ReadOnly = true;
            this.Continuable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Continuable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Finalizada
            // 
            this.Finalizada.HeaderText = "Finalizada";
            this.Finalizada.Name = "Finalizada";
            this.Finalizada.ReadOnly = true;
            this.Finalizada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Finalizada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MisCortoHistorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.dgvCortoHistorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MisCortoHistorias";
            this.Text = "MisCortoHistorias";
            this.Load += new System.EventHandler(this.MisCortoHistorias_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortoHistorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCortoHistorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Continuable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finalizada;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
    }
}
﻿namespace registro_mockup.formularios_Usuario
{
    partial class MisLibros
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
            this.dtgvMiscortohistorias = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreautor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAdqusicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMiscortohistorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMiscortohistorias
            // 
            this.dtgvMiscortohistorias.AllowUserToAddRows = false;
            this.dtgvMiscortohistorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvMiscortohistorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvMiscortohistorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(168)))));
            this.dtgvMiscortohistorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvMiscortohistorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvMiscortohistorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMiscortohistorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMiscortohistorias.ColumnHeadersHeight = 35;
            this.dtgvMiscortohistorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.nombreautor,
            this.FechaAdqusicion,
            this.Importe});
            this.dtgvMiscortohistorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMiscortohistorias.EnableHeadersVisualStyles = false;
            this.dtgvMiscortohistorias.Location = new System.Drawing.Point(0, 0);
            this.dtgvMiscortohistorias.Name = "dtgvMiscortohistorias";
            this.dtgvMiscortohistorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMiscortohistorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvMiscortohistorias.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dtgvMiscortohistorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvMiscortohistorias.RowTemplate.Height = 48;
            this.dtgvMiscortohistorias.Size = new System.Drawing.Size(800, 450);
            this.dtgvMiscortohistorias.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 8;
            this.Titulo.Name = "Titulo";
            // 
            // nombreautor
            // 
            this.nombreautor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreautor.HeaderText = "Autor";
            this.nombreautor.MinimumWidth = 8;
            this.nombreautor.Name = "nombreautor";
            // 
            // FechaAdqusicion
            // 
            this.FechaAdqusicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaAdqusicion.HeaderText = "Fecha de adquisición";
            this.FechaAdqusicion.MinimumWidth = 8;
            this.FechaAdqusicion.Name = "FechaAdqusicion";
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 8;
            this.Importe.Name = "Importe";
            // 
            // MisLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvMiscortohistorias);
            this.Name = "MisLibros";
            this.Text = "MisLibros";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMiscortohistorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMiscortohistorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreautor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAdqusicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}
namespace registro_mockup.Principal
{
    partial class MiCarrito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.btnPagar = new FontAwesome.Sharp.IconButton();
            this.dgvMiCarrito = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImporteTotal.Location = new System.Drawing.Point(10, 266);
            this.lblImporteTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(151, 26);
            this.lblImporteTotal.TabIndex = 1;
            this.lblImporteTotal.Text = "Importe Total :";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnPagar.IconColor = System.Drawing.Color.Black;
            this.btnPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.Location = new System.Drawing.Point(9, 323);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(124, 33);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Comprar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dgvMiCarrito
            // 
            this.dgvMiCarrito.AllowUserToAddRows = false;
            this.dgvMiCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMiCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(168)))));
            this.dgvMiCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMiCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMiCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMiCarrito.ColumnHeadersHeight = 35;
            this.dgvMiCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Titulo,
            this.Autor,
            this.Categoria,
            this.Valoracion,
            this.Precio,
            this.Cantidad,
            this.Tipo});
            this.dgvMiCarrito.EnableHeadersVisualStyles = false;
            this.dgvMiCarrito.Location = new System.Drawing.Point(15, 38);
            this.dgvMiCarrito.Margin = new System.Windows.Forms.Padding(20, 130, 20, 20);
            this.dgvMiCarrito.Name = "dgvMiCarrito";
            this.dgvMiCarrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMiCarrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMiCarrito.RowHeadersVisible = false;
            this.dgvMiCarrito.RowHeadersWidth = 50;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dgvMiCarrito.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMiCarrito.RowTemplate.Height = 48;
            this.dgvMiCarrito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMiCarrito.Size = new System.Drawing.Size(576, 136);
            this.dgvMiCarrito.TabIndex = 56;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ISBN.DefaultCellStyle = dataGridViewCellStyle2;
            this.ISBN.FillWeight = 71.0593F;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 56;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Titulo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Titulo.FillWeight = 149.7326F;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 57;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Autor.DefaultCellStyle = dataGridViewCellStyle4;
            this.Autor.FillWeight = 89.11546F;
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 56;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Categoria.DefaultCellStyle = dataGridViewCellStyle5;
            this.Categoria.FillWeight = 165.2784F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 76;
            // 
            // Valoracion
            // 
            this.Valoracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Valoracion.DefaultCellStyle = dataGridViewCellStyle6;
            this.Valoracion.FillWeight = 89.72969F;
            this.Valoracion.HeaderText = "Valoracion";
            this.Valoracion.MinimumWidth = 6;
            this.Valoracion.Name = "Valoracion";
            this.Valoracion.ReadOnly = true;
            this.Valoracion.Width = 81;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle7;
            this.Precio.FillWeight = 76.10735F;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 61;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle8;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 52;
            // 
            // MiCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvMiCarrito);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblImporteTotal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MiCarrito";
            this.Text = "MiCarrito";
            this.Load += new System.EventHandler(this.MiCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImporteTotal;
        private FontAwesome.Sharp.IconButton btnPagar;
        private System.Windows.Forms.DataGridView dgvMiCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}
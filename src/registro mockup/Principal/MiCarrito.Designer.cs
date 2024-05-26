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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiCarrito));
            this.panelMiCarrito = new System.Windows.Forms.Panel();
            this.dgvMiCarrito = new System.Windows.Forms.DataGridView();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.online = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelImporteTotal = new System.Windows.Forms.Panel();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.panelComprar = new System.Windows.Forms.Panel();
            this.btnPagar = new FontAwesome.Sharp.IconButton();
            this.panelMiCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiCarrito)).BeginInit();
            this.panelImporteTotal.SuspendLayout();
            this.panelComprar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMiCarrito
            // 
            this.panelMiCarrito.Controls.Add(this.dgvMiCarrito);
            this.panelMiCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMiCarrito.Location = new System.Drawing.Point(0, 0);
            this.panelMiCarrito.Name = "panelMiCarrito";
            this.panelMiCarrito.Size = new System.Drawing.Size(600, 250);
            this.panelMiCarrito.TabIndex = 57;
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
            this.Isbn,
            this.titulo,
            this.autor,
            this.Catagoria,
            this.valoracion,
            this.precio,
            this.cantidad,
            this.online});
            this.dgvMiCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMiCarrito.EnableHeadersVisualStyles = false;
            this.dgvMiCarrito.Location = new System.Drawing.Point(0, 0);
            this.dgvMiCarrito.Margin = new System.Windows.Forms.Padding(20, 130, 20, 20);
            this.dgvMiCarrito.Name = "dgvMiCarrito";
            this.dgvMiCarrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMiCarrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMiCarrito.RowHeadersVisible = false;
            this.dgvMiCarrito.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dgvMiCarrito.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMiCarrito.RowTemplate.Height = 48;
            this.dgvMiCarrito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMiCarrito.Size = new System.Drawing.Size(600, 250);
            this.dgvMiCarrito.TabIndex = 10;
            // 
            // Isbn
            // 
            this.Isbn.HeaderText = "ISBN";
            this.Isbn.MinimumWidth = 6;
            this.Isbn.Name = "Isbn";
            this.Isbn.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.MinimumWidth = 6;
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.MinimumWidth = 6;
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            // 
            // Catagoria
            // 
            this.Catagoria.HeaderText = "Categoria";
            this.Catagoria.MinimumWidth = 6;
            this.Catagoria.Name = "Catagoria";
            this.Catagoria.ReadOnly = true;
            // 
            // valoracion
            // 
            this.valoracion.HeaderText = "Valoracion";
            this.valoracion.MinimumWidth = 6;
            this.valoracion.Name = "valoracion";
            this.valoracion.ReadOnly = true;
            this.valoracion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // online
            // 
            this.online.HeaderText = "Online";
            this.online.MinimumWidth = 6;
            this.online.Name = "online";
            this.online.ReadOnly = true;
            this.online.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.online.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panelImporteTotal
            // 
            this.panelImporteTotal.Controls.Add(this.lblImporteTotal);
            this.panelImporteTotal.Location = new System.Drawing.Point(12, 268);
            this.panelImporteTotal.Name = "panelImporteTotal";
            this.panelImporteTotal.Size = new System.Drawing.Size(318, 28);
            this.panelImporteTotal.TabIndex = 58;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblImporteTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImporteTotal.Location = new System.Drawing.Point(0, 0);
            this.lblImporteTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(151, 26);
            this.lblImporteTotal.TabIndex = 5;
            this.lblImporteTotal.Text = "Importe Total :";
            // 
            // panelComprar
            // 
            this.panelComprar.Controls.Add(this.btnPagar);
            this.panelComprar.Location = new System.Drawing.Point(12, 328);
            this.panelComprar.Name = "panelComprar";
            this.panelComprar.Size = new System.Drawing.Size(153, 26);
            this.panelComprar.TabIndex = 59;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnPagar.IconColor = System.Drawing.Color.Black;
            this.btnPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.Location = new System.Drawing.Point(0, 0);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(153, 26);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Comprar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click_1);
            // 
            // MiCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelComprar);
            this.Controls.Add(this.panelImporteTotal);
            this.Controls.Add(this.panelMiCarrito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MiCarrito";
            this.Text = "MiCarrito";
            this.Load += new System.EventHandler(this.MiCarrito_Load);
            this.panelMiCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiCarrito)).EndInit();
            this.panelImporteTotal.ResumeLayout(false);
            this.panelImporteTotal.PerformLayout();
            this.panelComprar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMiCarrito;
        private System.Windows.Forms.Panel panelImporteTotal;
        private System.Windows.Forms.Panel panelComprar;
        private FontAwesome.Sharp.IconButton btnPagar;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.DataGridView dgvMiCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn online;
    }
}
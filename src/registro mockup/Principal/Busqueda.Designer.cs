namespace registro_mockup.Principal
{
    partial class Busqueda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda));
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultados = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvResultadosLibro = new System.Windows.Forms.DataGridView();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulolibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenPortada = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvResultadosCh = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continuable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finalizada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosCh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(10, 34);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "label1";
            this.lblBusqueda.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(54, 34);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "label2";
            this.lblTipo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblResultados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 48);
            this.panel1.TabIndex = 8;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblResultados.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(0, 0);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(175, 29);
            this.lblResultados.TabIndex = 2;
            this.lblResultados.Text = "RESULTADOS";
            this.lblResultados.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvResultadosLibro);
            this.panel2.Controls.Add(this.dgvResultadosCh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 532);
            this.panel2.TabIndex = 9;
            // 
            // dgvResultadosLibro
            // 
            this.dgvResultadosLibro.AllowUserToAddRows = false;
            this.dgvResultadosLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadosLibro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(168)))));
            this.dgvResultadosLibro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadosLibro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultadosLibro.ColumnHeadersHeight = 35;
            this.dgvResultadosLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.titulolibro,
            this.autorLibro,
            this.categoriaLibro,
            this.precio,
            this.imagenPortada});
            this.dgvResultadosLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultadosLibro.EnableHeadersVisualStyles = false;
            this.dgvResultadosLibro.Location = new System.Drawing.Point(0, 0);
            this.dgvResultadosLibro.Margin = new System.Windows.Forms.Padding(20, 130, 20, 20);
            this.dgvResultadosLibro.Name = "dgvResultadosLibro";
            this.dgvResultadosLibro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadosLibro.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultadosLibro.RowHeadersVisible = false;
            this.dgvResultadosLibro.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dgvResultadosLibro.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultadosLibro.RowTemplate.Height = 48;
            this.dgvResultadosLibro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResultadosLibro.Size = new System.Drawing.Size(878, 532);
            this.dgvResultadosLibro.TabIndex = 9;
            this.dgvResultadosLibro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultadosLibro_CellDoubleClick);
            // 
            // isbn
            // 
            this.isbn.HeaderText = "Isbn";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            // 
            // titulolibro
            // 
            this.titulolibro.HeaderText = "Titulo";
            this.titulolibro.Name = "titulolibro";
            this.titulolibro.ReadOnly = true;
            // 
            // autorLibro
            // 
            this.autorLibro.HeaderText = "Autor";
            this.autorLibro.Name = "autorLibro";
            this.autorLibro.ReadOnly = true;
            // 
            // categoriaLibro
            // 
            this.categoriaLibro.HeaderText = "Categoria";
            this.categoriaLibro.Name = "categoriaLibro";
            this.categoriaLibro.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // imagenPortada
            // 
            this.imagenPortada.HeaderText = "Imagen";
            this.imagenPortada.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imagenPortada.Name = "imagenPortada";
            this.imagenPortada.ReadOnly = true;
            this.imagenPortada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagenPortada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvResultadosCh
            // 
            this.dgvResultadosCh.AllowUserToAddRows = false;
            this.dgvResultadosCh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadosCh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(168)))));
            this.dgvResultadosCh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadosCh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultadosCh.ColumnHeadersHeight = 35;
            this.dgvResultadosCh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.autor,
            this.fechaPublicacion,
            this.categoria,
            this.continuable,
            this.finalizada,
            this.imagen});
            this.dgvResultadosCh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultadosCh.EnableHeadersVisualStyles = false;
            this.dgvResultadosCh.Location = new System.Drawing.Point(0, 0);
            this.dgvResultadosCh.Margin = new System.Windows.Forms.Padding(20, 130, 20, 20);
            this.dgvResultadosCh.Name = "dgvResultadosCh";
            this.dgvResultadosCh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadosCh.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultadosCh.RowHeadersVisible = false;
            this.dgvResultadosCh.RowHeadersWidth = 50;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dgvResultadosCh.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResultadosCh.RowTemplate.Height = 48;
            this.dgvResultadosCh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResultadosCh.Size = new System.Drawing.Size(878, 532);
            this.dgvResultadosCh.TabIndex = 8;
            this.dgvResultadosCh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultadosCh_CellDoubleClick);
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            // 
            // fechaPublicacion
            // 
            this.fechaPublicacion.HeaderText = "Fecha Publicacion";
            this.fechaPublicacion.Name = "fechaPublicacion";
            this.fechaPublicacion.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // continuable
            // 
            this.continuable.HeaderText = "Continuable";
            this.continuable.Name = "continuable";
            this.continuable.ReadOnly = true;
            this.continuable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.continuable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // finalizada
            // 
            this.finalizada.HeaderText = "Finalizada";
            this.finalizada.Name = "finalizada";
            this.finalizada.ReadOnly = true;
            this.finalizada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.finalizada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "Imagen";
            this.imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            this.imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(878, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosCh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvResultadosCh;
        private System.Windows.Forms.DataGridView dgvResultadosLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn continuable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finalizada;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulolibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewImageColumn imagenPortada;
    }
}
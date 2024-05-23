namespace registro_mockup.formularios_administrador
{
    partial class AdministracionCortoHistoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionCortoHistoria));
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditarCH = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCH = new FontAwesome.Sharp.IconButton();
            this.dgvCortoHistoria = new System.Windows.Forms.DataGridView();
            this.tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortoHistoria)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.Gray;
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBotones.Controls.Add(this.btnEditarCH, 0, 0);
            this.tlpBotones.Controls.Add(this.btnEliminarCH, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotones.Location = new System.Drawing.Point(0, 0);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(800, 100);
            this.tlpBotones.TabIndex = 4;
            // 
            // btnEditarCH
            // 
            this.btnEditarCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditarCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarCH.FlatAppearance.BorderSize = 0;
            this.btnEditarCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarCH.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnEditarCH.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarCH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCH.Location = new System.Drawing.Point(403, 2);
            this.btnEditarCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarCH.Name = "btnEditarCH";
            this.btnEditarCH.Padding = new System.Windows.Forms.Padding(9, 0, 19, 0);
            this.btnEditarCH.Size = new System.Drawing.Size(394, 96);
            this.btnEditarCH.TabIndex = 6;
            this.btnEditarCH.Text = "Editar CortoHistoria";
            this.btnEditarCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCH.UseVisualStyleBackColor = false;
            this.btnEditarCH.Click += new System.EventHandler(this.btnEditarCH_Click);
            // 
            // btnEliminarCH
            // 
            this.btnEliminarCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminarCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarCH.FlatAppearance.BorderSize = 0;
            this.btnEliminarCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminarCH.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnEliminarCH.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminarCH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCH.Location = new System.Drawing.Point(3, 2);
            this.btnEliminarCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarCH.Name = "btnEliminarCH";
            this.btnEliminarCH.Padding = new System.Windows.Forms.Padding(9, 0, 19, 0);
            this.btnEliminarCH.Size = new System.Drawing.Size(394, 96);
            this.btnEliminarCH.TabIndex = 5;
            this.btnEliminarCH.Text = "Eliminar CortoHistoria";
            this.btnEliminarCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCH.UseVisualStyleBackColor = false;
            this.btnEliminarCH.Click += new System.EventHandler(this.btnEliminarCH_Click);
            // 
            // dgvCortoHistoria
            // 
            this.dgvCortoHistoria.AllowUserToAddRows = false;
            this.dgvCortoHistoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCortoHistoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(168)))));
            this.dgvCortoHistoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCortoHistoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCortoHistoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCortoHistoria.ColumnHeadersHeight = 35;
            this.dgvCortoHistoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCortoHistoria.EnableHeadersVisualStyles = false;
            this.dgvCortoHistoria.Location = new System.Drawing.Point(0, 100);
            this.dgvCortoHistoria.Margin = new System.Windows.Forms.Padding(27, 160, 27, 25);
            this.dgvCortoHistoria.Name = "dgvCortoHistoria";
            this.dgvCortoHistoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCortoHistoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCortoHistoria.RowHeadersVisible = false;
            this.dgvCortoHistoria.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dgvCortoHistoria.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCortoHistoria.RowTemplate.Height = 48;
            this.dgvCortoHistoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCortoHistoria.Size = new System.Drawing.Size(800, 350);
            this.dgvCortoHistoria.TabIndex = 5;
            // 
            // AdministracionCortoHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCortoHistoria);
            this.Controls.Add(this.tlpBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministracionCortoHistoria";
            this.Text = "AdministracionCortoHistoria";
            this.Load += new System.EventHandler(this.AdministracionCortoHistoria_Load);
            this.tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortoHistoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private FontAwesome.Sharp.IconButton btnEditarCH;
        private FontAwesome.Sharp.IconButton btnEliminarCH;
        private System.Windows.Forms.DataGridView dgvCortoHistoria;
    }
}
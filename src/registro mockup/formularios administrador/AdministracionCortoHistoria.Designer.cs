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
            this.dgvCortoHistoria = new System.Windows.Forms.DataGridView();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditarCH = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCH = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortoHistoria)).BeginInit();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCortoHistoria
            // 
            this.dgvCortoHistoria.AllowUserToAddRows = false;
            this.dgvCortoHistoria.AllowUserToDeleteRows = false;
            this.dgvCortoHistoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCortoHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCortoHistoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCortoHistoria.Location = new System.Drawing.Point(0, 81);
            this.dgvCortoHistoria.Name = "dgvCortoHistoria";
            this.dgvCortoHistoria.ReadOnly = true;
            this.dgvCortoHistoria.RowHeadersWidth = 51;
            this.dgvCortoHistoria.Size = new System.Drawing.Size(600, 285);
            this.dgvCortoHistoria.TabIndex = 5;
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpBotones.Controls.Add(this.btnEditarCH, 0, 0);
            this.tlpBotones.Controls.Add(this.btnEliminarCH, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotones.Location = new System.Drawing.Point(0, 0);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(600, 81);
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
            this.btnEditarCH.Location = new System.Drawing.Point(302, 2);
            this.btnEditarCH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarCH.Name = "btnEditarCH";
            this.btnEditarCH.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.btnEditarCH.Size = new System.Drawing.Size(296, 77);
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
            this.btnEliminarCH.Location = new System.Drawing.Point(2, 2);
            this.btnEliminarCH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarCH.Name = "btnEliminarCH";
            this.btnEliminarCH.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.btnEliminarCH.Size = new System.Drawing.Size(296, 77);
            this.btnEliminarCH.TabIndex = 5;
            this.btnEliminarCH.Text = "Eliminar CortoHistoria";
            this.btnEliminarCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCH.UseVisualStyleBackColor = false;
            this.btnEliminarCH.Click += new System.EventHandler(this.btnEliminarCH_Click);
            // 
            // AdministracionCortoHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvCortoHistoria);
            this.Controls.Add(this.tlpBotones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdministracionCortoHistoria";
            this.Text = "AdministracionCortoHistoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortoHistoria)).EndInit();
            this.tlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCortoHistoria;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private FontAwesome.Sharp.IconButton btnEditarCH;
        private FontAwesome.Sharp.IconButton btnEliminarCH;
    }
}
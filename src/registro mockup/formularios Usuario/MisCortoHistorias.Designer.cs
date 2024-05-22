namespace registro_mockup.formularios_Usuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCortoHistorias = new System.Windows.Forms.DataGridView();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCortoHistorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCortoHistorias.ColumnHeadersHeight = 35;
            this.dgvCortoHistorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCortoHistorias.EnableHeadersVisualStyles = false;
            this.dgvCortoHistorias.Location = new System.Drawing.Point(0, 0);
            this.dgvCortoHistorias.Margin = new System.Windows.Forms.Padding(30, 200, 30, 31);
            this.dgvCortoHistorias.Name = "dgvCortoHistorias";
            this.dgvCortoHistorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCortoHistorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCortoHistorias.RowHeadersVisible = false;
            this.dgvCortoHistorias.RowHeadersWidth = 50;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dgvCortoHistorias.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCortoHistorias.RowTemplate.Height = 48;
            this.dgvCortoHistorias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCortoHistorias.Size = new System.Drawing.Size(800, 450);
            this.dgvCortoHistorias.TabIndex = 8;
            this.dgvCortoHistorias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCortoHistorias_CellFormatting_1);
            // 
            // MisCortoHistorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCortoHistorias);
            this.Name = "MisCortoHistorias";
            this.Text = "MisCortoHistorias";
            this.Load += new System.EventHandler(this.MisCortoHistorias_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortoHistorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCortoHistorias;
    }
}
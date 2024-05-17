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
            this.dgvMiCarrito = new System.Windows.Forms.DataGridView();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.btnPagar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMiCarrito
            // 
            this.dgvMiCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiCarrito.Location = new System.Drawing.Point(12, 12);
            this.dgvMiCarrito.Name = "dgvMiCarrito";
            this.dgvMiCarrito.RowHeadersWidth = 51;
            this.dgvMiCarrito.RowTemplate.Height = 24;
            this.dgvMiCarrito.Size = new System.Drawing.Size(766, 309);
            this.dgvMiCarrito.TabIndex = 0;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImporteTotal.Location = new System.Drawing.Point(13, 328);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(195, 32);
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
            this.btnPagar.Location = new System.Drawing.Point(12, 397);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(166, 41);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Comprar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // MiCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.dgvMiCarrito);
            this.Name = "MiCarrito";
            this.Text = "MiCarrito";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMiCarrito;
        private System.Windows.Forms.Label lblImporteTotal;
        private FontAwesome.Sharp.IconButton btnPagar;
    }
}
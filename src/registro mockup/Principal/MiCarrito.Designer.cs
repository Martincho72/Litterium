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
            this.btnComprarMiCarrito = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMiCarrito
            // 
            this.dgvMiCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiCarrito.Location = new System.Drawing.Point(4, 15);
            this.dgvMiCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMiCarrito.Name = "dgvMiCarrito";
            this.dgvMiCarrito.RowHeadersWidth = 51;
            this.dgvMiCarrito.RowTemplate.Height = 24;
            this.dgvMiCarrito.Size = new System.Drawing.Size(981, 383);
            this.dgvMiCarrito.TabIndex = 0;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(13, 402);
            this.lblImporteTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(271, 39);
            this.lblImporteTotal.TabIndex = 1;
            this.lblImporteTotal.Text = "Importe Total :    ";
            // 
            // btnComprarMiCarrito
            // 
            this.btnComprarMiCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComprarMiCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprarMiCarrito.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.btnComprarMiCarrito.IconColor = System.Drawing.Color.Black;
            this.btnComprarMiCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprarMiCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprarMiCarrito.Location = new System.Drawing.Point(20, 470);
            this.btnComprarMiCarrito.Name = "btnComprarMiCarrito";
            this.btnComprarMiCarrito.Size = new System.Drawing.Size(128, 44);
            this.btnComprarMiCarrito.TabIndex = 3;
            this.btnComprarMiCarrito.Text = "Comprar";
            this.btnComprarMiCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprarMiCarrito.UseVisualStyleBackColor = false;
            // 
            // MiCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 555);
            this.Controls.Add(this.btnComprarMiCarrito);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.dgvMiCarrito);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MiCarrito";
            this.Text = "MiCarrito";
            this.Load += new System.EventHandler(this.MiCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMiCarrito;
        private System.Windows.Forms.Label lblImporteTotal;
        private FontAwesome.Sharp.IconButton btnComprarMiCarrito;
    }
}
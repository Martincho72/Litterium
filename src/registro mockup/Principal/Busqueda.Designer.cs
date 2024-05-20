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
            this.dgvResultadosBusqueda = new System.Windows.Forms.DataGridView();
            this.lblResultadosBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultadosBusqueda
            // 
            this.dgvResultadosBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosBusqueda.Location = new System.Drawing.Point(12, 77);
            this.dgvResultadosBusqueda.Name = "dgvResultadosBusqueda";
            this.dgvResultadosBusqueda.Size = new System.Drawing.Size(776, 361);
            this.dgvResultadosBusqueda.TabIndex = 0;
            // 
            // lblResultadosBusqueda
            // 
            this.lblResultadosBusqueda.AutoSize = true;
            this.lblResultadosBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblResultadosBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadosBusqueda.Location = new System.Drawing.Point(12, 24);
            this.lblResultadosBusqueda.Name = "lblResultadosBusqueda";
            this.lblResultadosBusqueda.Size = new System.Drawing.Size(775, 29);
            this.lblResultadosBusqueda.TabIndex = 1;
            this.lblResultadosBusqueda.Text = "                                                RESULTADOS :                     " +
    "                             ";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultadosBusqueda);
            this.Controls.Add(this.dgvResultadosBusqueda);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultadosBusqueda;
        private System.Windows.Forms.Label lblResultadosBusqueda;
    }
}
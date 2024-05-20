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
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultadosBusqueda
            // 
            this.dgvResultadosBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosBusqueda.Location = new System.Drawing.Point(16, 95);
            this.dgvResultadosBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResultadosBusqueda.Name = "dgvResultadosBusqueda";
            this.dgvResultadosBusqueda.RowHeadersWidth = 51;
            this.dgvResultadosBusqueda.Size = new System.Drawing.Size(1035, 444);
            this.dgvResultadosBusqueda.TabIndex = 0;
            // 
            // lblResultadosBusqueda
            // 
            this.lblResultadosBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultadosBusqueda.AutoSize = true;
            this.lblResultadosBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblResultadosBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadosBusqueda.Location = new System.Drawing.Point(438, 22);
            this.lblResultadosBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultadosBusqueda.Name = "lblResultadosBusqueda";
            this.lblResultadosBusqueda.Size = new System.Drawing.Size(218, 36);
            this.lblResultadosBusqueda.TabIndex = 1;
            this.lblResultadosBusqueda.Text = "RESULTADOS";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(13, 42);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(44, 16);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "label1";
            this.lblBusqueda.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(72, 42);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 16);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "label2";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblResultadosBusqueda);
            this.Controls.Add(this.dgvResultadosBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultadosBusqueda;
        private System.Windows.Forms.Label lblResultadosBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblTipo;
    }
}
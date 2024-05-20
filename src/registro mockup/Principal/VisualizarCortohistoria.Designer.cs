namespace registro_mockup.Principal
{
    partial class VisualizarCortohistoria
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
            this.lblVisualizarCortohistoria = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCortohistoria = new System.Windows.Forms.Panel();
            this.lblCortohistoria = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pnlCortohistoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisualizarCortohistoria
            // 
            this.lblVisualizarCortohistoria.AutoSize = true;
            this.lblVisualizarCortohistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblVisualizarCortohistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizarCortohistoria.Location = new System.Drawing.Point(12, 9);
            this.lblVisualizarCortohistoria.Name = "lblVisualizarCortohistoria";
            this.lblVisualizarCortohistoria.Size = new System.Drawing.Size(453, 24);
            this.lblVisualizarCortohistoria.TabIndex = 0;
            this.lblVisualizarCortohistoria.Text = "VISUALIZAR CORTOHISTORIA DE :                           ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 63);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo :";
            // 
            // pnlCortohistoria
            // 
            this.pnlCortohistoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCortohistoria.Controls.Add(this.lblCortohistoria);
            this.pnlCortohistoria.Location = new System.Drawing.Point(11, 87);
            this.pnlCortohistoria.Name = "pnlCortohistoria";
            this.pnlCortohistoria.Size = new System.Drawing.Size(777, 279);
            this.pnlCortohistoria.TabIndex = 2;
            // 
            // lblCortohistoria
            // 
            this.lblCortohistoria.AutoSize = true;
            this.lblCortohistoria.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCortohistoria.Location = new System.Drawing.Point(3, 7);
            this.lblCortohistoria.Name = "lblCortohistoria";
            this.lblCortohistoria.Size = new System.Drawing.Size(24, 25);
            this.lblCortohistoria.TabIndex = 2;
            this.lblCortohistoria.Text = "...";
            this.lblCortohistoria.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::registro_mockup.Properties.Resources.lecha;
            this.btnSalir.Location = new System.Drawing.Point(11, 406);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 52;
            this.btnSalir.TabStop = false;
            // 
            // VisualizarCortohistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlCortohistoria);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblVisualizarCortohistoria);
            this.Name = "VisualizarCortohistoria";
            this.pnlCortohistoria.ResumeLayout(false);
            this.pnlCortohistoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualizarCortohistoria;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCortohistoria;
        private System.Windows.Forms.Label lblCortohistoria;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}
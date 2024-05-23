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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarCortohistoria));
            this.lblVisualizarCortohistoria = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.txtVisualizarCortoHistoria = new System.Windows.Forms.TextBox();
            this.btnContinuar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisualizarCortohistoria
            // 
            this.lblVisualizarCortohistoria.AutoSize = true;
            this.lblVisualizarCortohistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblVisualizarCortohistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizarCortohistoria.Location = new System.Drawing.Point(16, 11);
            this.lblVisualizarCortohistoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisualizarCortohistoria.Name = "lblVisualizarCortohistoria";
            this.lblVisualizarCortohistoria.Size = new System.Drawing.Size(566, 29);
            this.lblVisualizarCortohistoria.TabIndex = 0;
            this.lblVisualizarCortohistoria.Text = "VISUALIZAR CORTOHISTORIA DE :                           ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 78);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo :";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::registro_mockup.Properties.Resources.lecha;
            this.btnSalir.Location = new System.Drawing.Point(21, 510);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 41);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 52;
            this.btnSalir.TabStop = false;
            // 
            // txtVisualizarCortoHistoria
            // 
            this.txtVisualizarCortoHistoria.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtVisualizarCortoHistoria.Location = new System.Drawing.Point(21, 107);
            this.txtVisualizarCortoHistoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVisualizarCortoHistoria.Multiline = true;
            this.txtVisualizarCortoHistoria.Name = "txtVisualizarCortoHistoria";
            this.txtVisualizarCortoHistoria.ReadOnly = true;
            this.txtVisualizarCortoHistoria.Size = new System.Drawing.Size(1028, 370);
            this.txtVisualizarCortoHistoria.TabIndex = 53;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnContinuar.IconColor = System.Drawing.Color.Black;
            this.btnContinuar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuar.Location = new System.Drawing.Point(875, 500);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(176, 50);
            this.btnContinuar.TabIndex = 54;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // VisualizarCortohistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtVisualizarCortoHistoria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblVisualizarCortohistoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VisualizarCortohistoria";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualizarCortohistoria;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.TextBox txtVisualizarCortoHistoria;
        private FontAwesome.Sharp.IconButton btnContinuar;
    }
}
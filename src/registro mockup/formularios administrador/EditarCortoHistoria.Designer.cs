namespace registro_mockup.formularios_administrador
{
    partial class EditarCortoHistoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCortoHistoria));
            this.chbContinuable = new System.Windows.Forms.CheckBox();
            this.chbFinalizada = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pcbPortada = new System.Windows.Forms.PictureBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // chbContinuable
            // 
            this.chbContinuable.AutoSize = true;
            this.chbContinuable.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbContinuable.Location = new System.Drawing.Point(149, 345);
            this.chbContinuable.Margin = new System.Windows.Forms.Padding(2);
            this.chbContinuable.Name = "chbContinuable";
            this.chbContinuable.Size = new System.Drawing.Size(115, 23);
            this.chbContinuable.TabIndex = 71;
            this.chbContinuable.Text = "Continuable";
            this.chbContinuable.UseVisualStyleBackColor = true;
            // 
            // chbFinalizada
            // 
            this.chbFinalizada.AutoSize = true;
            this.chbFinalizada.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFinalizada.Location = new System.Drawing.Point(154, 318);
            this.chbFinalizada.Margin = new System.Windows.Forms.Padding(2);
            this.chbFinalizada.Name = "chbFinalizada";
            this.chbFinalizada.Size = new System.Drawing.Size(100, 23);
            this.chbFinalizada.TabIndex = 68;
            this.chbFinalizada.Text = "Finalizada";
            this.chbFinalizada.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gold;
            this.btnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(154, 404);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 49);
            this.btnEditar.TabIndex = 67;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(97, 74);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(113, 19);
            this.lblError.TabIndex = 66;
            this.lblError.Text = "Mensaje Error";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 72);
            this.panel1.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMensaje);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(84, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 72);
            this.panel2.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMensaje.Location = new System.Drawing.Point(13, 24);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(219, 24);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Editar CortoHistoria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::registro_mockup.Properties.Resources.litteriumSinFondo312;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(149, 173);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutor.MaxLength = 40;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(119, 20);
            this.txtAutor.TabIndex = 61;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(149, 140);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.MaxLength = 40;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(119, 20);
            this.txtTitulo.TabIndex = 60;
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaPublicacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPublicacion.Location = new System.Drawing.Point(20, 211);
            this.lblFechaPublicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(122, 16);
            this.lblFechaPublicacion.TabIndex = 59;
            this.lblFechaPublicacion.Text = "Fecha Publicacion:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(54, 248);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 16);
            this.lblCategoria.TabIndex = 57;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(54, 176);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(46, 16);
            this.lblAutor.TabIndex = 56;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(54, 141);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 16);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(149, 105);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(119, 20);
            this.txtId.TabIndex = 54;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(54, 105);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 16);
            this.lblId.TabIndex = 53;
            this.lblId.Text = "Id";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(149, 288);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdUsuario.MaxLength = 5;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(119, 20);
            this.txtIdUsuario.TabIndex = 73;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblIdUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.Location = new System.Drawing.Point(54, 288);
            this.lblIdUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(73, 16);
            this.lblIdUsuario.TabIndex = 72;
            this.lblIdUsuario.Text = "IdUsuario:";
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(149, 206);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(119, 20);
            this.dtpFechaPublicacion.TabIndex = 74;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::registro_mockup.Properties.Resources.lecha;
            this.btnSalir.Location = new System.Drawing.Point(22, 419);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 69;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Gold;
            this.btnCargar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(548, 248);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(89, 49);
            this.btnCargar.TabIndex = 76;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pcbPortada
            // 
            this.pcbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPortada.Location = new System.Drawing.Point(524, 105);
            this.pcbPortada.Name = "pcbPortada";
            this.pcbPortada.Size = new System.Drawing.Size(124, 123);
            this.pcbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPortada.TabIndex = 75;
            this.pcbPortada.TabStop = false;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(290, 104);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(2);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ReadOnly = true;
            this.txtTexto.Size = new System.Drawing.Size(209, 348);
            this.txtTexto.TabIndex = 77;
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.BackColor = System.Drawing.Color.Transparent;
            this.lblContenido.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(287, 88);
            this.lblContenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(72, 16);
            this.lblContenido.TabIndex = 78;
            this.lblContenido.Text = "Contenido";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Miedo",
            "Drama",
            "Romance",
            "Aventura",
            "Accion",
            "Infantil",
            "Otro"});
            this.cmbCategoria.Location = new System.Drawing.Point(149, 247);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(119, 21);
            this.cmbCategoria.TabIndex = 79;
            // 
            // EditarCortoHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(667, 460);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pcbPortada);
            this.Controls.Add(this.dtpFechaPublicacion);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.chbContinuable);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chbFinalizada);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblFechaPublicacion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditarCortoHistoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCortoHistoria";
            this.Load += new System.EventHandler(this.EditarCortoHistoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbContinuable;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.CheckBox chbFinalizada;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox pcbPortada;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}
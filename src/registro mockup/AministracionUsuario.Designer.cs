namespace registro_mockup
{
    partial class AministracionUsuario
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
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.Controls.Add(this.iconButton2, 0, 0);
            this.tlpBotones.Controls.Add(this.iconButton1, 0, 0);
            this.tlpBotones.Controls.Add(this.iconButton7, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotones.Location = new System.Drawing.Point(0, 0);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpBotones.Size = new System.Drawing.Size(600, 81);
            this.tlpBotones.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(400, 2);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.iconButton2.Size = new System.Drawing.Size(198, 77);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Text = "Editar Usuario";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(201, 2);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.iconButton1.Size = new System.Drawing.Size(195, 77);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Eliminar Usuario";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(2, 2);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.iconButton7.Size = new System.Drawing.Size(195, 77);
            this.iconButton7.TabIndex = 4;
            this.iconButton7.Text = "Agregar Usuario";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.usuario,
            this.clave,
            this.admin,
            this.nombre,
            this.correo,
            this.direccion,
            this.telefono,
            this.vetado,
            this.baja});
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 141);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(600, 150);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.HeaderText = "clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // admin
            // 
            this.admin.HeaderText = "admin";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            this.admin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.admin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // vetado
            // 
            this.vetado.HeaderText = "vetado";
            this.vetado.Name = "vetado";
            this.vetado.ReadOnly = true;
            this.vetado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vetado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // baja
            // 
            this.baja.HeaderText = "baja";
            this.baja.Name = "baja";
            this.baja.ReadOnly = true;
            this.baja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.baja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AministracionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.tlpBotones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AministracionUsuario";
            this.Text = "AministracionUsuario";
            this.Load += new System.EventHandler(this.AministracionUsuario_Load);
            this.tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vetado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn baja;
    }
}
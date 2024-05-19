﻿namespace registro_mockup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.Gray;
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.Controls.Add(this.btnEditarUsuario, 0, 0);
            this.tlpBotones.Controls.Add(this.btnEliminarUsuario, 0, 0);
            this.tlpBotones.Controls.Add(this.btnAgregarUsuario, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotones.Location = new System.Drawing.Point(0, 0);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(2);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpBotones.Size = new System.Drawing.Size(600, 81);
            this.tlpBotones.TabIndex = 0;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditarUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarUsuario.Location = new System.Drawing.Point(400, 2);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.btnEditarUsuario.Size = new System.Drawing.Size(198, 77);
            this.btnEditarUsuario.TabIndex = 6;
            this.btnEditarUsuario.Text = "Editar Usuario";
            this.btnEditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.btnEliminarUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(201, 2);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.btnEliminarUsuario.Size = new System.Drawing.Size(195, 77);
            this.btnEliminarUsuario.TabIndex = 5;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregarUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(2, 2);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Padding = new System.Windows.Forms.Padding(7, 0, 14, 0);
            this.btnAgregarUsuario.Size = new System.Drawing.Size(195, 77);
            this.btnAgregarUsuario.TabIndex = 4;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(168)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 35;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 81);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(20, 130, 20, 20);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.RowTemplate.Height = 48;
            this.dgvUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsuarios.Size = new System.Drawing.Size(600, 285);
            this.dgvUsuarios.TabIndex = 2;
            // 
            // AministracionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.tlpBotones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AministracionUsuario";
            this.Text = "AministracionUsuario";
            this.Load += new System.EventHandler(this.AministracionUsuario_Load);
            this.tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private FontAwesome.Sharp.IconButton btnEditarUsuario;
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private FontAwesome.Sharp.IconButton btnAgregarUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}
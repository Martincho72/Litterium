﻿using registro_mockup.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_mockup.formularios_administrador
{
    public partial class EditarLibro : Form
    {
        BDatos basedatos=new BDatos();
        public EditarLibro(string isbn)
        {
            InitializeComponent();
            txtIsbn.Text = isbn;
        }

        private void EditarLibro_Load(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
               Libro l1 = Libro.EncontrarDatosLibro(basedatos.Conexion, txtIsbn.Text);
                txtIsbn.Text = l1.Isbn;
                txtTitulo.Text = l1.Titulo;
                txtAutor.Text = l1.Autor;
                cmbCategoria.Text = l1.Categoria;
                cmbValoracion.Text = l1.Valoracion.ToString();
            }
            else { }
            basedatos.CerrarConexion();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                double valoracion;
                Double.TryParse(cmbValoracion.Text, out valoracion);
                Libro l1 = new  Libro(txtIsbn.Text, txtTitulo.Text, txtAutor.Text, cmbCategoria.Text, valoracion);
                Libro.EditarLibro(basedatos.Conexion, l1);
                this.Close();
            }
            else { }
            basedatos.CerrarConexion();
        }
    }
}
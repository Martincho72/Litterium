﻿using registro_mockup.clases;
using registro_mockup.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace registro_mockup.Principal
{
    public partial class VisualizarCortohistoria : Form
    {
        BDatos basedatos = new BDatos();
        string us;
        int id;
        public VisualizarCortohistoria(string titulo,string usuario ,int id)
        {
            this.id = id;
            us = usuario;
            InitializeComponent();
            AplicarIdioma();
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, id);
                lblTitulo.Text += ch.Titulo;
                txtVisualizarCortoHistoria.Text = ch.Texto;
                lblVisualizarCortohistoria.Text += ch.Autor;

            }
            basedatos.CerrarConexion();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloVisualizarCortohistoria;
            lblTitulo.Text = Idioma.lblTituloVisulaizarCortohistoria;
            lblVisualizarCortohistoria.Text = Idioma.lblVisualizarCortohistoria;
            btnContinuar.Text = Idioma.btnContinuar;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void VisualizarCortohistoria_Load(object sender, EventArgs e)
        {
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, id);
                CrearCortohistoria crear = new CrearCortohistoria(ch.Id, us);
                crear.Show();
            }
            else {}
            basedatos.CerrarConexion();
            
        }
    }
}

using registro_mockup.clases;
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

namespace registro_mockup.Principal
{
    public partial class VisualizarCortohistoria : Form
    {
        BDatos basedatos = new BDatos();
        string us;
        public VisualizarCortohistoria(string titulo,string usuario ,int id)
        {
            us = usuario;
            InitializeComponent();
            AplicarIdioma();
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, id);
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
    }
}

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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace registro_mockup.Principal
{
    public partial class VisualizarCortohistoria : Form
    {
        BDatos basedatos = new BDatos();
        string us;
        int id;
        string formularioanterior;
        public VisualizarCortohistoria(string usuario ,int id, string anteriorFormulario)
        {
            formularioanterior = anteriorFormulario;
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
                int id_usu = Usuario.ObtenerID(basedatos.Conexion, us);
                if (!ch.Continuable || id_usu == ch.Id_usuario)
                {
                    btnContinuar.Visible = false;
                }
                if (formularioanterior == "ChPrincipal")
                {
                    btnSalir.Visible = false;
                }
                else
                {
                    btnSalir.Visible = true;
                }

            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                crear.ShowDialog();
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

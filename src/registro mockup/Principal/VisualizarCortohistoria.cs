using registro_mockup.clases;
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
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, id);
                txtVisualizarCortoHistoria.Text = ch.Texto;
                lblVisualizarCortohistoria.Text= "VISUALIZAR CORTOHISTORIA DE: " + ch.Autor;

            }
            basedatos.CerrarConexion();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void VisualizarCortohistoria_Load(object sender, EventArgs e)
        {

        }
    }
}

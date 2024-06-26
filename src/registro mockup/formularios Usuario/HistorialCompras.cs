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

namespace registro_mockup.formularios_Usuario
{
    public partial class HistorialCompras : Form
    {
        BDatos bDatos = new BDatos();
        private string usuariomenu;

        public HistorialCompras(string usuario)
        {
            usuariomenu = usuario;
            InitializeComponent();
        }
        private void CargaCompras()
        {
            try
            {
                if (bDatos.AbrirConexion())
                {
                    int idUsuario = Usuario.ObtenerID(bDatos.Conexion, usuariomenu);
                    dgvHistorialCompras.DataSource = Ejemplar.BuscarEjemplares(bDatos.Conexion, idUsuario);
                }
                else
                {
                    MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                bDatos.CerrarConexion();
            }
        }

        private void HistorialCompras_Load_1(object sender, EventArgs e)
        {
            CargaCompras();
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloHistorialComprar;
        }
    }
}

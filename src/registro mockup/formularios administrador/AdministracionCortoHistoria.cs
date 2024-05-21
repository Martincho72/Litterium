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
    public partial class AdministracionCortoHistoria : Form
    {
        BDatos bDatos = new BDatos();

        public AdministracionCortoHistoria()
        {
            InitializeComponent();
        }

        private void btnEliminarCH_Click(object sender, EventArgs e)
        {
            if (bDatos.AbrirConexion())
            {
                EliminarCortoHistoria form = new EliminarCortoHistoria();
                form.ShowDialog();
            }
            else
            {

            }
            bDatos.CerrarConexion();
            CargaLibros();
        }

        private void btnEditarCH_Click(object sender, EventArgs e)
        {
            if (bDatos.AbrirConexion())
            {
                BuscarCortoHistoria edit = new BuscarCortoHistoria();
                edit.ShowDialog();
            }
            else
            {

            }
            bDatos.CerrarConexion();
            CargaLibros();
        }

        private void AdministracionCortoHistoria_Load(object sender, EventArgs e)
        {
            CargaLibros();
        }
        private void CargaLibros()
        {
            if (bDatos.AbrirConexion())
            {

                dgvCortoHistoria.DataSource = CortoHistoria.BuscarCortoHistoria(bDatos.Conexion);
            }
            else { }
            bDatos.CerrarConexion();
        }

    }
}
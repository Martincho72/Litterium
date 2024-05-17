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
    public partial class BuscarLibro : Form
    {
        BDatos basedatos=new BDatos();
        public BuscarLibro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                if (Libro.EncontrarLibro(basedatos.Conexion, txtIsbn.Text))
                {
                    EditarLibro form = new EditarLibro(txtIsbn.Text);
                    form.ShowDialog();
                }
            }

            else { }
            basedatos.CerrarConexion();
        }
    }
}
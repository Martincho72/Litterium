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
    public partial class Busqueda : Form
    {
        BDatos basedatos = new BDatos();
        public Busqueda(string txtbusqueda, string tipo)
        {
            InitializeComponent();
            lblBusqueda.Text = txtbusqueda;
            lblTipo.Text = tipo;
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            //if (basedatos.AbrirConexion())
            //{


            //    if (lblTipo.Text == "Cortohistorias")
            //    {
            //        dgvResultadosBusqueda.DataSource = CortoHistoria.BuscarCortoHistoria(basedatos.Conexion, lblBusqueda.Text);
            //    }
            //    else if (lblTipo.Text == "Libros")
            //    {
            //        dgvResultadosBusqueda.DataSource = Libro.BuscarLibros(basedatos.Conexion, lblBusqueda.Text);
            //    }
            //}
            //else { }
            //basedatos.CerrarConexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvResultadosBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloBusqueda;
            lblResultados.Text = Idioma.lblResultadosBusqueda;
        }
    }
}

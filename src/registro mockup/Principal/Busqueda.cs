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
            if (basedatos.AbrirConexion())
            {


                if (lblTipo.Text == "Cortohistorias")
                {
                    dgvResultadosBusqueda.DataSource = CortoHistoria.BuscarCortoHistoria(basedatos.Conexion, lblBusqueda.Text);
                }else if (lblTipo.Text == "Libros")
                {
                    dgvResultadosBusqueda.DataSource = Libro.BuscarLibros(basedatos.Conexion, lblBusqueda.Text);
                }
            }
            else { }
            basedatos.CerrarConexion();
        }
    }
}

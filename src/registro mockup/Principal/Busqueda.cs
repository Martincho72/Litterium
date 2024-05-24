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
            if (basedatos.AbrirConexion())
            {


                if (lblTipo.Text == "Cortohistorias")
                {
                    dgvResultadosLibro.Visible = false;
                    dgvResultadosCh.Visible= true;
                    List<CortoHistoria> ch = CortoHistoria.BuscarCortoHistoria(basedatos.Conexion, lblBusqueda.Text);
                    foreach (CortoHistoria corto in ch)
                    {
                        dgvResultadosCh.Rows.Add(corto.Titulo, corto.Autor, corto.FechaPublicacion.ToString("dd-MM-yyyy"), corto.Categoria, corto.Continuable, corto.Finalizada,corto.Portada);
                    }
                }
                else
                {
                    dgvResultadosLibro.Visible = true;
                    dgvResultadosCh.Visible = false;
                    List<Libro> libros = Libro.BuscarLibrosBusqueda(basedatos.Conexion,lblBusqueda.Text);
                    foreach (Libro l1 in libros)
                    {
                        dgvResultadosLibro.Rows.Add(l1.Isbn,l1.Titulo,l1.Autor,l1.Categoria,l1.Precio,l1.Portada);
                    }
                }
            }
            basedatos.CerrarConexion();
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

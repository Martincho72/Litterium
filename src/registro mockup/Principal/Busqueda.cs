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
        private Form currentForm;
        private string usuariomenu;
        public Busqueda(string txtbusqueda, string tipo, string usuario)
        {
            InitializeComponent();
            lblBusqueda.Text = txtbusqueda;
            lblTipo.Text = tipo;
            usuariomenu = usuario;
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
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloBusqueda;
            lblResultados.Text = Idioma.lblResultadosBusqueda;
        }

        private void dgvResultadosLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (basedatos.AbrirConexion())
            {
                Libro libro = Libro.EncontrarDatosLibro(basedatos.Conexion, dgvResultadosLibro.Rows[indice].Cells[0].Value.ToString());
                InformacionLibro l = new InformacionLibro(libro.Titulo, usuariomenu);
                l.ShowDialog();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void dgvResultadosCh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, dgvResultadosCh.Rows[indice].Cells[0].Value.ToString());
                VisualizarCortohistoria vs = new VisualizarCortohistoria(usuariomenu, ch.Id);
                vs.ShowDialog();
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

       
    }
}

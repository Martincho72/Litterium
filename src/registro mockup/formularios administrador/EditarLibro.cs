using registro_mockup.clases;
using registro_mockup.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_mockup.formularios_administrador
{
    public partial class EditarLibro : Form
    {
        BDatos basedatos=new BDatos();
        private byte[] libroPdfBytes = null;

        public EditarLibro(string isbn)
        {
            InitializeComponent();
            txtIsbn.Text = isbn;
        }

        private void EditarLibro_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            lblErrores.Text = "";
            if (basedatos.AbrirConexion())
            {
               Libro l1 = Libro.EncontrarDatosLibro(basedatos.Conexion, txtIsbn.Text);
                txtIsbn.Text = l1.Isbn;
                txtTitulo.Text = l1.Titulo;
                txtAutor.Text = l1.Autor;
                cmbCategoria.Text = l1.Categoria;
                cmbValoracion.Text = l1.Valoracion.ToString();
                pcbPortada.Image = l1.Portada;
                txtPrecio.Text=l1.Precio.ToString();
                txtSinopsis.Text = l1.Sinopsis;
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();

        }

        private void AplicarIdioma()
        {
            cmbCategoria.Items[0] = Idioma.CategoriaMiedo;
            cmbCategoria.Items[1] = Idioma.CategoriaDrama;
            cmbCategoria.Items[2] = Idioma.CategoriaRomance;
            cmbCategoria.Items[3] = Idioma.CategoriaAventura;
            cmbCategoria.Items[4] = Idioma.CategoriaAccion;
            cmbCategoria.Items[5] = Idioma.CategoriaInfantil;
            cmbCategoria.Items[6] = Idioma.CategoriaOtro;
            this.Text = Idioma.TituloEditarLibro;
            lblMensaje.Text = Idioma.lblMensajeEditarLibro;
            lblIsbn.Text = Idioma.lblISBNEditarLibro;
            lblTitulo.Text = Idioma.lblTituloEditarLibro;
            lblAutor.Text = Idioma.lblAutorEditarLibro;
            lblCategoria.Text = Idioma.lblCategoriaEditarLibro;
            lblValoracion.Text = Idioma.lblValoracionEditarLibro;
            lblPrecio.Text = Idioma.lblPrecioEditarLibro;
            lblSinopsis.Text = Idioma.lblSinopsisEditarLibro;
            lblInfoSinopsis.Text = Idioma.lblInfoSinopsisEditarLibro;
            btnCargar.Text = Idioma.btnCargarEditarLibro;
            btnCrear.Text = Idioma.btnCrearEditarLibro;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
               
                double valoracion;
                Double.TryParse(cmbValoracion.Text, out valoracion);
                double precio;
                Double.TryParse(txtPrecio.Text, out precio);
                Libro l1 = new Libro(txtIsbn.Text, txtTitulo.Text, txtAutor.Text, cmbCategoria.Text, valoracion, pcbPortada.Image, txtSinopsis.Text,precio, libroPdfBytes);
                    Libro.EditarLibro(basedatos.Conexion, l1);
                    this.Close();
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        { 
            OpenFileDialog cargaImagen = new OpenFileDialog();
            cargaImagen.InitialDirectory = "C:\\";
            cargaImagen.Filter = "JPG (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (cargaImagen.ShowDialog() == DialogResult.OK)
            {
                pcbPortada.ImageLocation = cargaImagen.FileName;
                MessageBox.Show(cargaImagen.FileName);
            }
            else
            {
                MessageBox.Show(Idioma.ImagenNoSeleccionada, Idioma.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbPortada_Click(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfPath = openFileDialog.FileName;
                byte[] pdfBytes = File.ReadAllBytes(pdfPath);

                // Guardar el PDF en una variable de clase o pasarlo directamente al constructor del libro
                libroPdfBytes = pdfBytes; // Asumimos que tienes una variable de clase llamada libroPdfBytes
            }
        }
    }
}

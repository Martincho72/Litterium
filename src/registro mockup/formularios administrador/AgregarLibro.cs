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
    public partial class AgregarLibro : Form
    {
        BDatos basedatos = new BDatos();
        private byte[] libroPdfBytes = null;
        public AgregarLibro()
        {
            InitializeComponent();
        }

        private bool ValidarDatos()
        {
            bool ok = true;
            if (txtIsbn.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIsbn, Idioma.errorProviderIsbn);
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtTitulo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTitulo, Idioma.errorProviderTitulo);
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtAutor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtAutor, Idioma.errorProviderAutor);
            }
            else
            {
                errorProvider1.Clear();

            }
           

            return ok;
        }

        private void AgregarLibro_Load(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            AplicarIdioma();
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
            this.Text = Idioma.TituloAgregarLibro;
            lblMensaje.Text = Idioma.lblMensajeAgregarLibro;
            lblTitulo.Text = Idioma.lblTituloAgregarLibro;
            lblAutor.Text = Idioma.lblAutorAgregarLibro;
            lblCategoria.Text = Idioma.lblCategoriaAgregarLibro;
            lblValoracion.Text = Idioma.lblValoracionAgregarLibro;
            lblPrecio.Text = Idioma.lblPrecioAgregarLibro;
            lblSinopsis.Text = Idioma.lblSinopsisAgregarLibro;
            lblInfoSinopsis.Text = Idioma.lblInfoSinopsisAgregarLibro;
            btnCargar.Text = Idioma.btnCargarAgregarLibro;
            btnCrear.Text = Idioma.btnCrearAgregarLibro;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            if (ValidarDatos())
            {
                if (basedatos.AbrirConexion())
                {
                    if (!Libro.EncontrarLibro(basedatos.Conexion, txtIsbn.Text))
                    {
                        double valoracion;
                        Double.TryParse(cmbValoracion.Text, out valoracion);
                        double precio;
                        Double.TryParse(txtPrecio.Text, out precio);
                        Libro l1 = new Libro(txtIsbn.Text, txtTitulo.Text, txtAutor.Text, cmbCategoria.Text, valoracion,pcbPortada.Image,txtSinopsis.Text,precio, libroPdfBytes);
                        resultado = l1.AgregarLibro(basedatos.Conexion, l1);
                        this.Close();

                    }
                    else
                    {
                        lblErrores.Text = Idioma.LibroYaExiste;
                    }
                    basedatos.CerrarConexion();
                }
                else
                {
                    MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Idioma.FaltanDatos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pcbLogo_Click(object sender, EventArgs e)
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

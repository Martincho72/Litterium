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

namespace registro_mockup.formularios_administrador
{
    public partial class EditarLibro : Form
    {
        BDatos basedatos=new BDatos();
        public EditarLibro(string isbn)
        {
            InitializeComponent();
            txtIsbn.Text = isbn;
        }

        private void EditarLibro_Load(object sender, EventArgs e)
        {
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
            else { }
            basedatos.CerrarConexion();

        }
        

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
               
                double valoracion;
                Double.TryParse(cmbValoracion.Text, out valoracion);
                double precio;
                Double.TryParse(txtPrecio.Text, out precio);
                Libro l1 = new Libro(txtIsbn.Text, txtTitulo.Text, txtAutor.Text, cmbCategoria.Text, valoracion, pcbPortada.Image, txtSinopsis.Text,precio);
                    Libro.EditarLibro(basedatos.Conexion, l1);
                    this.Close();
                
                
            }
            else { }
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
                MessageBox.Show("No se ha seleccionado imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbPortada_Click(object sender, EventArgs e)
        {

        }
    }
}

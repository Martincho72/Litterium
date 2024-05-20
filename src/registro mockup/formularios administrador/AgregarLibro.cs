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
    public partial class AgregarLibro : Form
    {
        BDatos basedatos = new BDatos();
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
                errorProvider1.SetError(txtIsbn, "Ingresa el Isbn");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtTitulo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTitulo, "Ingresa la Titulo");
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtAutor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtAutor, "Ingresa el Autor");
            }
            else
            {
                errorProvider1.Clear();

            }
           

            return ok;
        }
        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void AgregarLibro_Load(object sender, EventArgs e)
        {
            lblErrores.Text = "";
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
                        Libro l1 = new Libro(txtIsbn.Text, txtTitulo.Text, txtAutor.Text, cmbCategoria.Text, valoracion,pcbPortada.Image,txtSinopsis.Text);
                        resultado = l1.AgregarLibro(basedatos.Conexion, l1);
                        this.Close();

                    }
                    else
                    {
                        lblErrores.Text = "El libro ya existe";
                    }
                    basedatos.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexion");
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por introducir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbValoracion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblErrores_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void lblValoracion_Click(object sender, EventArgs e)
        {

        }

        private void lblAutor_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("No se ha seleccionado imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

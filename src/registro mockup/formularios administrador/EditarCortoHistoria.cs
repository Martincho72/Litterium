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

namespace registro_mockup.formularios_administrador
{
    public partial class EditarCortoHistoria : Form
    {
        BDatos basedatos = new BDatos();
        public EditarCortoHistoria(int id)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
        }

        private void EditarCortoHistoria_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            AplicarIdioma();
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, int.Parse(txtId.Text));
                txtId.Text = ch.Id.ToString();
                txtTitulo.Text = ch.Titulo;
                txtAutor.Text = ch.Autor;
                dtpFechaPublicacion.Value = ch.FechaPublicacion;
                cmbCategoria.Text = ch.Categoria;
                txtIdUsuario.Text = ch.Id_usuario.ToString();
                chbContinuable.Checked = ch.Continuable;
                chbFinalizada.Checked = ch.Finalizada;
                pcbPortada.Image = ch.Portada;
                txtTexto.Text = ch.Texto;
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();

        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloEditarCortohistoria;
            lblMensaje.Text = Idioma.lblTituloEditarCortohistoria;
            lblId.Text = Idioma.lblIdEditarCortohistoria;
            lblTitulo.Text = Idioma.lblTituloEditarCortohistoria;
            lblAutor.Text = Idioma.lblAutorEditarCortohistoria;
            lblFechaPublicacion.Text = Idioma.lblFechaPublicacionEditarCortohistoria;
            lblCategoria.Text = Idioma.lblCategoriaEditarCortohistoria;
            lblIdUsuario.Text = Idioma.lblIdUsuarioEditarCortohistoria;
            chbFinalizada.Text = Idioma.chbFinalizadaEditarCortohistoria;
            chbContinuable.Text = Idioma.chbContinuableEditarCortohistoria;
            btnCargar.Text = Idioma.btnCargarImagenCortohistoria;
            btnEditar.Text = Idioma.btnEditarCortohistoria;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                CortoHistoria corto = new CortoHistoria(int.Parse(txtId.Text), txtTitulo.Text, txtAutor.Text, dtpFechaPublicacion.Value, cmbCategoria.Text, chbContinuable.Checked, chbFinalizada.Checked, int.Parse(txtIdUsuario.Text), pcbPortada.Image,txtTexto.Text);
                CortoHistoria.EditarCortoHistoria(basedatos.Conexion, corto);
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
    }
}

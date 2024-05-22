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
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, int.Parse(txtId.Text));
                txtId.Text = ch.Id.ToString();
                txtTitulo.Text = ch.Titulo;
                txtAutor.Text = ch.Autor;
                dtpFechaPublicacion.Value = ch.FechaPublicacion;
                txtCategoria.Text = ch.Categoria;
                txtValoracion.Text = ch.Valoracion.ToString();
                txtIdUsuario.Text = ch.Id_usuario.ToString();
                chbContinuable.Checked = ch.Continuable;
                chbFinalizada.Checked = ch.Finalizada;
                pcbPortada.Image = ch.Portada;

            }
            else { }
            basedatos.CerrarConexion();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                CortoHistoria corto = new CortoHistoria(int.Parse(txtId.Text), txtTitulo.Text, txtAutor.Text, dtpFechaPublicacion.Value, txtCategoria.Text, chbContinuable.Checked, chbFinalizada.Checked, double.Parse(txtValoracion.Text), int.Parse(txtIdUsuario.Text), pcbPortada.Image);
                CortoHistoria.EditarCortoHistoria(basedatos.Conexion, corto);
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
    }
}

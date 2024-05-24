using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using registro_mockup.Idiomas;

namespace registro_mockup.formularios_administrador
{
    public partial class EditarUsuario : Form
    {
        BDatos basedatos = new BDatos();
        public EditarUsuario(string usu)
        {
            InitializeComponent();
            txtUsuario.Text = usu;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
            Usuario usuario = new Usuario(txtUsuario.Text, txtContraseña.Text, chbAdmin.Checked, txtNombre.Text, txtCorreo.Text, txtDireccion.Text, int.Parse(txtTelefono.Text), chbVetado.Checked, chbBaja.Checked,pcbImagen.Image);
            Usuario.EditarUsuario(basedatos.Conexion, usuario);
            this.Close();
            }
            else { }
            basedatos.CerrarConexion();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            lblError.Text = "";

            if (basedatos.AbrirConexion())
            {
                Usuario usuario = Usuario.EncontrarDatosUsuario(basedatos.Conexion, txtUsuario.Text);
                txtTelefono.Text = usuario.Telefono.ToString();
                txtNombre.Text = usuario.Nombre;
                txtDireccion.Text = usuario.Direccion;
                txtCorreo.Text = usuario.Correo;
                txtContraseña.Text = usuario.Clave;
                chbAdmin.Checked = usuario.EsAdmin;
                chbBaja.Checked = usuario.Baja;
                chbVetado.Checked = usuario.Vetado;
                pcbImagen.Image = usuario.Foto;
            }
            else { }
            basedatos.CerrarConexion();
        }
        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloEditarUsuario;
            lblNombre.Text = Idioma.lblNombreEditarUsuario;
            lblDireccion.Text = Idioma.lblDireccionEditarUsuario;
            lblCorreo.Text = Idioma.lblCorreoEditarUsuario;
            lblTelefono.Text = Idioma.lblTelefonoEditarUsuario;
            lblUsuario.Text = Idioma.lblUsuarioEditarUsuario;
            lblContraseña.Text = Idioma.lblContrasenyaEditarUsuario;
            lblMensajeEditarUsuario.Text = Idioma.lblMensajeEditarUsuario;
            
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargaImagen = new OpenFileDialog();
            cargaImagen.InitialDirectory = "C:\\";
            cargaImagen.Filter = "JPG (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (cargaImagen.ShowDialog() == DialogResult.OK)
            {
                pcbImagen.ImageLocation = cargaImagen.FileName;
                MessageBox.Show(cargaImagen.FileName);
            }
            else
            {
                MessageBox.Show(Idioma.ImagenNoSeleccionada, Idioma.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

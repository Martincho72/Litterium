using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_mockup.formularios_Usuario
{
    public partial class MiCuenta : Form
    {
        private string usuariomenu;
        BDatos basedatos = new BDatos();
        public MiCuenta(string usuario)

        {
            usuariomenu = usuario;
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargaImagen = new OpenFileDialog();
            cargaImagen.InitialDirectory = "C:\\";
            cargaImagen.Filter = "JPG (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (cargaImagen.ShowDialog() == DialogResult.OK)
            {
                pcbPerfil.ImageLocation = cargaImagen.FileName;
                MessageBox.Show(cargaImagen.FileName);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MiCuenta_Load(object sender, EventArgs e)
        {
            txtContraEditar.Visible = false;
            txtCorreoEditar.Visible = false;
            txtNombreEditar.Visible = false;
            txtUsuarioEditar.Visible = false;
            txtDireccionEditar.Visible = false;
            txtTelefonoEditar.Visible = false;
            btnConfirmarEdicion.Visible = false;

            if (basedatos.AbrirConexion())
            {
                Usuario usuario = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usuariomenu);
                txtUsuario.Text = usuariomenu;
                txtTelefono.Text = usuario.Telefono.ToString();
                txtNombre.Text = usuario.Nombre;
                txtDireccion.Text = usuario.Direccion;
                txtCorreo.Text = usuario.Correo;
                txtContra.Text = usuario.Clave;
                pcbPerfil.Image = usuario.Foto;
            }
            else { }
            basedatos.CerrarConexion();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtContraEditar.Visible = true;
            txtCorreoEditar.Visible = true;
            txtNombreEditar.Visible = true;
            txtUsuarioEditar.Visible = true;
            txtDireccionEditar.Visible = true;
            txtTelefonoEditar.Visible = true;
            btnConfirmarEdicion.Visible = true;
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                Usuario usuario = new Usuario(txtUsuarioEditar.Text, txtContraEditar.Text, txtNombreEditar.Text, txtCorreoEditar.Text, txtDireccionEditar.Text, pcbPerfil.Image);
                Usuario.EditarUsuarioPerfil(basedatos.Conexion, usuario);
                this.Close();
            }
            else { }
            basedatos.CerrarConexion();
        }
    }
}

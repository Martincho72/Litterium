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

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
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
            }
            else { }
            basedatos.CerrarConexion();


        }
    }
}

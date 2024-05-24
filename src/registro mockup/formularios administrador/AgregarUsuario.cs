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
    public partial class AgregarUsuario : Form
    {   BDatos basedatos = new BDatos();
        public AgregarUsuario()
        {
            InitializeComponent();
            
        }
        private bool ValidarDatos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, Idioma.errorProviderNombreRegistro);
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, Idioma.errorProviderDireccionRegistro);
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtCorreo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCorreo, Idioma.errorProviderCorreoRegistro);
            }
            if (txtTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTelefono, Idioma.errorProviderTelefonoRegistro);
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, Idioma.errorProviderUsuarioRegistro);
            }
            if (txtContraseña.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContraseña, Idioma.errorProviderContrasenyaRegistro);
            }
            return ok;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            if (ValidarDatos())
            {
                if (basedatos.AbrirConexion())
                {
                    if (!Usuario.EncontrarUsuario(basedatos.Conexion, txtUsuario.Text))
                    {
                        int telefono = Convert.ToInt32(txtTelefono.Text);
                        Usuario us1 = new Usuario(txtUsuario.Text, txtContraseña.Text,chbAdmin.Checked, txtNombre.Text, txtCorreo.Text, txtDireccion.Text, telefono);
                        resultado = us1.AgregarUsuario(basedatos.Conexion, us1);
                        
                        this.Close();

                    }
                    else
                    {
                        lblErrores.Text = Idioma.UsuarioYaExisteRegistro;
                    }
                    basedatos.CerrarConexion();
                }
                else
                {
                    MessageBox.Show(Idioma.ConexionFallida);
                }
            }
            else
            {
                MessageBox.Show(Idioma.FaltanDatos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            MenuAdministrador form = new MenuAdministrador();
            form.Hide();
            form.Show();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloAgregarUsuario;
            lblMensaje.Text = Idioma.lblMensajeAgregarUsuario;
            lblNombre.Text = Idioma.lblNombreAgregarUsuario;
            lblDireccion.Text = Idioma.lblDireccionAgregarUsuario;
            lblCorreo.Text = Idioma.lblCorreoAgregarUsuario;
            lblTelefono.Text = Idioma.lblTelefonoAgregarUsuario;
            lblUsuario.Text = Idioma.lblUsuarioAgegarUsuario;
            lblContraseña.Text = Idioma.lblContrasena;
            chbAdmin.Text = Idioma.chbAdminAgregarUsuario;
            btnCrear.Text = Idioma.btnCrearAgregarUsuario;

        }
    }
}

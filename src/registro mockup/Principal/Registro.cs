using registro_mockup;
using registro_mockup.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Litterium
{
    public partial class Registro : Form
    {
        BDatos basedatos = new BDatos();
        public Registro()
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
            if (txtUsuario.Text=="")
            {
                ok=false;
                errorProvider1.SetError(txtUsuario, Idioma.errorProviderUsuarioRegistro);
            }
            if (txtContraseña.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContraseña, Idioma.errorProviderContrasenyaRegistro);
            }
            return ok;
        }

        private void pcbAtras_Click(object sender, EventArgs e)
        {
            FrmLogIn login = new FrmLogIn();
            login.Show();
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
                        Usuario us1 = new Usuario(txtUsuario.Text, txtContraseña.Text, txtNombre.Text, txtCorreo.Text, txtDireccion.Text, telefono);
                        resultado = us1.AgregarUsuario(basedatos.Conexion, us1);

                    }
                    else
                    {
                        MessageBox.Show(Idioma.UsuarioYaExisteRegistro);
                    }
                        basedatos.CerrarConexion();
                }
                else
                {
                    MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Idioma.FaltanDatos,"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloRegistro;
            lblAdministradores.Text = Idioma.lblAdministradores;
            lblDatos.Text = Idioma.lblDatosDeUsuario;
            lblNombre.Text = Idioma.lblNombre;
            lblUsuario.Text = Idioma.lblUsuario;
            lblDireccion.Text = Idioma.lblDireccion;
            lblCorreo.Text = Idioma.lblCorreo;
            lblTelefono.Text = Idioma.lblTelefono;
            lblUsuario.Text = Idioma.lblUsuario;
            lblContraseña.Text = Idioma.lblContrasena;
            btnCrear.Text = Idioma.btnRegistrase;
        }

        private void Registro_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}

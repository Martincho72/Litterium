using registro_mockup;
using registro_mockup.formularios_administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using registro_mockup.Idiomas;
using System.Globalization;
using System.Threading;
using registro_mockup.Properties;

namespace Litterium
{
    public partial class FrmLogIn : Form
    {
        BDatos bDatos = new BDatos();
        public FrmLogIn()
        {
            InitializeComponent();
            this.ControlBox = false;

        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloLogin;
            lblUsuario.Text = Idioma.lblUsuario;
            lblTextoRegistrase.Text = Idioma.lblTextoRegistrase;
            lblRegistrase.Text = Idioma.lblRegistrase;
            lblMensajesError.Text = Idioma.lblMensajesError;
            lblContrasenaOlvidada.Text = Idioma.lblContrasenaOlvidada;
            lblContrasena.Text = Idioma.lblContrasena;
            btnIogin.Text = Idioma.btnLogin;

            string idiomaActual = Thread.CurrentThread.CurrentUICulture.Name;

            if (idiomaActual == "es-ES")
            {
                pcbIdioma.Image = Resources.espanol;
            }
            else
            {
                pcbIdioma.Image = Resources.english;
            }
            lblMensajesError.Visible = false;
        }

        private bool ValidarDatos()
        {
            bool ok = true;
            if (txtUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, Idioma.errorProviderUsuarioLogIn);
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtClave.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtClave, Idioma.errorProviderContrasenyaLogIn);
            }
            else
            {
                errorProvider1.Clear();

            }
            return ok;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            lblMensajesError.Text = "";
            AplicarIdioma();
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistrase_Click(object sender, EventArgs e)
        {
            if (bDatos.AbrirConexion())
            {
                Registro registro = new Registro();
                registro.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bDatos.CerrarConexion();



        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIogin_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (bDatos.AbrirConexion())
                {
                    if (Usuario.EncontrarUsuario(bDatos.Conexion, txtUsuario.Text))
                    {
                        if (Usuario.validarContrasenya(bDatos.Conexion, txtUsuario.Text, txtClave.Text))
                        {
                            if (Usuario.esAdmintrador(bDatos.Conexion, txtUsuario.Text))
                            {
                                if (!Usuario.comprobarBaja(bDatos.Conexion, txtUsuario.Text))
                                {
                                    MenuAdministrador admin = new MenuAdministrador(this);
                                    admin.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("El administrador esta de baja");
                                }
                            }
                            else
                            {
                                if (!Usuario.comprobarVetado(bDatos.Conexion, txtUsuario.Text))
                                {
                                    MenuPrincipal menu = new MenuPrincipal(txtUsuario.Text);
                                    menu.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("El usuario esta vetado");
                                }

                            }
                            txtUsuario.Text = "";
                            txtClave.Text = "";
                        }
                        else
                        {
                            lblMensajesError.Text = Idioma.ContrasenyaIncorrectaLogin;
                            lblMensajesError.Visible = true;
                        }
                    }
                    else
                    {
                        lblMensajesError.Text = Idioma.UsuarioNoExisteLogin;
                        lblMensajesError.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bDatos.CerrarConexion();
            }
        }

        private void lblMensajesError_Click(object sender, EventArgs e)
        {

        }

        private void lblContrasenaOlvidada_Click(object sender, EventArgs e)
        {
            ContrasenyaOlvidada contra = new ContrasenyaOlvidada();
            contra.Show();
            this.Hide();
        }

        private void pcbIdioma_Click(object sender, EventArgs e)
        {
            string idiomaActual = Thread.CurrentThread.CurrentUICulture.Name;
            string cultura = "";

            if (idiomaActual == "es-ES")
            {
                cultura = "en-GB";
                pcbIdioma.Image = Resources.english;
            }
            else if (idiomaActual == "en-GB")
            {
                cultura = "es-ES";
                pcbIdioma.Image = Resources.espanol;
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();

        }
    }
}

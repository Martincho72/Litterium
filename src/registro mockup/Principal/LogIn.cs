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
            this.Text = LogIn.TituloLogin;
            lblUsuario.Text = LogIn.lblUsuario;
            lblTextoRegistrase.Text = LogIn.lblTextoRegistrase;
            lblRegistrase.Text = LogIn.lblRegistrase;
            lblMensajesError.Text = LogIn.lblMensajesError;
            lblContrasenaOlvidada.Text = LogIn.lblContrasenaOlvidada;
            lblContrasena.Text = LogIn.lblContrasena;
            btnIogin.Text = LogIn.btnLogin;

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
                errorProvider1.SetError(txtUsuario, "Ingresa el Usuario");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtClave.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtClave, "Ingresa la contraseña");
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
                                MenuAdministrador admin = new MenuAdministrador(this);
                                admin.Show();
                                txtUsuario.Text = "";
                                txtClave.Text = "";
                                this.Hide();
                            }
                            else
                            {
                                MenuPrincipal menu = new MenuPrincipal(txtUsuario.Text);
                                menu.Show();
                                this.Hide();

                            }
                        }
                        else
                        {
                            if (Thread.CurrentThread.CurrentUICulture.Name == "es-ES")
                            {
                                lblMensajesError.Text = "Contraseña incorrecta";
                            }
                            else
                            {
                                lblMensajesError.Text = "Incorrect Password";
                            }
                            lblMensajesError.Visible = true;
                        }
                    }
                    else
                    {
                        if (Thread.CurrentThread.CurrentUICulture.Name == "es-ES")
                        {
                            lblMensajesError.Text = "El usuario no existe";
                            lblMensajesError.Visible = true;
                        }
                        else
                        {
                            lblMensajesError.Text = "User doesn't exist";
                        }
                        lblMensajesError.Visible = true;
                    }
                    bDatos.CerrarConexion();
                }
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

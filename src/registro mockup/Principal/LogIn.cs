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

namespace Litterium
{
    public partial class FrmLogIn : Form
    {
        BDatos bDatos = new BDatos();
        public FrmLogIn()
        {
            InitializeComponent();
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
                if(bDatos.AbrirConexion())
                {
                    if(Usuario.EncontrarUsuario(bDatos.Conexion,txtUsuario.Text))
                    {
                        if (Usuario.validarContrasenya(bDatos.Conexion,txtUsuario.Text, txtClave.Text))
                        {
                            if(Usuario.esAdmintrador(bDatos.Conexion,txtUsuario.Text)) 
                            {
                                MenuAdministrador admin = new MenuAdministrador();
                                admin.Show();
                                this.Hide();
                            }
                            else
                            {
                                MenuPrincipal menu = new MenuPrincipal();
                                menu.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            lblMensajesError.Text = "La contraseña no existe";
                        }
                    }
                    else
                    {
                        lblMensajesError.Text = "El usuario no existe";
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
    }
}

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
                errorProvider1.SetError(txtNombre, "Ingresa el Nombre");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Ingresa la Direccion");
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtCorreo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCorreo, "Ingresa el Correo");
            }
            if (txtTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTelefono, "Ingresa el Telefono");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, "Ingresa el Usuario");
            }
            if (txtContraseña.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContraseña, "Ingresa la contraseña");
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
                        lblErrores.Text = "El usuario ya existe";
                    }
                    basedatos.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexion");
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por introducir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            MenuPrincipal form = new MenuPrincipal();
            form.Hide();
            form.Show();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            lblErrores.Text = "";
        }


    }
}

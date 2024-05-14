using registro_mockup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Form1_Load(object sender, EventArgs e)
        {

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
            if (txtUsuario.Text=="")
            {
                ok=false;
                errorProvider1.SetError(txtUsuario, "Ingresa el Usuario");
            }
            if (txtContraseña.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContraseña, "Ingresa la contraseña");
            }
            return ok;
        }

        private void pcbAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int resultaado = 0;
            if (ValidarDatos())
            {
                if (Usuario.EncontrarUsuario(basedatos.Conexion, txtUsuario.Text))
                {
                    Usuario us1 = new Usuario();
                    resultaado = us1.AgregarUsuario(basedatos.Conexion, us1);
                    FrmLogIn login = new FrmLogIn();
                    login.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por introducir","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}

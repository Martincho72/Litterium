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
    public partial class EliminarUsuario : Form
    {
        BDatos basedatos=new BDatos();
        public EliminarUsuario()
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
            return ok;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            if (ValidarDatos())
            {
                if (basedatos.AbrirConexion())
                {
                    if (Usuario.EncontrarUsuario(basedatos.Conexion, txtUsuario.Text))
                    {

                        Usuario.eliminarUsuario(basedatos.Conexion, txtUsuario.Text);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("El usuario ya existe");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

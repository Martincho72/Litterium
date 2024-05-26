using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Ocsp;
using registro_mockup.Idiomas;

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
                errorProvider1.SetError(txtUsuario, Idioma.errorProviderAutor);
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
                        lblErrores.Text = Idioma.NoExisteUsuario;
                    }
                    basedatos.CerrarConexion();
                }
                else
                {
                    MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Idioma.FaltanDatos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloEliminarUsuario;
            lblMensaje.Text = Idioma.lblMensajeEliminarUsuario;
            lblUsuario.Text = Idioma.lblUsuarioEliminarUsuario;
            btnEliminar.Text = Idioma.btnEliminarUsuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            lblErrores.Text = "";
        }
    }
}

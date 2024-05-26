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
    public partial class BuscarUsuario : Form
    {
        BDatos basedatos = new BDatos();
        public BuscarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                if (Usuario.EncontrarUsuario(basedatos.Conexion, txtUsuario.Text))
                {
                    EditarUsuario editarUsuario = new EditarUsuario(txtUsuario.Text);
                    editarUsuario.ShowDialog();
                }
                else
                {
                    lblErrores.Text = Idioma.NoExisteUsuario;
                }
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarUsuario_Load(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloBuscarUsuario;
            lblMensaje.Text = Idioma.lblMensajeBuscarUsuario;
            lblUsuario.Text = Idioma.lblUsuarioBuscarUsuario;
            btnBuscar.Text = Idioma.btnBuscarUsuario;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

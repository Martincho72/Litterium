using registro_mockup.clases;
using registro_mockup.Idiomas;
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
    public partial class BuscarCortoHistoria : Form
    {
        BDatos basedatos = new BDatos();
        public BuscarCortoHistoria()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                if (CortoHistoria.EncontrarCortoHistoria(basedatos.Conexion, int.Parse(txtId.Text)))
                {
                    EditarCortoHistoria form = new EditarCortoHistoria(int.Parse(txtId.Text));
                    form.ShowDialog();
                }
                else
                {
                    
                    lblErrores.Text = Idioma.NoExisteID;
                }
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloBuscarCortohistoria;
            lblMensaje.Text = Idioma.lblMensajeBuscarCortohistoria;
            lblId.Text = Idioma.lblIdBuscarCortohistoria;
            btnBuscar.Text = Idioma.btnBuscarCortohistoria;
        }

        private void BuscarCortoHistoria_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            lblErrores.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

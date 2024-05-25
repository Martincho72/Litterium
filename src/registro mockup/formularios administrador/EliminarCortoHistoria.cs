using registro_mockup.clases;
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
    public partial class EliminarCortoHistoria : Form
    {
        BDatos basedatos=new BDatos();
        public EliminarCortoHistoria()
        {
            InitializeComponent();
        }

        private bool ValidarDatos()
        {
            bool ok = true;

            if (txtId.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtId, Idioma.errorProviderID);
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
                    int id;
                    int.TryParse(txtId.Text, out id);
                    if (CortoHistoria.EncontrarCortoHistoria(basedatos.Conexion, id))
                    {
                       resultado = CortoHistoria.eliminarCortoHistoria(basedatos.Conexion, id);
                        this.Close();
                    }
                    else
                    {
                        lblErrores.Text = Idioma.NoExisteID;
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
                MessageBox.Show(Idioma.ImagenNoSeleccionada, Idioma.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EliminarCortoHistoria_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            lblErrores.Text = "";
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloEliminarCortohistoria;
            lblMensaje.Text = Idioma.lblMensajeEliminarCortohistoria;
            lblId.Text = Idioma.lblIdEliminarCortohistoria;
            btnEliminar.Text = Idioma.btnEliminarCortohistoria;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

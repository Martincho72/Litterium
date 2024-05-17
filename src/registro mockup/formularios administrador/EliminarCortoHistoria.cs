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
                errorProvider1.SetError(txtId, "Ingresa el Id");
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
                        lblErrores.Text = "El ID no existe";
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

        private void EliminarCortoHistoria_Load(object sender, EventArgs e)
        {

        }
    }
}

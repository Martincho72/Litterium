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
    public partial class EliminarLibro : Form
    {
        BDatos basedatos= new BDatos();
        public EliminarLibro()
        {
            InitializeComponent();
        }
        private bool ValidarDatos()
        {
            bool ok = true;

            if (txtIsbn.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIsbn, "Ingresa el ISBN");
            }
            else
            {
                errorProvider1.Clear();
            }
            return ok;
        }
        private void EliminarLibro_Load(object sender, EventArgs e)
        {
            lblErrores.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            if (ValidarDatos())
            {
                if (basedatos.AbrirConexion())
                {
                    if (Libro.EncontrarLibro(basedatos.Conexion,txtIsbn.Text))
                    {
                        
                        resultado=Libro.eliminarLibro(basedatos.Conexion, txtIsbn.Text);

                        this.Close();

                    }
                    else
                    {
                        lblErrores.Text = "El ISBN no existe";
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

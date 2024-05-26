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
using Org.BouncyCastle.Asn1.Ocsp;

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
                errorProvider1.SetError(txtIsbn, Idioma.errorProviderIsbn);
            }
            else
            {
                errorProvider1.Clear();
            }
            return ok;
        }
        private void EliminarLibro_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
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
                        lblErrores.Text = Idioma.NoExisteID;
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
            this.Text = Idioma.TituloEliminarLibro;
            lblMensaje.Text = Idioma.lblMensajeEliminarLibro;
            lblIsbn.Text = Idioma.lblIsbnEliminarLibro;
            btnEliminar.Text = Idioma.btnEliminarLibro;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

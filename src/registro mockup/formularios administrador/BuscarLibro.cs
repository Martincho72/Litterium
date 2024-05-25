using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class BuscarLibro : Form
    {
        BDatos basedatos=new BDatos();
        public BuscarLibro()
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

            private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                if (ValidarDatos())
                {
                    if (Libro.EncontrarLibro(basedatos.Conexion, txtIsbn.Text))
                    {
                        EditarLibro form = new EditarLibro(txtIsbn.Text);
                        form.ShowDialog();
                    }
                    else
                    {
                        lblErrores.Text = Idioma.NoExisteISBN;
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos por introducir!");
                }
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void BuscarLibro_Load(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloBuscarLibro;
            lblMensaje.Text = Idioma.lblMensajeBuscarLibro;
            lblIsbn.Text = Idioma.lblIsbnBuscarLibro;
            btnBuscar.Text = Idioma.btnBuscarLibro;
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

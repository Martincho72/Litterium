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

namespace registro_mockup.Principal
{
    public partial class MiCarrito : Form
    {
        string usuario;
        BDatos basedatos = new BDatos();
        public MiCarrito(string usu)
        {
            InitializeComponent();
            usuario = usu;
            
        }

        private void MiCarrito_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            if (basedatos.AbrirConexion())
            {
                double total = 0;
                foreach (Libro libro in Carrito.MiCarrito)
                {
                    
                    dgvMiCarrito.Rows.Add(libro.Isbn, libro.Titulo, libro.Autor, libro.Categoria, libro.Valoracion, libro.Precio,libro.Cantidad,libro.Online);
                    total += libro.importeTotal(libro.Precio, libro.Cantidad);
                }
                lblImporteTotal.Text += total.ToString() + "€";
            }
            basedatos.CerrarConexion();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloMiCarrito;
            lblImporteTotal.Text = Idioma.lblImporteTotal;
            btnPagar.Text = Idioma.btnPagarComprar;
        }

        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            Comprar form = new Comprar(usuario);
            form.ShowDialog();
        }
    }
}

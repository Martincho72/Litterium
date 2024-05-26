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
            CargarCarrito();
        }

        private void CargarCarrito()
        {
            double total = 0;
            foreach (Libro libro in Carrito.MiCarrito)
            {

                dgvMiCarrito.Rows.Add(libro.Isbn, libro.Titulo, libro.Autor, libro.Categoria, libro.Valoracion, libro.Precio, libro.Cantidad, libro.Online);
                total += libro.importeTotal(libro.Precio, libro.Cantidad);
            }
            lblImporteTotal.Text = Idioma.lblImporteMiCarrito + total.ToString() + "€";
        }

        private void LimpiarTabla()
        {
            dgvMiCarrito.Rows.Clear();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloMiCarrito;
            lblImporteTotal.Text = Idioma.lblImporteTotal;
            btnPagar.Text = Idioma.btnPagarComprar;
        }

        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            if (dgvMiCarrito.Rows.Count >= 1)
            {
                Comprar form = new Comprar(usuario);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show(Idioma.MensajeCarritoVacio, Idioma.InfoCarrito, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvMiCarrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (basedatos.AbrirConexion())
            {
                DialogResult dialogResult = MessageBox.Show(Idioma.AlertaMiCarrito, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Libro libro = Libro.EncontrarDatosLibro(basedatos.Conexion, dgvMiCarrito.Rows[indice].Cells[0].ToString());
                    Carrito.borrarDelCarrito(indice);
                    LimpiarTabla();
                    CargarCarrito();
                }
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }
    }
}

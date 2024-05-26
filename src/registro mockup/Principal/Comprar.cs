using registro_mockup.clases;
using registro_mockup.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_mockup.Principal
{
    public partial class Comprar : Form
    {
        BDatos basedatos = new BDatos();
        private string usuariomenu;
        private string isbnLibro;
        private bool online = false;
        private bool comprarAhora = false;
        private Form previousForm;
        public Comprar(string usuario)
        {
            InitializeComponent();
            AplicarIdioma();
            usuariomenu = usuario;
            txtUsuario.Text = usuario;
            if (basedatos.AbrirConexion())
            {
                double total = 0;
                foreach (Libro libro in Carrito.MiCarrito)
                {
                    dgvResumen.Rows.Add(libro.Isbn, libro.Titulo, libro.Autor, libro.Categoria, libro.Valoracion, libro.Precio, libro.Cantidad, libro.Online);
                    total += libro.importeTotal(libro.Precio, libro.Cantidad);
                }
                lblImporteTotal.Text += total.ToString() + "€";
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        public Comprar(string isbn, string usuario, int cantidad, bool fisico, Form form)
        {
            InitializeComponent();
            AplicarIdioma();
            comprarAhora = true;
            usuariomenu = usuario;
            isbnLibro = isbn;
            previousForm = form;
            if (basedatos.AbrirConexion())
            {
                Libro libro = Libro.EncontrarDatosLibro(basedatos.Conexion, isbnLibro);
                txtUsuario.Text = usuario;

                if (fisico)
                {
                    libro.Online = false;
                }
                else
                {
                    libro.Online = true;
                }
                libro.Cantidad = cantidad;
                dgvResumen.Rows.Add(libro.Isbn, libro.Titulo, libro.Autor, libro.Categoria, libro.Valoracion, libro.Precio, libro.Cantidad, libro.Online);
                lblImporteTotal.Text += libro.importeTotal(libro.Precio, cantidad).ToString() + "€";
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                if (ValidarDatos())
                {
                    if (!comprarAhora)
                    {
                        foreach (Libro l1 in Carrito.MiCarrito)
                        {
                            Usuario us1 = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usuariomenu);
                            Ejemplar ej1 = new Ejemplar(DateTime.Now, (decimal)l1.importeTotal(l1.Precio, l1.Cantidad), l1.Online, us1.Id, l1.Isbn);
                            Ejemplar.AgregarEjemplar(basedatos.Conexion, ej1);

                        }
                        Carrito.MiCarrito.Clear();
                    }
                    else
                    {
                        Libro libro = new Libro();
                        DataGridViewRow filaSeleccionada = dgvResumen.Rows[0];

                        // Asignar los valores de la fila a las propiedades del objeto libro
                        libro.Isbn = filaSeleccionada.Cells["ISBN"].Value.ToString();
                        libro.Titulo = filaSeleccionada.Cells["Titulo"].Value.ToString();
                        libro.Autor = filaSeleccionada.Cells["Autor"].Value.ToString();
                        libro.Categoria = filaSeleccionada.Cells["Categoria"].Value.ToString();
                        libro.Valoracion = Convert.ToInt32(filaSeleccionada.Cells["Valoracion"].Value);
                        libro.Precio = Convert.ToDouble(filaSeleccionada.Cells["Precio"].Value);
                        libro.Cantidad = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);
                        libro.Online = Convert.ToBoolean(filaSeleccionada.Cells["Tipo"].Value);
                        Usuario us1 = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usuariomenu);
                        Ejemplar ej1 = new Ejemplar(DateTime.Now, (decimal)libro.importeTotal(libro.Precio, libro.Cantidad), libro.Online, us1.Id, libro.Isbn);
                        Ejemplar.AgregarEjemplar(basedatos.Conexion, ej1);
                    }
                    MessageBox.Show(Idioma.compraRealizada, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloComprar;
            lblTitulo.Text = Idioma.lblTituloComprar;
            lblUsuario.Text = Idioma.lblUsuario;
            lblImporteTotal.Text = Idioma.lblImporteTotal;
            lblUbicacionEntrega.Text = Idioma.lblUbicacionEntrega;
            lblDatosDeTarjeta.Text = Idioma.lblDatosDeTarjeta;
            lblNumeroTarjeta.Text = Idioma.lblNumeroTarjeta;
            lblCCV.Text = Idioma.lblCCV;
            lblFechaCaducidad.Text = Idioma.lblFechaCaducidad;
            btnPagar.Text = Idioma.btnPagarComprar;
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            dtpFechaCaducidad.MinDate = DateTime.Today;
        }

        private bool ValidarDatos()
        {
            bool ok = true;
            if (txtCCV.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCCV, Idioma.errorProviderCCV);
            }
            else
            {
                errorProvider1.Clear();

            }

            if (txtNumeroTarjeta.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNumeroTarjeta, Idioma.errorProviderNumeroTarjeta);
            }
            else
            {
                errorProvider1.Clear();

            }

            if (txtUbicacionEntrega.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUbicacionEntrega, Idioma.errorProviderUbicacionEntrega);
            }
            else
            {
                errorProvider1.Clear();

            }

            return ok;
        }
    }
}

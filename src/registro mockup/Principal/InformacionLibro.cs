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
    public partial class InformacionLibro : Form
    {
        BDatos basedatos=new BDatos();
        private string usuariomenu;
        private string isbnLibro;
        public InformacionLibro(string titulo,string usuario)
        {
            InitializeComponent();
            usuariomenu = usuario;
            AplicarIdioma();
            if (basedatos.AbrirConexion())
            {
                Libro l1 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo);
                isbnLibro = l1.Isbn;
                lblAutorLibro.Text +=  l1.Autor;
                lblTituloLibro.Text += l1.Titulo;
                lblValoracion.Text += l1.Valoracion;
                txtSinopsis.Text = l1.Sinopsis;
                pcbPortadaLibro.Image = l1.Portada;
                lblPrecioLibro.Text += l1.Precio + "€";
            }
            basedatos.CerrarConexion();
        }



        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void InformacionLibro_Load(object sender, EventArgs e)
        {
            cmbValorar.SelectedIndex = 4;
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloInformacionLibro;
            lblAutorLibro.Text = Idioma.lblAutorEditarLibro;
            lblTituloLibro.Text = Idioma.lblTituloEditarLibro;
            lblValoracion.Text = Idioma.lblValoracionLibro;
            btnAgreagarAlCarrito.Text = Idioma.btnAñadirCarrito;
            btnComprarAhora.Text = Idioma.btnComprarAhora;
            btnValorar.Text = Idioma.btnValorar;
            lblValoracion.Text = Idioma.lblValoracionLibro;
            lblPrecioLibro.Text = Idioma.lblPrecioAgregarLibro;
            lblComentarios.Text = Idioma.lblComentarios;
            lblSinopsis.Text = Idioma.lblSinopsis;
            lblEjemplares.Text = Idioma.lblEjemplaresLibro;
            rdbCopiaFisica.Text = Idioma.rbtCopiaFisica;
            rdbCopiaOnline.Text = Idioma.rbtCopiaOnline;
            gpbValorarLibro.Text = Idioma.gpbValorarLibro;
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void btnValorar_Click(object sender, EventArgs e)
        {
            
            if (basedatos.AbrirConexion())
            {
                Usuario usu = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usuariomenu);

                if (!Valoracion.EncontrarValoracion(basedatos.Conexion,usu.Id,isbnLibro ))
                {
                    Valoracion.insertarValoracion(basedatos.Conexion,isbnLibro,usu.Id, int.Parse(cmbValorar.Text));

                }
                else
                {
                    Valoracion.EditarValoracion(basedatos.Conexion,usu.Id, isbnLibro, int.Parse(cmbValorar.Text));
                }
                Libro l1 = Libro.EncontrarDatosLibro(basedatos.Conexion, isbnLibro);
                lblValoracion.Text = "Valoracion: " + l1.Valoracion;
            }
            else
            {

            }
            basedatos.CerrarConexion();
        }

        private void rdbCopiaOnline_Click(object sender, EventArgs e)
        {
            nupCantidad.Value = 1;
            nupCantidad.Enabled = false;
        }

        private void rdbCopiaFisica_Click(object sender, EventArgs e)
        {
            nupCantidad.Enabled = true;
        }

        private void btnComprarAhora_Click(object sender, EventArgs e)
        {
            LibroPrincipal menuP = new LibroPrincipal(usuariomenu);
            Comprar form = new Comprar(isbnLibro, usuariomenu, (int)nupCantidad.Value, rdbCopiaFisica.Checked, menuP);
            form.ShowDialog();
        }

        private void btnAgreagarAlCarrito_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                int cantidad = (int)nupCantidad.Value;
                Libro l1 = Libro.EncontrarDatosLibro(basedatos.Conexion, isbnLibro);
                Usuario us1 = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usuariomenu);
                double precio = l1.importeTotal(l1.Precio, (int)nupCantidad.Value);
                bool online = true;
                if (rdbCopiaFisica.Checked) { online = false; }
                l1.Cantidad=cantidad;
                l1.Online=online;

                bool encontrado = false;
                foreach (Libro libro in Carrito.MiCarrito)
                {
                    if (libro.Isbn == l1.Isbn)
                    {
                        libro.Cantidad += l1.Cantidad;
                        encontrado = true;
                    }
                }
                if (!encontrado)
                {
                    Carrito.agregarAlCarrito(l1);
                }
                string idiomaActual = Thread.CurrentThread.CurrentUICulture.Name;
                if (idiomaActual == "es-ES")
                {
                    MessageBox.Show("Artículo añadido al carrito correctamente");
                }
                else
                {
                    MessageBox.Show("Item Added to Cart Successfully");
                }
            }
            else { }
            basedatos.CerrarConexion();
        }
    }
}

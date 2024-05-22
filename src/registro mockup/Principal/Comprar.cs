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

namespace registro_mockup.Principal
{
    public partial class Comprar : Form
    {
        BDatos basedatos = new BDatos();
        private string usuariomenu;
        private string isbnLibro;
        private bool online=false;
        private Form previousForm;
        public Comprar(string usuario)
        {
            InitializeComponent();
            usuariomenu = usuario;
            txtUsuario.Text = usuario;
            if (basedatos.AbrirConexion())
            {
                foreach (Libro libro in Carrito.MiCarrito)
                {
                    dgvResumen.Rows.Add(libro.Isbn, libro.Titulo, libro.Autor, libro.Categoria, libro.Valoracion, libro.Precio,libro.Cantidad,libro.Online);
                }
            }
            basedatos.CerrarConexion();
        }

        public Comprar(string isbn, string usuario, int cantidad, bool fisico, Form form)
        {
            InitializeComponent();
            usuariomenu = usuario;
            isbnLibro = isbn;
            previousForm = form;
            if (basedatos.AbrirConexion())
            {
                List<Libro> lista = Libro.BuscarLibros(basedatos.Conexion, isbnLibro);
                txtUsuario.Text = usuario;
                foreach (Libro libro in lista)
                {
                    string tipo = "Online";
                    if (fisico)
                    {
                        tipo = "Físico";
                    }
                    dgvResumen.Rows.Add(libro.Isbn, libro.Titulo, libro.Autor, libro.Categoria, libro.Valoracion, libro.Precio, cantidad, tipo);
                }
                txtTotal.Text= lista[0].importeTotal(lista[0].Precio, cantidad).ToString();
            }
            else
            {

            }
            basedatos.CerrarConexion();
            if (!fisico) online = true;
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
                foreach (Libro l1 in Carrito.MiCarrito)
                {
                    Usuario us1 = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usuariomenu);
                    Ejemplar ej1 = new Ejemplar(DateTime.Now,(decimal)l1.importeTotal(l1.Precio,l1.Cantidad), l1.Online, us1.Id, l1.Isbn);
                    Ejemplar.AgregarEjemplar(basedatos.Conexion, ej1);
                    
                }
                Carrito.MiCarrito.Clear();
                MessageBox.Show("Compra Realizada con exito!!");
                this.Close();
            }
            else
            {

            }
            basedatos.CerrarConexion();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {

        }
    }
}

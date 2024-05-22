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
        public Comprar()
        {
            InitializeComponent();
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
                decimal total;
                Decimal.TryParse(txtTotal.Text, out total);
                Libro l1 = Libro.EncontrarDatosLibro(basedatos.Conexion, isbnLibro);
                Usuario us1 = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usuariomenu);
                Ejemplar ej1 = new Ejemplar(DateTime.Now,total,online,us1.Id, isbnLibro);
                Ejemplar.AgregarEjemplar(basedatos.Conexion,ej1);
                MessageBox.Show("Compra Realizada con exito!!");
                this.Close();
            }
            else
            {

            }
        }

        private void Comprar_Load(object sender, EventArgs e)
        {

        }
    }
}

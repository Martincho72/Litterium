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
        public Comprar()
        {
            InitializeComponent();
        }

        public Comprar(string isbn, string usuario, int cantidad)
        {
            InitializeComponent();
            if (basedatos.AbrirConexion())
            {
                List<Libro> lista = Libro.BuscarLibros(basedatos.Conexion, isbn);
                txtUsuario.Text = usuario;
                dgvResumen.DataSource = lista;
                lblImporteTotal.Text = "Total: " + lista[0].importeTotal(lista[0].Precio, cantidad) + "€";
            }
            else
            {

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
    }
}

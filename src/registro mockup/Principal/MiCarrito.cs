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
            if (basedatos.AbrirConexion())
            {
                foreach (Libro libro in carrito.MiCarrito)
                {
                    
                    dgvMiCarrito.Rows.Add(libro.Isbn, libro.Titulo, libro.Autor, libro.Categoria, libro.Valoracion, libro.Precio,libro.Cantidad,libro.Online);
                }
            }
            basedatos.CerrarConexion();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

            Comprar form = new Comprar(usuario);
            form.ShowDialog();
            
        }
    }
}

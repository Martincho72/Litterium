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
    public partial class AdministracionLibro : Form
    {
        BDatos bDatos = new BDatos();
        public AdministracionLibro()
        {
            InitializeComponent();
        }

        private void dgvLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdministracionLibro_Load(object sender, EventArgs e)
        {
            CargaLibros();
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloAdministracionLibro;
            btnAgregarLibro.Text = Idioma.btnAgregarLibroAdmin;
            btnEliminarLibro.Text = Idioma.btnEliminarLibroAdmin;
            btnEditarLibro.Text = Idioma.btnEditarLibroAdmin;
        }

        private void CargaLibros()
        {
            if (bDatos.AbrirConexion())
            {
                
                dgvLibro.DataSource = Libro.BuscarLibros(bDatos.Conexion);
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bDatos.CerrarConexion();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            AgregarLibro form = new AgregarLibro();
            form.ShowDialog();

            CargaLibros();
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            EliminarLibro form = new EliminarLibro();
            form.ShowDialog();

            CargaLibros();
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            BuscarLibro form = new BuscarLibro();
            form.ShowDialog();

            CargaLibros();
        }
    }
}

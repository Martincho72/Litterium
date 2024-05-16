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
        }

        private void CargaLibros()
        {
            if (bDatos.AbrirConexion())
            {
                
                dgvLibro.DataSource = Libro.BuscarLibros(bDatos.Conexion);
            }
            else { }
            bDatos.CerrarConexion();
        }
    }
}

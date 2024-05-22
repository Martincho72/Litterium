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

namespace registro_mockup.formularios_Usuario
{
    public partial class HistorialCompras : Form
    {
        BDatos bDatos = new BDatos();
        private string usuariomenu;

        public HistorialCompras(string usuario)
        {
            usuariomenu = usuario;
            InitializeComponent();
        }
        private void CargaCompras()
        {
            try
            {
                if (bDatos.AbrirConexion())
                {
                    int idUsuario = Usuario.ObtenerID(bDatos.Conexion, usuariomenu);
                    dgvHistorialCompras.DataSource = Ejemplar.BuscarEjemplares(bDatos.Conexion, idUsuario);
                }
            }
            finally
            {
                bDatos.CerrarConexion();
            }
        }



        private void HistorialCompras_Load_1(object sender, EventArgs e)
        {
            CargaCompras();
        }
    }
}

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

namespace registro_mockup
{
    public partial class Misborradores : Form
    {
        BDatos bDatos = new BDatos();
        private string usuariomenu;

        public Misborradores(string usuario)
        {
            InitializeComponent();
            usuariomenu = usuario;
        }
            private void CargaBorradores()
            {
                try
                {
                    if (bDatos.AbrirConexion())
                    {
                        int idUsuario = Usuario.ObtenerID(bDatos.Conexion, usuariomenu);
                        dgvBorradores.DataSource = CortoHistoria.BuscarBorradores(bDatos.Conexion, idUsuario);
                    }
                }
                finally
                {
                    bDatos.CerrarConexion();
                }
            }
        

        private void Misborradores_Load(object sender, EventArgs e)
        {
            CargaBorradores();
        }
    }
}

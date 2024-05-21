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
    public partial class MisLibros : Form

        
    {
        private string usuariomenu;
        BDatos bDatos = new BDatos();
        public MisLibros(string usuario)
        {
            usuariomenu = usuario;
            InitializeComponent();
        }

        private void CargaLibros()
        {
            try
            {
                if (bDatos.AbrirConexion())
                {
                    int idUsuario = Usuario.ObtenerID(bDatos.Conexion, usuariomenu);
                  //  dgvBorradores.DataSource = CortoHistoria.BuscarLibros(bDatos.Conexion, idUsuario);
                }
            }
            finally
            {
                bDatos.CerrarConexion();
            }
        }
    }


}

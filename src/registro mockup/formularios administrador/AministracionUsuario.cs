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
    public partial class AministracionUsuario : Form
    {
        BDatos bDatos = new BDatos();
        public AministracionUsuario()
        {
            InitializeComponent();
        }

        private void CargaUsuarios()
        {
            if (bDatos.AbrirConexion())
            {
                dgvUsuarios.DataSource = Usuario.BuscarUsuarios(bDatos.Conexion);
            }
            else { }
            bDatos.CerrarConexion();
        }

        private void AministracionUsuario_Load(object sender, EventArgs e)
        {
            CargaUsuarios();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}

using registro_mockup.formularios_administrador;
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


        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario form = new AgregarUsuario();
            
            form.ShowDialog();
            
            CargaUsuarios();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario form = new EliminarUsuario();
            form.ShowDialog();

            CargaUsuarios();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

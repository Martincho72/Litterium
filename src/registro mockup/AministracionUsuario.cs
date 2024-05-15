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
                List<Usuario> usuarios = Usuario.BuscarUsuarios(bDatos.Conexion);

                // Iteramos sobre la lista y agregamos cada usuario al DataGridView
                foreach (Usuario usuario in usuarios)
                {
                    // Agregamos una nueva fila al DataGridView
                    int rowIndex = dgvUsuarios.Rows.Add();

                    // Asignamos los valores del usuario a las celdas de la fila
                    dgvUsuarios.Rows[rowIndex].Cells["ID"].Value = usuario.Id;
                    dgvUsuarios.Rows[rowIndex].Cells["Usuario"].Value = usuario.Usu;
                    dgvUsuarios.Rows[rowIndex].Cells["Clave"].Value = usuario.Clave;
                    dgvUsuarios.Rows[rowIndex].Cells["admin"].Value = usuario.EsAdmin;
                    dgvUsuarios.Rows[rowIndex].Cells["Nombre"].Value = usuario.Nombre;
                    dgvUsuarios.Rows[rowIndex].Cells["Correo"].Value = usuario.Correo;
                    dgvUsuarios.Rows[rowIndex].Cells["Direccion"].Value = usuario.Direccion;
                    dgvUsuarios.Rows[rowIndex].Cells["Telefono"].Value = usuario.Telefono;
                    dgvUsuarios.Rows[rowIndex].Cells["Vetado"].Value = usuario.Vetado;
                    dgvUsuarios.Rows[rowIndex].Cells["Baja"].Value = usuario.Baja;
                }
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
    }
}

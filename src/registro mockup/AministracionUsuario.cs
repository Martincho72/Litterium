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
        BDatos bdDatos = new BDatos();
        public AministracionUsuario()
        {
            InitializeComponent();
        }

        private void AministracionUsuario_Load(object sender, EventArgs e)
        {
            
            if (bdDatos.AbrirConexion())
            {   //List<Usuario> lista = new List<Usuario>();
            //    lista= Usuario.CargarUsuarios(bdDatos.Conexion);
                dgvUsuarios.DataSource = Usuario.CargarUsuarios(bdDatos.Conexion);
                //for (int i = 0; i < lista.Count; i++)
                //{
                //    dgvUsuarios.Rows.Add(lista[i]);
                //}
                bdDatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos", "ERROR BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

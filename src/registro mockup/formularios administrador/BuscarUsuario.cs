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
    public partial class BuscarUsuario : Form
    {
        BDatos basedatos = new BDatos();
        public BuscarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                if (Usuario.EncontrarUsuario(basedatos.Conexion, txtUsuario.Text))
                {
                    EditarUsuario editarUsuario = new EditarUsuario(txtUsuario.Text);
                    editarUsuario.ShowDialog();
                }
            }

            else { }
            basedatos.CerrarConexion();
        }
    }
}

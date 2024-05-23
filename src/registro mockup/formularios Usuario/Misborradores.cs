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
                        List<CortoHistoria> borradores = CortoHistoria.BuscarBorradores(bDatos.Conexion, idUsuario);
                    foreach (CortoHistoria cortoHistoria in borradores)
                    {
                        dgvBorradores.Rows.Add(cortoHistoria.Titulo, cortoHistoria.Autor, cortoHistoria.FechaPublicacion.ToString("dd/MM/yyyy"), cortoHistoria.Categoria, cortoHistoria.Continuable, cortoHistoria.Finalizada, cortoHistoria.Portada);

                    }
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

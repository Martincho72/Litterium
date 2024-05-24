using registro_mockup.clases;
using registro_mockup.Idiomas;
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
                    List<CortoHistoria> cortoHistorias = CortoHistoria.BuscarBorradores(bDatos.Conexion, idUsuario);
                    foreach (CortoHistoria ch in cortoHistorias)
                    {
                        dgvBorradores.Rows.Add(ch.Titulo, ch.Autor, ch.FechaPublicacion.ToString("dd/MM/yyyy"), ch.Categoria, ch.Continuable, ch.Portada);
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
            AplicarIdioma();
            CargaBorradores();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloMisBorradores;
        }
    }
}

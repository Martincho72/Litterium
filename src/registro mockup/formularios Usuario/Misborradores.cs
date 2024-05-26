using iText.Kernel.Utils;
using registro_mockup.clases;
using registro_mockup.Idiomas;
using registro_mockup.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

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
                else
                {
                    MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvBorradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (bDatos.AbrirConexion())
            {
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(bDatos.Conexion, dgvBorradores.Rows[indice].Cells[0].Value.ToString());
                CrearCortohistoria crear = new CrearCortohistoria(ch.Id, usuariomenu);
                crear.Show();
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bDatos.CerrarConexion();
        }
    }
}

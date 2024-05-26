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

namespace registro_mockup.Principal
{
    public partial class ListaDeCortohistoriasContinuar : Form
    {
        BDatos basedatos = new BDatos();
        string usuario;
        public ListaDeCortohistoriasContinuar(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void ListaDeCortohistoriasContinuar_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarCortohistorias();
        }

        private void CargarCortohistorias()
        {
            if (basedatos.AbrirConexion())
            {
                int id_usu = Usuario.ObtenerID(basedatos.Conexion, usuario);
                List<CortoHistoria> lista = CortoHistoria.BuscarContinuables(basedatos.Conexion, id_usu);
                foreach (CortoHistoria ch in lista)
                {
                    dgvListaContinuarCortohistorias.Rows.Add(ch.Titulo, ch.Autor, ch.FechaPublicacion.ToString("dd/MM/yyyy"), ch.Categoria, ch.Portada);
                }
             }
            basedatos.CerrarConexion();

        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloListaCortohistoriasContinuar;
            lblDobleClick.Text = Idioma.lblDobleClickSeleccionarCH;
        }

        private void dgvListaContinuarCortohistorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, dgvListaContinuarCortohistorias.Rows[indice].Cells[0].Value.ToString());
                VisualizarCortohistoria vs = new VisualizarCortohistoria(usuario, ch.Id, "Busqueda");
                vs.ShowDialog();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }
    }



}

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

namespace registro_mockup.formularios_Usuario
{
    public partial class MisCortoHistorias : Form
    {
        private string usuariomenu;
        BDatos bDatos = new BDatos();
        public MisCortoHistorias(string usuario)
        {
            usuariomenu = usuario;
            InitializeComponent();

        }
        private void CargaCortoHistorias()
        {
            try
            {
                if (bDatos.AbrirConexion())
                {
                    
                    int idUsuario = Usuario.ObtenerID(bDatos.Conexion, usuariomenu);
                    List<CortoHistoria> cortoHistorias = CortoHistoria.BuscarCortoHistoriaUsuario(bDatos.Conexion, idUsuario);
                    foreach (CortoHistoria ch in cortoHistorias)
                    {
                        dgvCortoHistorias.Rows.Add(ch.Titulo,ch.Autor,ch.FechaPublicacion.ToString("dd/MM/yyyy"),ch.Categoria,ch.Continuable,ch.Finalizada,ch.Portada);
                    }
                }
                else
                {
                    MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                bDatos.CerrarConexion();
            }
        }

        private void dgvCortoHistorias_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvCortoHistorias.Columns[e.ColumnIndex].Name == "Finalizada")
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool estado = (bool)e.Value;



                    if (estado)
                    {
                        e.CellStyle.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Red;

                    }
                }
            }
        }
       

        private void MisCortoHistorias_Load_1(object sender, EventArgs e)
        {
            CargaCortoHistorias();

        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloMisCortohistorias;
        }
    }
}

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
                    dgvCortoHistorias.DataSource = CortoHistoria.BuscarCortoHistoriasUsuario(bDatos.Conexion, idUsuario);
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
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.DarkGreen;

                    }
                }
            }
        }

        private void MisCortoHistorias_Load_1(object sender, EventArgs e)
        {
            CargaCortoHistorias();

        }
    }
}

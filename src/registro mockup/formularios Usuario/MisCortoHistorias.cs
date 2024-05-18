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
        public MisCortoHistorias()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtgvMiscortohistorias.Columns[e.ColumnIndex].Name == "estado")
            {
                if (e.Value != null)
                {
                    string estadoValue = e.Value.ToString();

                    if (estadoValue == "FINALIZADO")
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (estadoValue == "EN PROCESO")
                    {
                        e.CellStyle.BackColor = Color.DarkGreen;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}

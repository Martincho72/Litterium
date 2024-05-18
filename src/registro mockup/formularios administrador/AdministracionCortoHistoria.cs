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
    public partial class AdministracionCortoHistoria : Form
    {
        public AdministracionCortoHistoria()
        {
            InitializeComponent();
        }

        private void btnEliminarCH_Click(object sender, EventArgs e)
        {
            EliminarCortoHistoria form = new EliminarCortoHistoria();
            form.ShowDialog();


        }

        private void btnEditarCH_Click(object sender, EventArgs e)
        {
            BuscarCortoHistoria edit = new BuscarCortoHistoria();
            edit.ShowDialog();
        }
    }
}

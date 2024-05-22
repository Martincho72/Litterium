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

namespace registro_mockup.Principal
{
    public partial class MiCarrito : Form
    {
        public MiCarrito()
        {
            InitializeComponent();
        }

        private void MiCarrito_Load(object sender, EventArgs e)
        {
            dgvMiCarrito.DataSource = carrito.MiCarrito;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

            Comprar form = new Comprar();
            form.ShowDialog();
            
        }
    }
}

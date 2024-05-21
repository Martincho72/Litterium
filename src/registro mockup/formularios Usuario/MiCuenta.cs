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
    public partial class MiCuenta : Form
    {
        private string usuariomenu;
        public MiCuenta(string usuario)

        {
            usuariomenu = usuario;
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Litterium
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pcbLogo.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}

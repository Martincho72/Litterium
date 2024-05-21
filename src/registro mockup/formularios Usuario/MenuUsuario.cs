using FontAwesome.Sharp;
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

namespace registro_mockup.formularios_Usuario
{
    public partial class MenuUsuario : Form
    {
        private IconButton actualBTN;
        private Panel bordeizqBTN;
        private Form currentForm;
        private string usuariomenu;
        public MenuUsuario(string usuario)
        {
            InitializeComponent();
            usuariomenu = usuario;
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelUsuarios.Controls.Add(childForm);
            panelUsuarios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MiCuenta());
        }

        private void btnMisLibros_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MisLibros());
        }

        private void btnMisCortohistorias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MisCortoHistorias());
        }

        private void btnMisBorradores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Misborradores(usuariomenu));
        }

        private void btnMiHistorial_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HistorialCompras());
        }
    }
}

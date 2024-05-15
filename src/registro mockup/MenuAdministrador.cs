using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_mockup
{
    public partial class MenuAdministrador : Form
    {
        private Form currentForm;
        private IconButton actualBtn;
        private Panel AdministrarUsuario;
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
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
            panelescritorio.Controls.Add(childForm);
            panelescritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AministracionUsuario());
        }
    }
}

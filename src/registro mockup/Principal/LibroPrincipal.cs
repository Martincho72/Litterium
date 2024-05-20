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
    public partial class LibroPrincipal : Form
    {
        private Panel bordeizqBTN;
        private Form currentForm;
        public LibroPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void grbLibroRecomendado1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LibroPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblRecomendadosLibros_Click(object sender, EventArgs e)
        {

        }

        private void lblMejorvaloradosLibros_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void pcbRecomendado5_Click(object sender, EventArgs e)
        {

        }

        private void gbxRecomendadosLibros1_Enter(object sender, EventArgs e)
        {

        }

        private void pcbRecomendado1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InformacionLibro());
            OcultarPaneles();
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void OcultarPaneles()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
            tableLayoutPanel3.Visible = false;
        }
    }
}

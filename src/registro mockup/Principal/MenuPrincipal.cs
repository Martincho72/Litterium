using FontAwesome.Sharp;
using registro_mockup.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_mockup
{
    public partial class MenuPrincipal : Form
    {

       private IconButton actualBTN;
        private Panel bordeizqBTN;
        private Form currentForm;
        public MenuPrincipal()
        {
            InitializeComponent();
            bordeizqBTN = new Panel();
            bordeizqBTN.Size = new Size(7, 60);
            panelMenu.Controls.Add(bordeizqBTN);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.DoubleBuffered = true;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
        }
        private void ActivaBTN(object senderBtn, Color color)
        {
            desactivarBTN();
            if (senderBtn != null)
            {

                actualBTN = (IconButton)senderBtn;
                actualBTN.BackColor = Color.FromArgb(252, 139, 45);
                actualBTN.ForeColor = color;
                actualBTN.TextAlign = ContentAlignment.MiddleCenter;
                actualBTN.IconColor = color;
                actualBTN.TextImageRelation = TextImageRelation.TextBeforeImage;
                actualBTN.ImageAlign = ContentAlignment.MiddleRight;
                bordeizqBTN.BackColor = color;
                bordeizqBTN.Location = new Point(0, actualBTN.Location.Y);
                bordeizqBTN.BringToFront();
                IconActual.IconChar = actualBTN.IconChar;
                IconActual.IconColor = color;
                lblinicio.Text = actualBTN.Text;
            }
        }
        private void desactivarBTN()
        {
            if (actualBTN != null)
            {
                actualBTN.BackColor = Color.FromArgb(255, 192, 128);
                actualBTN.ForeColor = Color.FromArgb(192, 64, 0);
                actualBTN.TextAlign = ContentAlignment.MiddleLeft;
                actualBTN.IconColor = Color.FromArgb(192, 64, 0);
                actualBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
                actualBTN.ImageAlign = ContentAlignment.MiddleLeft;

            }
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
            lblinicio.Text = childForm.Text;
        }




        private void BTNinicio_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            desactivarBTN();
            bordeizqBTN.Visible = false;
            IconActual.IconChar = IconChar.Home;
            IconActual.IconColor = Color.OrangeRed;
            lblinicio.Text = "Litterium";

        }


        private void IconActual_Click(object sender, EventArgs e)
        {
            currentForm.Close();
            Reset();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivaBTN(sender, RGBColors.color1);

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActivaBTN(sender, RGBColors.color1);

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivaBTN(sender, RGBColors.color1);

        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            ActivaBTN(sender, RGBColors.color1);

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivaBTN(sender, RGBColors.color1);
            OpenChildForm(new MiCarrito());

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivaBTN(sender, RGBColors.color1);
            OpenChildForm(new LibroPrincipal());
        }

        private void btnPictureCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPictureMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Si el formulario está en estado normal, lo maximiza
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Si el formulario está maximizado, lo restaura al estado normal
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnPictureMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCortohistorias_Click(object sender, EventArgs e)
        {
            ActivaBTN(sender, RGBColors.color1);
            OpenChildForm(new CortoHistoriaPrincipal());
        }
    }
}

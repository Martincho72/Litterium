using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Org.BouncyCastle.Asn1.Ocsp;
using registro_mockup.formularios_administrador;
using registro_mockup.Idiomas;
using registro_mockup.Properties;

namespace registro_mockup
{
    public partial class MenuAdministrador : Form
    {
        private Form currentForm;
        private IconButton actualBTN;
        private Panel administrarUsuario;
        private Form previousForm;

        public MenuAdministrador(Form form1)
        {
            InitializeComponent();
            string idiomaActual = Thread.CurrentThread.CurrentUICulture.Name;

            if (idiomaActual == "es-ES")
            {
                pcbIdioma.Image = Resources.espanol;
            }
            else if (idiomaActual == "en-GB")
            {
                pcbIdioma.Image = Resources.english;
            }
            this.previousForm = form1;
            administrarUsuario = new Panel();
            administrarUsuario.Size = new Size(7, 60);
            panelMenu.Controls.Add(administrarUsuario);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.DoubleBuffered = false;
        }
        public MenuAdministrador()
        {
            InitializeComponent();
            string idiomaActual = Thread.CurrentThread.CurrentUICulture.Name;

            if (idiomaActual == "es-ES")
            {
                pcbIdioma.Image = Resources.espanol;
            }
            else if (idiomaActual == "en-GB")
            {
                pcbIdioma.Image = Resources.english;
            }
            administrarUsuario = new Panel();
            administrarUsuario.Size = new Size(7, 60);
            panelMenu.Controls.Add(administrarUsuario);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.DoubleBuffered = false;
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
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
            ActivaBTN(sender, RGBColors.color1);
        }

        private void btnAL_Click(object sender, EventArgs e)
        {

            OpenChildForm(new AdministracionLibro());
            ActivaBTN(sender, RGBColors.color1);
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdministracionCortoHistoria());
            ActivaBTN(sender, RGBColors.color1);
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
                administrarUsuario.Location = new Point(0, actualBTN.Location.Y);
                administrarUsuario.BringToFront();

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

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
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
        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloMenuAdministrador;
            btnCS.Text = Idioma.btnCS;
            btnAU.Text = Idioma.btnAU;
            btnAL.Text = Idioma.btnAL;
            btnAC.Text = Idioma.btnAC;
        }

        private void btnPictureMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Hide();
        }

        private void pcbIdioma_Click(object sender, EventArgs e)
        {
            string idiomaActual = Thread.CurrentThread.CurrentUICulture.Name;
            string cultura = "";

            DialogResult resultado = MessageBox.Show(Idioma.MensajeCambiarIdioma, Idioma.CaptionCambiarIdioma, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                if (idiomaActual == "es-ES")
                {
                    cultura = "en-GB";
                    pcbIdioma.Image = Resources.english;

                }
                else if (idiomaActual == "en-GB")
                {
                    cultura = "es-ES";
                    pcbIdioma.Image = Resources.espanol;
                }
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
                if (currentForm != null) { currentForm.Close();}
                AplicarIdioma();
            }
        }
    }
}

using registro_mockup.clases;
using registro_mockup.Idiomas;
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
        BDatos basedatos = new BDatos();
        private string usuariomenu;
        public LibroPrincipal(string usuariomenu)
        {
            InitializeComponent();
            this.usuariomenu = usuariomenu;
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

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloLibroPrincipal;
            lblRecomendadosLibros.Text = Idioma.lblRecomendadosLitterium;
            lblMejorvaloradosLibros.Text = Idioma.lblMejorvaloradosLibros;
            lblCortohistoriasEnLibros.Text = Idioma.lblCortohistoriasEnLibros;
        }

        private void LibroPrincipal_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            MostrarPaneles();
            if (basedatos.AbrirConexion())
            {
                
                List<string> titulo = Valoracion.librosMasValorados(basedatos.Conexion);
                grbValoradosLibros1.Text = titulo[0];
                grbValoradosLibros2.Text = titulo[1];
                grbValoradosLibros3.Text = titulo[2];
                grbValoradosLibros4.Text = titulo[3];
                grbValoradosLibros5.Text = titulo[4];

                Libro portada1 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[0]);
                pcbValorado1.Image = portada1.Portada;

                Libro portada2 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[1]);
                pcbValorado2.Image = portada2.Portada;

                Libro portada3 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[2]);
                pcbValorado3.Image = portada3.Portada;

                Libro portada4 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[3]);
                pcbValorado4.Image = portada4.Portada;

                Libro portada5 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[4]);
                pcbValorado5.Image = portada5.Portada;
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
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
            if (basedatos.AbrirConexion())
            {

                OpenChildForm(new InformacionLibro("El principito", usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
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
        private void MostrarPaneles()
        {
            panel2.Visible = true;
            panel3.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel8.Visible = true;
            tableLayoutPanel3.Visible = true;
        }

        private void pcbRecomendado2_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                OpenChildForm(new InformacionLibro("Alas de Sangre", usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbRecomendado3_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                OpenChildForm(new InformacionLibro("La siesta del pollo Pepe", usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbRecomendado4_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                OpenChildForm(new InformacionLibro("Percy Jackson El ladron del Rayo", usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbRecomendado5_Click_1(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                OpenChildForm(new InformacionLibro("Un cuento perfecto", usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbValorado1_Click(object sender, EventArgs e)
        {
           
            if (basedatos.AbrirConexion())
            {
                List<string> titulo = Valoracion.librosMasValorados(basedatos.Conexion);
                OpenChildForm(new InformacionLibro(titulo[0], usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbValorado2_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<string> titulo = Valoracion.librosMasValorados(basedatos.Conexion);
                OpenChildForm(new InformacionLibro(titulo[1], usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbValorado3_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<string> titulo = Valoracion.librosMasValorados(basedatos.Conexion);
                OpenChildForm(new InformacionLibro(titulo[2], usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbValorado4_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<string> titulo = Valoracion.librosMasValorados(basedatos.Conexion);
                OpenChildForm(new InformacionLibro(titulo[3], usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbValorado5_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<string> titulo = Valoracion.librosMasValorados(basedatos.Conexion);
                OpenChildForm(new InformacionLibro(titulo[4], usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbCortoHistoria_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                OpenChildForm(new VisualizarCortohistoria(usuariomenu,18, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbCortoHistoria2_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                OpenChildForm(new VisualizarCortohistoria(usuariomenu, 16, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbCortoHistoria3_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                OpenChildForm(new VisualizarCortohistoria(usuariomenu, 17, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbCortoHistoria4_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                OpenChildForm(new VisualizarCortohistoria(usuariomenu, 19, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbCortoHistoria5_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                OpenChildForm(new VisualizarCortohistoria(usuariomenu, 20, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }
    }
}

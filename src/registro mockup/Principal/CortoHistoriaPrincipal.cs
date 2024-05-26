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
using FontAwesome.Sharp;
using registro_mockup.Principal;
using registro_mockup.Idiomas;

namespace registro_mockup.Principal
{
    public partial class CortoHistoriaPrincipal : Form
    {
        BDatos basedatos=new BDatos();
        private Form currentForm;
        string usuarioMenu;
        public CortoHistoriaPrincipal(string usuario)
        {
            InitializeComponent();
            usuarioMenu = usuario;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void grbRecomendadosCortohistorias5_Enter(object sender, EventArgs e)
        {

        }

        private void CortoHistoriaPrincipal_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            if (basedatos.AbrirConexion())
            {
                List<string> titulo = Valoracion.librosMasValorados(basedatos.Conexion);
                grbValoradosLibro1.Text = titulo[0];
                grbValoradosLibro2.Text = titulo[1];
                grbValoradosLibro3.Text = titulo[2];
                grbValoradosLibro4.Text = titulo[3];
                grbValoradosLibro5.Text = titulo[4];

                Libro portada1 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[0]);
                pcbValoradoLibro1.Image = portada1.Portada;

                Libro portada2 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[1]);
                pcbValoradoLibro2.Image = portada2.Portada;

                Libro portada3 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[2]);
                pcbValoradoLibro3.Image = portada3.Portada;

                Libro portada4 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[3]);
                pcbValoradoLibro4.Image = portada4.Portada;

                Libro portada5 = Libro.EncontrarDatosLibroTitulo(basedatos.Conexion, titulo[4]);
                pcbValoradoLibro5.Image = portada5.Portada;


                List<string> cortoHistorias = CortoHistoria.EncontrarCortoHistoriasRecientes(basedatos.Conexion);

                grbValoradosCH1.Text = cortoHistorias[0];
                grbValoradosCH2.Text = cortoHistorias[1];
                grbValoradosCH3.Text = cortoHistorias[2];
                grbValoradosCH4.Text = cortoHistorias[3];
                grbValoradosCH5.Text = cortoHistorias[4];

                CortoHistoria ch1 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[0]);
                pcbReciente1.Image = ch1.Portada;

                CortoHistoria ch2 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[1]);
                pcbReciente2.Image = ch2.Portada;

                CortoHistoria ch3 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[2]);
                pcbReciente3.Image = ch3.Portada;

                CortoHistoria ch4 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[3]);
                pcbReciente4.Image = ch4.Portada;

                CortoHistoria ch5 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[4]);
                pcbReciente5.Image = ch5.Portada;
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();


        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void grbCortohistoriasLibros3_Enter(object sender, EventArgs e)
        {

        }

        private void grbCortohistoriasLibros5_Enter(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRecomendadosLibros_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearCortohistoria_Click(object sender, EventArgs e)
        {
            CrearCortohistoria crearCortohistoria = new CrearCortohistoria(usuarioMenu);
            // Mostrar Form2
            crearCortohistoria.ShowDialog();
        }

        private void btnContinuarCortohistoria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListaDeCortohistoriasContinuar(usuarioMenu));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pcbRecomendado1_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch1 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, "El Reloj Encantado");
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch1.Id, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }
        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloCortohistoriaPrincipal;
            btnCrearCortohistoria.Text = Idioma.btnCrearCortohistoria;
            btnContinuarCortohistoria.Text = Idioma.ContinuarCH;
            lblRecomendadosCH.Text = Idioma.lblRecomendadosLitterium;
            lblCortoHistoriasRecientes.Text = Idioma.lblCortohistoriasRecientes;
            lblLibrosEnCortohistorias.Text = Idioma.lblLibrosEnCortohistorias;
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

        private void pcbReciente1_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<string> cortoHistorias = CortoHistoria.EncontrarCortoHistoriasRecientes(basedatos.Conexion);
                CortoHistoria ch1 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[0]);
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch1.Id, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbReciente2_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<string> cortoHistorias = CortoHistoria.EncontrarCortoHistoriasRecientes(basedatos.Conexion);
                CortoHistoria ch2 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[1]);
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch2.Id, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbReciente3_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<string> cortoHistorias = CortoHistoria.EncontrarCortoHistoriasRecientes(basedatos.Conexion);
                CortoHistoria ch3 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[2]);
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch3.Id, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbReciente4_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<string> cortoHistorias = CortoHistoria.EncontrarCortoHistoriasRecientes(basedatos.Conexion);
                CortoHistoria ch4 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[3]);
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch4.Id, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbReciente5_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<string> cortoHistorias = CortoHistoria.EncontrarCortoHistoriasRecientes(basedatos.Conexion);
                CortoHistoria ch5 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, cortoHistorias[4]);
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch5.Id, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbRecomendado2_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch2 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, "El Cuaderno Mágico");
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch2.Id, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbRecomendado3_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch3 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, "La Caja de Música");
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch3.Id, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbRecomendado4_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch4 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, "El Espejo Misterioso");
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch4.Id, "ChPrincipal"));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void pcbRecomendado5_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                CortoHistoria ch5 = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, "El Libro Olvidado");
                OpenChildForm(new VisualizarCortohistoria(usuarioMenu, ch5.Id, "ChPrincipal"));

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

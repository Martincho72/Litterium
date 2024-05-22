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
    public partial class CortoHistoriaPrincipal : Form
    {
        BDatos basedatos=new BDatos();
        public CortoHistoriaPrincipal()
        {
            InitializeComponent();
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
            }
            else
            {
                MessageBox.Show("");
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
    }
}

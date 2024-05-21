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
    public partial class LibroPrincipal : Form
    {
        private Panel bordeizqBTN;
        private Form currentForm;
        BDatos basedatos=new BDatos();
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
            if (basedatos.AbrirConexion())
            {
                List<Libro> lista = new List<Libro>();
                lista = Libro.BuscarLibros(basedatos.Conexion, "El principito");

                Libro libro = new Libro(lista[0].Isbn, lista[0].Titulo, lista[0].Autor, lista[0].Categoria, lista[0].Valoracion, lista[0].Portada, lista[0].Sinopsis, lista[0].Precio);

                OpenChildForm(new InformacionLibro(libro, usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show("");
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

        private void pcbRecomendado2_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<Libro> lista = new List<Libro>();
                lista = Libro.BuscarLibros(basedatos.Conexion, "Alas de Sangre");

                Libro libro = new Libro(lista[0].Isbn, lista[0].Titulo, lista[0].Autor, lista[0].Categoria, lista[0].Valoracion, lista[0].Portada, lista[0].Sinopsis, lista[0].Precio);

                OpenChildForm(new InformacionLibro(libro, usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void pcbRecomendado3_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<Libro> lista = new List<Libro>();
                lista = Libro.BuscarLibros(basedatos.Conexion, "La siesta del pollo Pepe");

                Libro libro = new Libro(lista[0].Isbn, lista[0].Titulo, lista[0].Autor, lista[0].Categoria, lista[0].Valoracion, lista[0].Portada, lista[0].Sinopsis, lista[0].Precio);

                OpenChildForm(new InformacionLibro(libro, usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void pcbRecomendado4_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<Libro> lista = new List<Libro>();
                lista = Libro.BuscarLibros(basedatos.Conexion, "Percy Jackson El ladron del Rayo");

                Libro libro = new Libro(lista[0].Isbn, lista[0].Titulo, lista[0].Autor, lista[0].Categoria, lista[0].Valoracion, lista[0].Portada, lista[0].Sinopsis, lista[0].Precio);

                OpenChildForm(new InformacionLibro(libro, usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void pcbRecomendado5_Click_1(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                List<Libro> lista = new List<Libro>();
                lista = Libro.BuscarLibros(basedatos.Conexion, "Un cuento perfecto");

                Libro libro = new Libro(lista[0].Isbn, lista[0].Titulo, lista[0].Autor, lista[0].Categoria, lista[0].Valoracion, lista[0].Portada, lista[0].Sinopsis, lista[0].Precio);

                OpenChildForm(new InformacionLibro(libro,usuariomenu));

                OcultarPaneles();
            }
            else
            {
                MessageBox.Show("");
            }
        }
    }
}

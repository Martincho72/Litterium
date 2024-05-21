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
    public partial class InformacionLibro : Form
    {
        private Libro libro;
        BDatos basedatos=new BDatos();
        private string usuariomenu;
        private string isbnLibro;
        public InformacionLibro(Libro l1,string usuario)
        {
            InitializeComponent();
            usuariomenu = usuario;
            isbnLibro = l1.Isbn;
            libro = l1;
            lblAutorLibro.Text = "Autor: " + l1.Autor;
            lblTituloLibro.Text="Titulo: " + l1.Titulo;
            lblValoracion.Text ="Valoracion: " + l1.Valoracion;
            txtSinopsis.Text=l1.Sinopsis;
            pcbPortadaLibro.Image=l1.Portada;
            lblPrecioLibro.Text = "Precio: " + l1.Precio+"€";
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void InformacionLibro_Load(object sender, EventArgs e)
        {
            cmbValorar.SelectedIndex = 4;
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Comprar form = new Comprar();
            form.ShowDialog();
        }

        private void btnValorar_Click(object sender, EventArgs e)
        {
            
            if (basedatos.AbrirConexion())
            {
                Usuario usu = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usuariomenu);

                if (!Valoracion.EncontrarValoracion(basedatos.Conexion,usu.Id,isbnLibro ))
                {
                    Valoracion.insertarValoracion(basedatos.Conexion,isbnLibro,usu.Id, int.Parse(cmbValorar.Text));

                }
                else
                {
                    Valoracion.EditarValoracion(basedatos.Conexion,usu.Id, isbnLibro, int.Parse(cmbValorar.Text));
                }
                Libro l1 = Libro.EncontrarDatosLibro(basedatos.Conexion, isbnLibro);
                lblValoracion.Text = "Valoracion: " + l1.Valoracion;
            }
            else
            {

            }
            basedatos.CerrarConexion();
        }
    }
}

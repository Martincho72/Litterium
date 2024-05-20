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
        public InformacionLibro(Libro l1)
        {
            InitializeComponent();
            libro = l1;
            lblAutorLibro.Text = "Autor: " + l1.Autor;
            lblTituloLibro.Text="Titulo: " + l1.Titulo;
            txtSinopsis.Text=l1.Sinopsis;
            pcbPortadaLibro.Image=l1.Portada;
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

        private void btnComprarAhora_Click(object sender, EventArgs e)
        {
            Comprar form = new Comprar();
            form.ShowDialog();

        }

        private void InformacionLibro_Load(object sender, EventArgs e)
        {

        }
    }
}

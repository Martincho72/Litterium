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
    public partial class ListaDeCortohistoriasContinuar : Form
    {
        public ListaDeCortohistoriasContinuar()
        {
            InitializeComponent();
        }

        private void ListaDeCortohistoriasContinuar_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloListaCortohistoriasContinuar;
            lblDobleClick.Text = Idioma.lblDobleClickSeleccionarCH;
        }
    }



}

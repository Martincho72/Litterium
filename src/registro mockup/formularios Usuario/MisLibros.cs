using registro_mockup.clases;
using registro_mockup.Idiomas;
using registro_mockup.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_mockup.formularios_Usuario
{
    public partial class MisLibros : Form


    {
        private string usuariomenu;
        BDatos bDatos = new BDatos();
        public MisLibros(string usuario)
        {
            usuariomenu = usuario;
            InitializeComponent();
        }

        private void CargaLibros()
        {
            try
            {
                if (bDatos.AbrirConexion())
                {
                    int idUsuario = Usuario.ObtenerID(bDatos.Conexion, usuariomenu);
                    List<Ejemplar> lista = Ejemplar.BuscarEjemplaresOnline(bDatos.Conexion, idUsuario);
                    foreach (Ejemplar ej in lista)
                    {
                        Libro libro = Libro.EncontrarDatosLibro(bDatos.Conexion, ej.Isbn_libro);
                        dgvLibros.Rows.Add(libro.Titulo, libro.Autor, libro.Categoria, ej.FechaCompra, libro.Portada);
                    }
                }
                else
                {
                    MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                bDatos.CerrarConexion();
            }
        }

        private void MisLibros_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargaLibros();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloMisLibros;
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0 && bDatos.AbrirConexion())
            {
                try
                {
                    string isbn = dgvLibros.Rows[indice].Cells[4].Value.ToString(); // Asumiendo que la ISBN está en la primera columna
                    Libro libro = Libro.EncontrarDatosLibro(bDatos.Conexion, isbn);

                    if (libro != null && libro.Pdf != null)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                        saveFileDialog.FileName = $"{libro.Titulo}.pdf";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, libro.Pdf);
                            MessageBox.Show("PDF guardado exitosamente.", "Guardar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el PDF para este libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    bDatos.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}

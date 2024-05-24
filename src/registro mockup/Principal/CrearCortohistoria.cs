using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font;
using iText.Kernel.Font;
using MySql.Data.MySqlClient;
using iText.IO.Image;
using iText.Layout.Properties;
using registro_mockup.clases;
using registro_mockup.Idiomas;

namespace registro_mockup.Principal
{
    public partial class CrearCortohistoria : Form
    {
        BDatos basedatos = new BDatos();
        string usarioMenu;
        int id = 0;
        int longitud = -1;
        public CrearCortohistoria(string usuarioMenu)
        {
            InitializeComponent();
            this.usarioMenu = usuarioMenu;
        }

        public CrearCortohistoria(int idCortohistoria, string usuarioMenu)
        {
            InitializeComponent();
            id = idCortohistoria;
            this.usarioMenu = usuarioMenu;
            if (basedatos.AbrirConexion())
            {
                int id_usu = Usuario.ObtenerID(basedatos.Conexion, usuarioMenu);
                CortoHistoria ch = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, id);
                txtTitulo.Text = ch.Titulo;
                txtCortohistoriaCrear.Text = ch.Texto;
                txtCategoria.Text = ch.Categoria;
                txtAutor.Text = ch.Autor;
                if (ch.Id_usuario != id_usu)
                {
                    btnBorradoresCortohistorias.Visible = false;
                    txtTitulo.ReadOnly = true;
                    txtCategoria.ReadOnly = true;
                    txtAutor.ReadOnly = true;
                    pcbPortada.Image = ch.Portada;
                    btnCargarImagenCortohistorias.Enabled = false;
                    longitud = ch.Texto.Length;
                    chbContinuarCortohistoria.Visible = false;
                    btnBorrar.Visible = false;
                }
            }
            basedatos.CerrarConexion();
        }

        public CrearCortohistoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chbContinuarCortohistoria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCortohistoriaCrear.Text = "";
        }

        private void btnPictureSeguirHistoria_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void CrearCortohistoria_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            toolTip1.SetToolTip(btnPictureSeguirHistoria, Idioma.SeguirCortoHistoriaToolTip);
        }
        // Codificar el texto antes de guardar
        private string EncodeText(string text)
        {
            // Reemplazar espacios, tabuladores y saltos de lÃ­nea con caracteres especiales
            text = text.Replace(" ", " ").Replace("\t", "\t").Replace("\r\n", "\r\n");
            return text;
        }
        private void btnSubirCortohistoria_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                Usuario us1 = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usarioMenu);
                CortoHistoria ch = new CortoHistoria(txtTitulo.Text, txtAutor.Text, DateTime.Now, txtCategoria.Text, chbContinuarCortohistoria.Checked, true, us1.Id, pcbPortada.Image, txtCortohistoriaCrear.Text);
                ch.AgregarCortoHistoria(basedatos.Conexion, ch);
            }
            else
            {
                MessageBox.Show(Idioma.AbrirSesionError);
            }
            basedatos.CerrarConexion();

        }

        private void btnVerPDF_Click(object sender, EventArgs e)
        {
            /*string cuerpo = EncodeText(txtCortohistoriaCrear.Text); // Codificar el texto antes de guardar
            string titulo = txtTitulo.Text;
           

            // Combinar el título y el cuerpo
            string textoTotal = titulo + Environment.NewLine + cuerpo;

            // Crear un MemoryStream para almacenar el PDF
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Definir la ruta de la fuente Segoe Script en tu sistema
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "segoesc.ttf");

                // Cargar la fuente
                PdfFont pdfFont;
                try
                {
                    pdfFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la fuente: " + ex.Message);
                    return;
                }

                // Escribir en el PDF
                using (var writer = new PdfWriter(memoryStream))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        var document = new Document(pdf);

                        // Dividir el texto en líneas y agregar cada línea como un párrafo separado
                        foreach (var line in textoTotal.Split('\n'))
                        {
                            document.Add(new iText.Layout.Element.Paragraph(line).SetFont(pdfFont).SetFontSize(8.25f));
                        }
                    }
                }

                // Convertir el MemoryStream a un arreglo de bytes
                byte[] pdfBytes = memoryStream.ToArray();

                // Mostrar un cuadro de diálogo para que el usuario seleccione dónde guardar el archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar PDF";
                saveFileDialog.FileName = titulo + ".pdf"; // Nombre del archivo sugerido

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Guardar el archivo PDF en la ubicación seleccionada
                        File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                        MessageBox.Show("PDF guardado correctamente en " + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                    }
                }

            }*/
            string cuerpo = EncodeText(txtCortohistoriaCrear.Text); // Codificar el texto antes de guardar
            string titulo = txtTitulo.Text;

            // Crear un MemoryStream para almacenar el PDF
            using (MemoryStream memoryStream = new MemoryStream())
            {
                try
                {
                    // Escribir en el PDF
                    using (var writer = new PdfWriter(memoryStream))
                    {
                        using (var pdf = new PdfDocument(writer))
                        {
                            var document = new Document(pdf);

                            // Agregar la imagen de portada si se ha seleccionado una
                            if (!string.IsNullOrEmpty(pcbPortada.ImageLocation))
                            {
                                try
                                {
                                    iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(ImageDataFactory.Create(pcbPortada.ImageLocation));

                                    // Ajustar la imagen para que ocupe toda la página
                                    pdfImage.SetAutoScale(true);
                                    pdfImage.ScaleToFit(pdf.GetDefaultPageSize().GetWidth(), pdf.GetDefaultPageSize().GetHeight());

                                    document.Add(pdfImage);
                                    document.Add(new Paragraph(titulo).SetFontSize(20).SetTextAlignment(TextAlignment.CENTER));


                                    // Agregar un salto de página
                                    document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(Idioma.ErrorAgregarImagen + ex.Message);
                                }
                            }



                            // Dividir el texto en líneas y agregar cada línea como un párrafo separado
                            foreach (var line in cuerpo.Split('\n'))
                            {
                                document.Add(new iText.Layout.Element.Paragraph(line).SetFontSize(8.25f));
                            }
                        }
                    }

                    // Convertir el MemoryStream a un arreglo de bytes
                    byte[] pdfBytes = memoryStream.ToArray();

                    // Mostrar un cuadro de diálogo para que el usuario seleccione dónde guardar el archivo
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar PDF";
                    saveFileDialog.FileName = titulo + ".pdf"; // Nombre del archivo sugerido

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo PDF en la ubicación seleccionada
                        File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                        MessageBox.Show("PDF guardado correctamente en " + saveFileDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Idioma.ErrorGenerarPDF + ex.Message);
                }
            }
        }


        private void btnCargarImagenCortohistorias_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargaImagen = new OpenFileDialog();
            cargaImagen.InitialDirectory = "C:\\";
            cargaImagen.Filter = "JPG (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (cargaImagen.ShowDialog() == DialogResult.OK)
            {
                pcbPortada.ImageLocation = cargaImagen.FileName;
                MessageBox.Show(cargaImagen.FileName);
            }
            else
            {
                MessageBox.Show(Idioma.ImagenNoSeleccionada, Idioma.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBorradoresCortohistorias_Click(object sender, EventArgs e)
        {

            if (basedatos.AbrirConexion())
            {
                int id_usuario = Usuario.ObtenerID(basedatos.Conexion, usarioMenu);
                if (id == 0)
                {
                    CortoHistoria ch = new CortoHistoria(txtTitulo.Text, txtAutor.Text, DateTime.Now, txtCategoria.Text, chbContinuarCortohistoria.Checked, false, id_usuario, pcbPortada.Image, txtCortohistoriaCrear.Text);
                    ch.AgregarCortoHistoria(basedatos.Conexion, ch);
                }
                else
                {
                    CortoHistoria cortoHistoria = CortoHistoria.EncontrarDatosCortoHistoria(basedatos.Conexion, id);
                    if (id_usuario == cortoHistoria.Id_usuario)
                    {
                        // update
                        CortoHistoria.EditarCortoHistoria(basedatos.Conexion, cortoHistoria);
                    }
                }
            }
            else
            {
                MessageBox.Show(Idioma.AbrirSesionError);
            }

            basedatos.CerrarConexion();

        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloCrearCortohistoria;
            lblTitulo.Text = Idioma.lblTituloCrearCortohistoria;
            lblCortohistoria.Text = Idioma.lblCortohistoriaCrearCortohistoria;
            btnVerPDF.Text = Idioma.btnVerComoPDF;
            btnCargarImagenCortohistorias.Text = Idioma.btnCargarImagenCortohistoria;
            btnSubirCortohistoria.Text = Idioma.btnSubirCortohistoria;
            btnBorradoresCortohistorias.Text = Idioma.btnBorradoresCortohistorias;
            btnBorrar.Text = Idioma.btnBorrar;
            lblCategoria.Text = Idioma.lblCategoriaEditarLibro;
            lblAutor.Text = Idioma.lblAutorEditarLibro;
            chbContinuarCortohistoria.Text = Idioma.chbContinuarCortohistoria;

        }

        private void txtCortohistoriaCrear_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCortohistoriaCrear_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            int inicioSeleccion = txtCortohistoriaCrear.SelectionStart;
            if (inicioSeleccion <= longitud)
            {
                e.Handled = true;
                txtCortohistoriaCrear.Text += " ";
                txtCortohistoriaCrear.SelectionStart = longitud + 1;
            }
            else { e.Handled = false; }
        }
    }
}


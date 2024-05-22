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



namespace registro_mockup.Principal
{
    public partial class CrearCortohistoria : Form
    {
        public CrearCortohistoria()
        {
            InitializeComponent();

            toolTip1.SetToolTip(btnPictureSeguirHistoria, "Al activar esta funcion permites que el resto de ususarios puedan continuar la cortohistoria.");

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
            // Obtener el texto del cuerpo y el título
            string cuerpo = EncodeText(txtCortohistoriaCrear.Text); // Codificar el texto antes de guardar
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

                // Guardar el PDF en la base de datos
                GuardarPDFEnBD(pdfBytes);

                MessageBox.Show("PDF guardado correctamente en la base de datos.");
            }
        }

        private bool GuardarPDFEnBD(byte[] pdfBytes)
        {
            BDatos bd = new BDatos();

            if (bd.AbrirConexion())
            {
                try
                {
                    // Consulta SQL para insertar el PDF en la base de datos
                    string query = "INSERT INTO TablaPDFs (PDFData) VALUES (@PDFData)";

                    using (MySqlCommand command = new MySqlCommand(query, bd.Conexion))
                    {
                        // Agregar el parámetro de bytes del PDF
                        command.Parameters.AddWithValue("@PDFData", pdfBytes);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el PDF en la base de datos: " + ex.Message);
                    return false;
                }
                finally
                {
                    bd.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                return false;
            }
        }

        private void btnCargarImagenCortohistoria_Click(object sender, EventArgs e)
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
                MessageBox.Show("No se ha seleccionado imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using registro_mockup.clases;
using registro_mockup.Idiomas;
using Litterium;

namespace registro_mockup.formularios_administrador
{
    public partial class ContrasenyaOlvidada : Form
    {
        BDatos dbatos = new BDatos();
        public ContrasenyaOlvidada()
        {
            InitializeComponent();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string enlace = "litterium.000webhostapp.com/nuevaContrasena.html";
            int nuevacontrasena = Correo.NuevaContrasena();
            MailMessage correo = new MailMessage();

            if (dbatos.AbrirConexion())
            {

                if (Correo.validarCorreo(dbatos.Conexion, txtCorreo.Text.Trim()))
                {
                    Correo.enviarCorreo(enlace, nuevacontrasena, correo, txtCorreo.Text.Trim());
                    Correo.ActualizarContrasena(dbatos.Conexion, txtCorreo.Text.Trim(), nuevacontrasena);
                    MessageBox.Show(Idioma.ConfirmacionNuevaContrasenya);
                }
                else
                {
                    MessageBox.Show(Idioma.CorreoNoExiste);
                }
            }
            else
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error Conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dbatos.CerrarConexion();
        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloContrasenyaOlvidada;
            lblTitulo.Text = Idioma.lblTituloRestablecerContrasenya;
            lblCorreo.Text = Idioma.lblCorreoContrasenyaOlvidada;
            btnRestablecer.Text = Idioma.btnRestablecerContrasenya;
        }

        private void ContrasenyaOlvidada_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void pcbAtras_Click(object sender, EventArgs e)
        {
            FrmLogIn login = new FrmLogIn();
            login.Show();
            this.Close();
        }
    }
}

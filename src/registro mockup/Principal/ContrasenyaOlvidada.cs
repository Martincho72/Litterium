﻿using System;
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
                    Correo.enviarCorreo(enlace, nuevacontrasena,correo, txtCorreo.Text.Trim());
                    Correo.ActualizarContrasena(dbatos.Conexion, txtCorreo.Text.Trim(), nuevacontrasena);
                    MessageBox.Show("Hemos enviado un correo con la nueva Contraseña, esto puede tardar unos minutos. ");


                }


                else
                {
                    MessageBox.Show("El correo proporcionado no esta registrado");
                }
            }
            dbatos.CerrarConexion();
        }
    }
}
﻿using registro_mockup.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using registro_mockup.Principal;
using Litterium;

namespace registro_mockup.formularios_Usuario
{
    public partial class MiCuenta : Form
    {
        private string usuariomenu;
        private Form previousForm;
        BDatos basedatos = new BDatos();
        public MiCuenta(string usuario, Form previousForm)

        {
            usuariomenu = usuario;
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargaImagen = new OpenFileDialog();
            cargaImagen.InitialDirectory = "C:\\";
            cargaImagen.Filter = "JPG (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (cargaImagen.ShowDialog() == DialogResult.OK)
            {
                pcbPerfil.ImageLocation = cargaImagen.FileName;
                MessageBox.Show(cargaImagen.FileName);
            }
            //else
            //{
            //    MessageBox.Show("No se ha seleccionado imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void MiCuenta_Load(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                Usuario usuario = Usuario.EncontrarDatosUsuario(basedatos.Conexion, usuariomenu);
                txtUsuario.Text = usuariomenu;
                txtTelefono.Text = usuario.Telefono.ToString();
                txtNombre.Text = usuario.Nombre;
                txtDireccion.Text = usuario.Direccion;
                txtCorreo.Text = usuario.Correo;
                txtContra.Text = usuario.Clave;
                pcbPerfil.Image = usuario.Foto;
            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
            AplicarIdioma();

        }

        private void AplicarIdioma()
        {
            this.Text = Idioma.TituloMiCuenta;
            lblUsuario.Text = Idioma.lblUsuarioMiCuenta;
            lblContra.Text = Idioma.lblContraMiCuenta;
            lblNombre.Text = Idioma.lblNombreMiCuenta;
            lblTelefono.Text = Idioma.lblTelefono;
            lblDireccion.Text = Idioma.lblDireccionMiCuenta;
            lblCorreo.Text = Idioma.lblCorreo;
            btnEditar.Text = Idioma.btnEditarMiCuenta;
            btnConfirmarEdicion.Text = Idioma.btnConfirmarEdicionMiCuenta;
            btnCargar.Text = Idioma.btnCargarMiCuenta;
            btnCerrar.Text = Idioma.btnCS;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false)
            {
                txtUsuario.Enabled = true;
                txtContra.Enabled = true;
                txtCorreo.Enabled = true;
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                btnCargar.Visible = true;
                btnConfirmarEdicion.Visible = true;
            }
            else
            {
                txtUsuario.Enabled = false;
                txtContra.Enabled = false;
                txtCorreo.Enabled = false;
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                txtTelefono.Enabled = false;
                btnCargar.Visible = false;
                btnConfirmarEdicion.Visible = false;

            }
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            if (basedatos.AbrirConexion())
            {
                Usuario usuario = new Usuario(txtUsuario.Text, txtContra.Text, txtNombre.Text, txtCorreo.Text, txtDireccion.Text, int.Parse(txtTelefono.Text), pcbPerfil.Image);
                Usuario.EditarUsuarioPerfil(basedatos.Conexion, usuario, usuariomenu);
                MessageBox.Show(Idioma.ConfirmarEdicionMiCuenta,Idioma.InfoConfirmarEdicionMiCuenta,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Restart();

            }
            else 
            {
                MessageBox.Show(Idioma.ConexionFallida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basedatos.CerrarConexion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

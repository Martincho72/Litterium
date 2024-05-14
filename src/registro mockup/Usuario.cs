﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace registro_mockup
{
    internal class Usuario
    {
        int id=0;
        string usuario;
        string clave;
        bool esAdmin=false;
        string nombre;
        string correoElectronico;
        string direccion;
        int telefono;
        bool vetado=false;
        bool baja = false;



        public Usuario(string usuario,string clave,string nombre,string correoElectronico,string direccion,int telefono)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.nombre = nombre;
            this.correoElectronico = correoElectronico;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public static bool EncontrarUsuario(MySqlConnection conexion, string usuario)
        {
            string consulta = string.Format("SELECT usuario FROM usuarios WHERE usuario = '{0}'", usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
        public int AgregarUsuario(MySqlConnection conexion, Usuario us1)
        {
            int vetado;
            int baja;
            int adminsitrador;
            if (us1.esAdmin) adminsitrador = 1;
            else adminsitrador = 0;
            if (us1.baja) baja = 1;
            else baja = 0;
            if (us1.vetado) vetado = 1;
            else vetado = 0;

            int retorno;
            string consulta = String.Format("INSERT INTO usuarios (usuario,contrasenya,esAdmin,nombre,correo,direccion,telefono,vetado,baja) " +
                "VALUES " + "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", us1.usuario, us1.clave, adminsitrador, us1.nombre,
                us1.correoElectronico, us1.direccion, us1.telefono,vetado,baja);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static bool validarContrasenya(MySqlConnection conexion,string usuario, string contra)
        {
            bool validador = false;
            string consulta = string.Format("SELECT contrasenya FROM usuarios where contrasenya='{0}' and usuario='{1}'",contra,usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (contra == reader.GetString(0)) { validador = true; }
                }
            }
            reader.Close();
            return validador;
        }

        public static bool esAdmintrador(MySqlConnection conexion,string usuario)
        {
            bool esAdmin = false;

            string consulta = string.Format("SELECT esAdmin FROM usuarios where usuario='{0}' and esAdmin=1",usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(0)) { esAdmin = true; }
                }
            }
            reader.Close();
            return esAdmin;
        }
    }
}

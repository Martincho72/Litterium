using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using registro_mockup.Properties;

namespace registro_mockup
{
    internal class Usuario
    {
        int id;
        string usuario;
        string clave;
        bool esAdmin;
        string nombre;
        string correoElectronico;
        string direccion;
        int telefono;
        bool vetado;
        bool baja;
        Image foto;

        public int Id { get { return id; } set { id = value; } }
        public string Usu { get { return usuario; } set { usuario = value; } }
        public string Clave { get { return clave; } set { clave = value; } }
        public bool EsAdmin { get { return esAdmin; } }
        public string Nombre { get { return nombre; } }
        public string Correo { get { return correoElectronico; } }
        public string Direccion { get { return direccion; } }
        public int Telefono { get { return telefono; } }
        public bool Vetado { get { return vetado; } }
        public bool Baja { get { return baja; } }
        public Image Foto { get { return foto; } set { foto = value; } }

        //editar usutio
        public Usuario() { }

        //registrar cliente nuevo
        public Usuario(string usuario, string clave, string nombre, string correoElectronico, string direccion, int telefono)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.nombre = nombre;
            this.correoElectronico = correoElectronico;
            this.direccion = direccion;
            this.telefono = telefono;
           
        }

        //agregar usuarios (ADMIN)
        public Usuario(string usuario, string clave,bool admin, string nombre, string correoElectronico, string direccion, int telefono)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.esAdmin = admin;
            this.nombre = nombre;
            this.correoElectronico = correoElectronico;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        //editar Cliente
        public Usuario(string usuario, string clave, bool esAdmin, string nombre, string correoElectronico, string direccion, int telefono, bool vetdado, bool baja,Image foto)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.esAdmin = esAdmin;
            this.nombre = nombre;
            this.correoElectronico = correoElectronico;
            this.direccion = direccion;
            this.telefono = telefono;
            this.vetado = vetdado;
            this.baja = baja;
            this.foto = foto;
        }
        //insertar DGV
        public Usuario(int id, string usuario, string clave, bool esAdmin, string nombre, string correoElectronico, string direccion, int telefono, bool vetdado, bool baja,Image foto)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.esAdmin = esAdmin;
            this.nombre = nombre;
            this.correoElectronico = correoElectronico;
            this.direccion = direccion;
            this.telefono = telefono;
            this.vetado = vetdado;
            this.baja = baja;
            this.foto = foto;
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

        public static Usuario EncontrarDatosUsuario(MySqlConnection conexion, string usuario)
        {
            string consulta = string.Format("SELECT * FROM usuarios WHERE usuario = '{0}'", usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            Usuario usua = new Usuario();
            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de empleados.
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string usu = reader.GetString(1);
                    string clave = reader.GetString(2);
                    bool esAdmin = reader.GetBoolean(3);
                    string nombre = reader.GetString(4);
                    string correo = reader.GetString(5);
                    string direccion = reader.GetString(6);
                    int telefono = reader.GetInt32(7);
                    bool vetado = reader.GetBoolean(8);
                    bool baja = reader.GetBoolean(9);

                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    // Crear el objeto Usuario y agregarlo a la lista
                    usua = new Usuario(id, usu, clave, esAdmin, nombre, correo,
                        direccion, telefono, vetado, baja,foto);
                }


            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return usua;
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

            Image fotoDefecto = Properties.Resources.perfilDefecto;
            us1.Foto = fotoDefecto;
            MemoryStream ms = new MemoryStream();
            us1.Foto.Save(ms, ImageFormat.Png);
            byte[] imgArr = ms.ToArray();
           

            int retorno;
            string consulta = String.Format("INSERT INTO usuarios (id,usuario,contrasenya,esAdmin,nombre,correo,direccion,telefono,vetado,baja,imagen) " +
                "VALUES " + "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',@imagen)", us1.id, us1.usuario, us1.clave, adminsitrador, us1.nombre,
                us1.correoElectronico, us1.direccion, us1.telefono, vetado, baja);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("imagen", imgArr);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static bool validarContrasenya(MySqlConnection conexion, string usuario, string contra)
        {
            bool validador = false;
            string consulta = string.Format("SELECT contrasenya FROM usuarios where contrasenya='{0}' and usuario='{1}'", contra, usuario);

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

        public static bool esAdmintrador(MySqlConnection conexion, string usuario)
        {
            bool esAdmin = false;

            string consulta = string.Format("SELECT esAdmin FROM usuarios where usuario='{0}' and esAdmin=1", usuario);

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

        public static List<Usuario> BuscarUsuarios(MySqlConnection conexion)
        {
            List<Usuario> lista = new List<Usuario>();
            string consulta = string.Format("SELECT * from usuarios");

            // Creamos el objeto command al cual le pasamos la consulta y la conexión
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            // Ejecutamos el comando y recibimos en un objeto DataReader la lista de registros seleccionados.
            // Recordemos que un objeto DataReader es una especie de tabla de datos virtual.
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de empleados.
                while (reader.Read())
                {
                    
                    int id = reader.GetInt32(0);
                    string usu = reader.GetString(1);
                    string clave = reader.GetString(2);
                    bool esAdmin = reader.GetBoolean(3);
                    string nombre = reader.GetString(4);
                    string correo = reader.GetString(5);
                    string direccion = reader.GetString(6);
                    int telefono = reader.GetInt32(7);
                    bool vetado = reader.GetBoolean(8);
                    bool baja = reader.GetBoolean(9);

                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    // Crear el objeto Usuario y agregarlo a la lista
                    Usuario usuario = new Usuario(id, usu, clave, esAdmin, nombre, correo,
                        direccion, telefono, vetado, baja, foto);
                    lista.Add(usuario);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }
        public static int eliminarUsuario(MySqlConnection conexion, string usuario)
        {
            int retorno;
            string consulta = String.Format("delete from usuarios where usuario='{0}'", usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int EditarUsuario(MySqlConnection conexion, Usuario us1)
        {
            int retorno;
            MemoryStream ms = new MemoryStream();
            us1.Foto.Save(ms, ImageFormat.Jpeg);
            byte[] imgArr = ms.ToArray();
            string consulta = String.Format("UPDATE usuarios SET usuario = '{0}', contrasenya = '{1}', esAdmin = '{2}', nombre = '{3}', correo = '{4}'," +
                                            "direccion = '{5}', telefono = '{6}', vetado = '{7}', baja = '{8}',imagen=@imagen WHERE usuario = '{0}'",
                                         us1.usuario, us1.clave, us1.esAdmin, us1.nombre, us1.correoElectronico, us1.direccion, us1.telefono, us1.vetado, us1.baja);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@imagen", imgArr);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        
    }
}
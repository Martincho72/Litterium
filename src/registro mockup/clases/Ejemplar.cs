using MySql.Data.MySqlClient;
using registro_mockup.clases;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_mockup
{
    internal class Ejemplar
    {
        int id;
        DateTime fechaCompra;
        string editorial;
        decimal precioTotal;
        int id_usuario;
        string isbn_usuario;

        public int Id { get { return id; } }
        public DateTime FechaCompra { get { return fechaCompra; } }
        public string Editorial { get {  return editorial; } }
        public decimal PrecioTotal { get {  return precioTotal; } }
        public int Id_usuario { get {  return id_usuario; } }
        public string Isbn_usuario{ get {return isbn_usuario; } }

        public Ejemplar(int id,DateTime fechaCompra,string editorial,decimal precioTotal,int id_usuario,string isbn_usuario)
        {
            this.id = id;
            this.fechaCompra = fechaCompra;
            this.editorial = editorial;
            this.precioTotal = precioTotal;
            this.id_usuario = id_usuario;
            this.isbn_usuario = isbn_usuario;
        }

        public static List<Ejemplar> BuscarEjemplares(MySqlConnection conexion)
        {
            List<Ejemplar> lista = new List<Ejemplar>();
            string consulta = string.Format("SELECT * from ejemplar");

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
                    DateTime fechaCompra = reader.GetDateTime(1);
                    string editorial = reader.GetString(2);
                    decimal precioTotal = reader.GetDecimal(3);
                    int id_usuario = reader.GetInt32(4);
                    string isbn_usuario = reader.GetString(5);

                    //byte[] img = (byte[])reader["imagen"];
                    //MemoryStream ms = new MemoryStream(img);
                    //Image foto = Image.FromStream(ms);

                    // Crear el objeto Usuario y agregarlo a la lista
                    Ejemplar ejemplar= new Ejemplar(id, fechaCompra, editorial, precioTotal, id_usuario,/* foto*/ isbn_usuario);
                    lista.Add(ejemplar);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }

        public static List<Ejemplar> BuscarEjemplares(MySqlConnection conexion, int id_usuario)
        {
            List<Ejemplar> lista = new List<Ejemplar>();
            string consulta = string.Format("SELECT * from ejemplar WHERE id_usuario='{0}'",id_usuario);

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
                    DateTime fechaCompra = reader.GetDateTime(1);
                    string editorial = reader.GetString(2);
                    decimal precioTotal = reader.GetDecimal(3);
                    int id_usu= reader.GetInt32(4);
                    string isbn_usuario = reader.GetString(5);

                    //byte[] img = (byte[])reader["imagen"];
                    //MemoryStream ms = new MemoryStream(img);
                    //Image foto = Image.FromStream(ms);

                    // Crear el objeto Usuario y agregarlo a la lista
                    Ejemplar ejemplar = new Ejemplar(id, fechaCompra, editorial, precioTotal, id_usu,/* foto*/ isbn_usuario);
                    lista.Add(ejemplar);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }

        public int AgregarEjemplar(MySqlConnection conexion, Ejemplar ej)
        {
            int retorno;
            //MemoryStream ms = new MemoryStream();
            //l1.Portada.Save(ms, ImageFormat.Png);
            //byte[] imgArr = ms.ToArray();

            string consulta = String.Format("INSERT INTO libro (id,fechaCompra,editorial,precioTotal,id_usuario,isbn_usuario) " +
                "VALUES " + "('{0}','{1}','{2}','{3}','{4}','{5}')", ej.Id, ej.fechaCompra, ej.Editorial, ej.PrecioTotal, ej.Id_usuario, ej.Isbn_usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //comando.Parameters.AddWithValue("imagen", imgArr);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int eliminarEjemplar(MySqlConnection conexion, int id)
        {
            int retorno;
            string consulta = String.Format("delete from ejemplar where id='{0}'", id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static bool EncontrarEjemplar(MySqlConnection conexion, int id)
        {
            string consulta = string.Format("SELECT id FROM ejemplar WHERE id = '{0}'", id);

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
    }
}

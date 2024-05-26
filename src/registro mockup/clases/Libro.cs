using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace registro_mockup.clases
{
    class Libro
    {
        string isbn;
        string titulo;
        string autor;
        string categoria;
        double valoracion;
        Image portada;
        string sinopsis;
        double precio;
        int cantidad;
        bool online;
        byte[] pdf;


        public string Isbn { get { return isbn; } set { isbn = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get { return autor; } set { autor = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public double Valoracion { get { return valoracion; } set { valoracion = value; } }
        public Image Portada { get { return portada; } set { portada = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public string Sinopsis { get { return sinopsis; }  }
        public int Cantidad { get { return cantidad; }set { cantidad = value; } }

        public bool Online {  get { return online; } set { online = value; } }
        public byte[] Pdf { get { return pdf; } }

        public Libro()
        {
            
        }
        public Libro(string isbn, string titulo, string autor, string categoria, double valoracion,Image portada, string sinopsis,double precio, byte[] pdf)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.categoria = categoria;
            this.valoracion = valoracion;
            this.portada = portada;
            this.sinopsis = sinopsis;
            this.precio = precio;
            this.pdf = pdf;
        }

        public Libro(string isbn, string titulo, string autor, string categoria, Image foto, double precio)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.categoria = categoria;
            this.precio = precio;
            this.portada = foto;
        }

        public static List<Libro> BuscarLibros(MySqlConnection conexion)
        {
            List<Libro> lista = new List<Libro>();
            string consulta = string.Format("SELECT * from libro");

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
                    string isbn = reader.GetString(0);
                    string titulo = reader.GetString(1);
                    string autor = reader.GetString(2);
                    string categoria = reader.GetString(3);
                    double valoracion = reader.GetDouble(4);
                    string sinopsis = reader.GetString(6);
                    double precio = reader.GetDouble(7);

                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    // Crear el objeto Usuario y agregarlo a la lista
                    Libro libro = new Libro(isbn, titulo, autor, categoria, valoracion,foto,sinopsis,precio, null);
                    lista.Add(libro);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }

        public static List<Libro> BuscarLibros(MySqlConnection conexion, string busqueda)
        {
            List<Libro> lista = new List<Libro>();
            string consulta = string.Format("SELECT * FROM libro WHERE autor LIKE '{0}%' OR titulo LIKE '{0}%' OR categoria LIKE '{0}%' OR isbn LIKE '{0}%'", busqueda);

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
                    string isbn = reader.GetString(0);
                    string titulo = reader.GetString(1);
                    string autor = reader.GetString(2);
                    string categoria = reader.GetString(3);
                    double valoracion = reader.GetDouble(4);
                    string sinopsis = reader.GetString(6);
                    double precio = reader.GetDouble(7);    
                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    // Crear el objeto Usuario y agregarlo a la lista
                    Libro libro = new Libro(isbn, titulo, autor, categoria, valoracion, foto, sinopsis, precio, null);
                    lista.Add(libro);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }

        public static List<Libro> BuscarLibrosBusqueda(MySqlConnection conexion, string busqueda)
        {
            List<Libro> lista = new List<Libro>();
            string consulta = string.Format("SELECT isbn,titulo,autor,categoria,imagen,precio FROM libro WHERE autor LIKE '{0}%' OR titulo LIKE '{0}%' OR categoria LIKE '{0}%' OR isbn LIKE '{0}%'", busqueda);

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
                    string isbn = reader.GetString(0);
                    string titulo = reader.GetString(1);
                    string autor = reader.GetString(2);
                    string categoria = reader.GetString(3);
                    double precio = reader.GetDouble(5);
                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);
                    
                    

                    // Crear el objeto Usuario y agregarlo a la lista
                    Libro libro = new Libro(isbn, titulo, autor, categoria, foto, precio);
                    lista.Add(libro);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }
        public int AgregarLibro(MySqlConnection conexion, Libro l1)
        {
            int retorno;
            MemoryStream ms = new MemoryStream();
            l1.Portada.Save(ms, ImageFormat.Png);
            byte[] imgArr = ms.ToArray();

            string consulta = String.Format("INSERT INTO libro (isbn,titulo,autor,categoria,valoracion,imagen,sinopsis,precio, pdf) " +
                "VALUES " + "('{0}','{1}','{2}','{3}','{4}', @imagen, '{5}','{6}', @pdf)", l1.Isbn, l1.Titulo,l1.Autor,l1.Categoria,l1.Valoracion,l1.Sinopsis,l1.Precio);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("imagen", imgArr);
            if (l1.Pdf != null)
            {
                comando.Parameters.AddWithValue("@pdf", l1.Pdf);
            }
            else
            {
                comando.Parameters.AddWithValue("@pdf", DBNull.Value);
            }
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static int eliminarLibro(MySqlConnection conexion, string isbn)
        {
            int retorno;
            string consulta = String.Format("delete from libro where isbn='{0}'", isbn);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static bool EncontrarLibro(MySqlConnection conexion, string isbn)
        {
            string consulta = string.Format("SELECT isbn FROM libro WHERE isbn = '{0}'", isbn);

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
        public static int EditarLibro(MySqlConnection conexion, Libro l1)
        {
            int retorno;
            MemoryStream ms = new MemoryStream();
            l1.Portada.Save(ms, ImageFormat.Jpeg);
            byte[] imgArr = ms.ToArray();
            string consulta = String.Format("UPDATE libro SET isbn = '{0}', titulo = '{1}', autor = '{2}', categoria = '{3}', valoracion = '{4}', imagen=@imagen , sinopsis = '{5}', precio = '{6}', pdf=@pdf " +
                                            "WHERE isbn = '{0}'", l1.Isbn, l1.Titulo, l1.Autor, l1.Categoria, l1.Valoracion, l1.Sinopsis, l1.Precio);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@imagen", imgArr);

            // Asignamos el valor del campo pdf solo si no es nulo
            if (l1.Pdf != null)
            {
                comando.Parameters.AddWithValue("@pdf", l1.Pdf);
            }
            else
            {
                comando.Parameters.AddWithValue("@pdf", DBNull.Value);
            }

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static Libro EncontrarDatosLibro(MySqlConnection conexion, string isbn)
        {
            string consulta = string.Format("SELECT * FROM libro WHERE isbn = '{0}'", isbn);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            Libro l1 = new Libro();
            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de empleados.
                while (reader.Read())
                {
                    
                    string codigo = reader.GetString(0);
                    string titulo = reader.GetString(1);
                    string autor = reader.GetString(2);
                    string categoria = reader.GetString(3);
                    double valoracion = reader.GetDouble(4);
                    string sinopsis = reader.GetString(6);  
                    double precio = reader.GetDouble(7);
                    byte[] img = (byte[])reader["imagen"];
                    byte[] pdf = null;
                    if (!reader.IsDBNull(reader.GetOrdinal("pdf")))
                    {
                        pdf = (byte[])reader["pdf"];
                    }

                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    l1 =new Libro(codigo,titulo, autor,categoria, valoracion, foto,sinopsis, precio, pdf);
                }


            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return l1;
        }

        public static Libro EncontrarDatosLibroTitulo(MySqlConnection conexion, string tituloLibro)
        {
            string consulta = string.Format("SELECT * FROM libro WHERE titulo = '{0}'", tituloLibro);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            Libro l1 = new Libro();
            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de empleados.
                while (reader.Read())
                {

                    string codigo = reader.GetString(0);
                    string titulo = reader.GetString(1);
                    string autor = reader.GetString(2);
                    string categoria = reader.GetString(3);
                    double valoracion = reader.GetDouble(4);
                    string sinopsis = reader.GetString(6);
                    double precio = reader.GetDouble(7);
                    byte[] pdf = null;
                    if (reader["pdf"] != DBNull.Value)
                    {
                        pdf = (byte[])reader["pdf"];
                    }
                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    l1 = new Libro(codigo, titulo, autor, categoria, valoracion, foto, sinopsis, precio, pdf);
                }


            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return l1;
        }

        public double importeTotal(double precio, int cantidad)
        {
            return precio * cantidad;
        }
    }
}

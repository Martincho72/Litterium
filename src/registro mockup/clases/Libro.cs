using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace registro_mockup.clases
{
    internal class Libro
    {
        string isbn;
        string titulo;
        string autor;
        string categoria;
        double valoracion;

        public string Isbn { get { return isbn; } }
        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public string Categoria { get { return categoria; } }
        public double Valoracion { get { return valoracion; } }


        public Libro()
        {
            
        }
        public Libro(string isbn, string titulo, string autor, string categoria, double valoracion)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.categoria = categoria;
            this.valoracion = valoracion;
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

                    // Crear el objeto Usuario y agregarlo a la lista
                    Libro libro = new Libro(isbn, titulo, autor, categoria, valoracion);
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
            string consulta = String.Format("INSERT INTO libro (isbn,titulo,autor,categoria,valoracion) " +
                "VALUES " + "('{0}','{1}','{2}','{3}','{4}')", l1.Isbn, l1.Titulo,l1.Autor,l1.Categoria,l1.Valoracion);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

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
            string consulta = String.Format("UPDATE libro SET isbn = '{0}', titulo = '{1}', autor = '{2}', categoria = '{3}', valoracion = '{4}'" +
                                            "WHERE isbn = '{0}'", l1.Isbn, l1.Titulo, l1.Autor, l1.Categoria, l1.Valoracion);
                                         
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

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

                    l1=new Libro(codigo,titulo, autor,categoria, valoracion);
                }


            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return l1;
        }
    }
}

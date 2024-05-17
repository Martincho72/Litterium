using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace registro_mockup.clases
{
    internal class CortoHistoria
    {
        int id = 0;
        string titulo;
        string autor;
        DateTime fechaPublicacion;
        string editorial;
        bool continuable;
        bool finalizada;
        double valoracion;
        int id_usuario;

        public int Id { get { return id; } }
        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public DateTime FechaPublicacion { get { return fechaPublicacion; } }
        public string Editorial { get { return editorial; } }
        public bool Continuable { get { return continuable; } }
        public bool Finalizada { get { return finalizada; } }
        public double Valoracion { get { return valoracion; } }
        public int Id_usuario { get { return id_usuario; } }

        public CortoHistoria(int id, string titulo, string autor, DateTime fechaPublicacion, string editorial, bool continuable, bool finalizada, double valoracion, int id_usuario)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.fechaPublicacion = fechaPublicacion;
            this.editorial = editorial;
            this.continuable = continuable;
            this.finalizada = finalizada;
            this.valoracion = valoracion;
            this.id_usuario = id_usuario;
        }

        public static List<Libro> BuscarCortoHistoria(MySqlConnection conexion)
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
        public int AgregarCortoHistoria(MySqlConnection conexion, Libro l1)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO libro (isbn,titulo,autor,categoria,valoracion) " +
                "VALUES " + "('{0}','{1}','{2}','{3}','{4}')", l1.Isbn, l1.Titulo, l1.Autor, l1.Categoria, l1.Valoracion);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static int eliminarCortoHistoria(MySqlConnection conexion, string isbn)
        {
            int retorno;
            string consulta = String.Format("delete from libro where isbn='{0}'", isbn);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

    }
}

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

        public static List<CortoHistoria> BuscarCortoHistoria(MySqlConnection conexion)
        {
            List<CortoHistoria> lista = new List<CortoHistoria>();
            string consulta = string.Format("SELECT * from cortohistoria");

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
                    string titulo = reader.GetString(1);
                    string autor = reader.GetString(2);
                    DateTime fecha = reader.GetDateTime(3);
                    string editorial = reader.GetString(4);
                    bool continuable = reader.GetBoolean(5);
                    bool finalizada = reader.GetBoolean(6);
                    double valoracion = reader.GetDouble(7);
                    int id_usuario = reader.GetInt32(8);

                    // Crear el objeto Usuario y agregarlo a la lista
                    CortoHistoria ch = new CortoHistoria(id, titulo, autor, fecha, editorial,continuable,finalizada,valoracion,id_usuario);
                    lista.Add(ch);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }
        public int AgregarCortoHistoria(MySqlConnection conexion, CortoHistoria ch)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO cortohistoria (id,titulo,autor,fechaPublicacion,editorial,continuable,finalizada,valoracion,id_usuario) " +
                "VALUES " + "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", ch.Id, ch.Titulo, ch.Autor, ch.FechaPublicacion, ch.Editorial, ch.Continuable, ch.Finalizada, ch.Valoracion, ch.Id_usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static int eliminarCortoHistoria(MySqlConnection conexion, int id)
        {
            int retorno;
            string consulta = String.Format("Delete from cortohistoria where id='{0}'", id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static bool EncontrarCortoHistoria(MySqlConnection conexion, int id)
        {
            string consulta = string.Format("SELECT id FROM cortohistoria WHERE id = '{0}'", id);

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

        public static int EditarCortoHistoria(MySqlConnection conexion, Libro l1)
        {
            int retorno;
            string consulta = String.Format("UPDATE cortohistoria SET id = '{0}', titulo = '{1}', autor = '{2}', fechaPublicacion = '{3}', editorial = '{4}', continuable = '{5}', finalizada = '{6}', valoracion = '{7}'" +
                                            "WHERE isbn = '{0}'", l1.Isbn, l1.Titulo, l1.Autor, l1.Categoria, l1.Valoracion);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }

    }
}

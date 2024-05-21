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
        string categoria;
        bool continuable;
        bool finalizada;
        double valoracion;
        int id_usuario;

        public int Id { get { return id; } }
        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public DateTime FechaPublicacion { get { return fechaPublicacion; } }
        public string Categoria { get { return categoria; } }
        public bool Continuable { get { return continuable; } }
        public bool Finalizada { get { return finalizada; } }
        public double Valoracion { get { return valoracion; } }
        public int Id_usuario { get { return id_usuario; } }

        public CortoHistoria(int id, string titulo, string autor, DateTime fechaPublicacion, string categoria, bool continuable, bool finalizada, double valoracion, int id_usuario)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.fechaPublicacion = fechaPublicacion;
            this.categoria = categoria;
            this.continuable = continuable;
            this.finalizada = finalizada;
            this.valoracion = valoracion;
            this.id_usuario = id_usuario;
        }

        public CortoHistoria(string titulo, string autor, DateTime fechaPublicacion,bool finalizada,int id_usuario) //Constructor para Mis CortoHistorias de Usuario
        {
            this.titulo= titulo;
            this.autor= autor;
            this.fechaPublicacion= fechaPublicacion;
            this.finalizada = finalizada;
            this.id_usuario= id_usuario;
        }
        public CortoHistoria(int id,string titulo, string autor, DateTime fechaPublicacion, string categoria, bool continuable, bool finalizada) //Constructor para Mis CortoHistorias de Usuario
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.fechaPublicacion = fechaPublicacion;
            this.categoria = categoria;
            this.continuable = continuable;
            this.finalizada = finalizada;
        }

        public CortoHistoria()
        {
            
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

        public static List<CortoHistoria> BuscarCortoHistoria(MySqlConnection conexion, string busqueda) //Metodo sobrecargado para busqueda
        {
            List<CortoHistoria> lista = new List<CortoHistoria>();
            string consulta = string.Format("SELECT * from cortohistoria WHERE autor='{0}' OR titulo='{0}' OR categoria='{0}'",busqueda);

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
                    CortoHistoria ch = new CortoHistoria(id, titulo, autor, fecha, editorial, continuable, finalizada, valoracion, id_usuario);
                    lista.Add(ch);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }

        public static List<CortoHistoria> BuscarCortoHistoriaUsuario(MySqlConnection conexion,int id_usu) //Mis CortoHistorias Usuario
        {
            List<CortoHistoria> lista = new List<CortoHistoria>();
            string consulta = string.Format("SELECT titulo,autor,fechaPublicacion,finalizada,id_usuario from cortohistoria WHERE id_usuario='{0}'",id_usu);

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
                    string titulo = reader.GetString(0);
                    string autor = reader.GetString(1);
                    DateTime fecha = reader.GetDateTime(2);
                    bool finalizada = reader.GetBoolean(3);
                    int id_usuario = reader.GetInt32(4);

                    // Crear el objeto Usuario y agregarlo a la lista
                    CortoHistoria ch = new CortoHistoria(titulo, autor, fecha,finalizada, id_usuario);
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
                "VALUES " + "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", ch.Id, ch.Titulo, ch.Autor, ch.FechaPublicacion.ToString("yyyy-MM-dd"), ch.Categoria, ch.Continuable, ch.Finalizada, ch.Valoracion, ch.Id_usuario);

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

        public static int EditarCortoHistoria(MySqlConnection conexion, CortoHistoria ch)
        {
            int continuable;
            int finalizada;
            if (ch.continuable) continuable = 1;
            else continuable = 0;
            if (ch.finalizada) finalizada = 1;
            else finalizada = 0;
            
            int retorno;
            string consulta = String.Format("UPDATE cortohistoria SET id = '{0}', titulo = '{1}', autor = '{2}', fechaPublicacion = '{3}', categoria = '{4}', continuable = '{5}', finalizada = '{6}', valoracion = '{7}', id_usuario ='{8}'" +
                                            "WHERE id = '{0}'", ch.Id, ch.Titulo, ch.Autor, ch.FechaPublicacion.ToString("yyyy-MM-dd"), ch.Categoria,continuable,finalizada,ch.Valoracion,ch.Id_usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }

        public static CortoHistoria EncontrarDatosCortoHistoria(MySqlConnection conexion, int id)
        {
            string consulta = string.Format("SELECT * FROM cortohistoria WHERE id = '{0}'", id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            CortoHistoria ch = new CortoHistoria();
            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de empleados.
                while (reader.Read())
                {

                    int idch = reader.GetInt32(0);
                    string titulo = reader.GetString(1);
                    string autor = reader.GetString(2);
                    DateTime fecha = reader.GetDateTime(3);
                    string editorial = reader.GetString(4);
                    bool continuable = reader.GetBoolean(5);
                    bool finalizada = reader.GetBoolean(6);
                    double valoracion = reader.GetDouble(7);
                    int id_usuario = reader.GetInt32(8);

                    // Crear el objeto Usuario y agregarlo a la lista
                    ch = new CortoHistoria(idch, titulo, autor, fecha, editorial, continuable, finalizada, valoracion, id_usuario);
                }


            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return ch;
        }
        public static List<CortoHistoria> BuscarBorradores(MySqlConnection conexion,int idUsuario)
        {
            List<CortoHistoria> lista = new List<CortoHistoria>();
            string consulta = string.Format("SELECT id, titulo, autor, fechaPublicacion, categoria, continuable, finalizada from cortohistoria where finalizada = 0 and id_usuario = {0}", idUsuario);

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
                    string categoria = reader.GetString(4);
                    bool continuable = reader.GetBoolean(5);
                    bool finalizada = reader.GetBoolean(6);
             //       double valoracion = reader.GetDouble(7);

                    // Crear el objeto Usuario y agregarlo a la lista
                    CortoHistoria ch = new CortoHistoria(id, titulo, autor, fecha, categoria, continuable, finalizada);
                    lista.Add(ch);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }

    }
}

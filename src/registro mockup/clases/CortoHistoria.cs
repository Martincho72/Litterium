using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;


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
        int id_usuario;
        Image portada;
        string texto;
        private DateTime fecha;
        private int idUsuario;
        private Image foto;

        public int Id { get { return id; } }
        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public DateTime FechaPublicacion { get { return fechaPublicacion; } }
        public string Categoria { get { return categoria; } }
        public bool Continuable { get { return continuable; } }
        public bool Finalizada { get { return finalizada; } }
        public int Id_usuario { get { return id_usuario; } }
        public Image Portada { get { return portada; } }
        public string Texto {  get { return texto; } }

        

        //Ver mis cortohiatori
        public CortoHistoria(string titulo,string autor,DateTime fecha,string categoria,bool continuable,bool finalizada,Image foto)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaPublicacion = fecha;
            this.categoria = categoria;
            this.continuable = continuable;
            this.finalizada = finalizada;
            this.portada = foto;
        }

        public CortoHistoria(string titulo, string autor, DateTime fecha, bool continuable, bool finalizada, int id_usuario, Image foto)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fecha = fecha;
            this.continuable = continuable;
            this.finalizada = finalizada;
            this.idUsuario = id_usuario;
            this.portada = foto;

        }
        //Usuario agrega cortohistoria
        public CortoHistoria(string titulo, string autor, DateTime fechaPublicacion, string categoria,bool continuable,bool finalizada, int id_usuario,Image portada,string texto) 
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaPublicacion = fechaPublicacion;
            this.categoria = categoria;
            this.continuable = continuable;
            this.finalizada = finalizada;
            this.id_usuario = id_usuario;
            this.portada = portada;
            this.texto = texto;
        }

        public CortoHistoria(int id,string titulo, string autor, DateTime fechaPublicacion, string categoria, bool continuable, bool finalizada, int id_usuario, Image portada,string texto) 
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.fechaPublicacion = fechaPublicacion;
            this.categoria = categoria;
            this.continuable = continuable;
            this.finalizada = finalizada;
            this.id_usuario = id_usuario;
            this.portada = portada;
            this.texto = texto;
                
        }

        public CortoHistoria()
        {
            
        }
     

        public CortoHistoria(string titulo, string autor, DateTime fecha, string categoria, bool continuable, int idUsuario, Image foto)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fecha = fecha;
            this.categoria = categoria;
            this.continuable = continuable;
            this.idUsuario = idUsuario;
            this.foto = foto;
        }

        public CortoHistoria(string titulo, string autor, DateTime fechaPublicacion, string categoria, Image foto)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaPublicacion = fechaPublicacion;
            this.categoria = categoria;
            this.foto = foto;
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
                    string categoria = reader.GetString(4);
                    bool continuable = reader.GetBoolean(5);
                    bool finalizada = reader.GetBoolean(6);
                    int id_usuario = reader.GetInt32(7);
                    string texto=reader.GetString(9);

                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);
                    // Crear el objeto Usuario y agregarlo a la lista
                    CortoHistoria ch = new CortoHistoria(id, titulo, autor, fecha,categoria,continuable,finalizada,id_usuario,foto,texto);
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
            string consulta = string.Format("SELECT * FROM cortohistoria WHERE autor LIKE '{0}%' OR titulo LIKE '{0}%' OR categoria LIKE '{0}%'", busqueda);

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
                    string titulo = reader.GetString(1);
                    string autor = reader.GetString(2);
                    DateTime fecha = reader.GetDateTime(3);
                    bool continuable = reader.GetBoolean(5);
                    bool finalizada = reader.GetBoolean(6);
                    int id_usuario = reader.GetInt32(8);

                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    // Crear el objeto Usuario y agregarlo a la lista
                    CortoHistoria ch = new CortoHistoria(titulo, autor, fecha, continuable, finalizada, id_usuario, foto);
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
            string consulta = string.Format("SELECT  titulo, autor, fechaPublicacion, categoria, continuable, finalizada, imagen from cortohistoria where id_usuario = {0} and finalizada=1", id_usu);

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
                    string categoria = reader.GetString(3);
                    bool continuable = reader.GetBoolean(4);
                    bool finalizada = reader.GetBoolean(5);
                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms); ;



                    // Crear el objeto Usuario y agregarlo a la lista
                    CortoHistoria ch = new CortoHistoria(titulo,autor, fecha, categoria, continuable, finalizada,foto);
                    lista.Add(ch);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }
        public int AgregarCortoHistoria(MySqlConnection conexion, CortoHistoria ch)
        {
            int continuable = 0;
            int finalizada = 0;
            if (ch.continuable) continuable = 1;
            if (ch.finalizada) finalizada = 1;
            int retorno;
            MemoryStream ms = new MemoryStream();
            ch.Portada.Save(ms, ImageFormat.Png);
            byte[] imgArr = ms.ToArray();
            string consulta = String.Format("INSERT INTO cortohistoria (titulo,autor,fechaPublicacion,categoria,continuable,finalizada,id_usuario,imagen,texto) " +
                "VALUES " + "('{0}','{1}','{2}','{3}','{4}','{5}','{6}',@imagen,'{7}')", ch.Titulo, ch.Autor, ch.FechaPublicacion.ToString("yyyy-MM-dd"), 
                ch.Categoria, continuable, finalizada,ch.Id_usuario,ch.Texto);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("imagen", imgArr);
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
            int continuable=0;
            int finalizada=0;
            if (ch.continuable) continuable = 1;
            if (ch.finalizada) finalizada = 1;

            MemoryStream ms = new MemoryStream();
            ch.Portada.Save(ms, ImageFormat.Png);
            byte[] imgArr = ms.ToArray();
            int retorno;
            string consulta = String.Format("UPDATE cortohistoria SET  titulo = '{0}', autor = '{1}', fechaPublicacion = '{2}', categoria = '{3}', continuable = '{4}', finalizada = '{5}', id_usuario ='{6}' , imagen=@imagen, texto='{7}' " +
                                            "WHERE id = '{8}'",  ch.Titulo, ch.Autor, ch.FechaPublicacion.ToString("yyyy-MM-dd"), ch.Categoria,continuable,finalizada,ch.Id_usuario,ch.Texto,ch.Id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@imagen", imgArr);
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
                    string categoria = reader.GetString(4);
                    bool continuable = reader.GetBoolean(5);
                    bool finalizada = reader.GetBoolean(6);
                    int id_usuario = reader.GetInt32(7);
                    string texto = reader.GetString(9);

                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    // Crear el objeto Usuario y agregarlo a la lista
                    ch = new CortoHistoria(idch, titulo, autor, fecha,categoria, continuable, finalizada, id_usuario, foto,texto);
                }


            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return ch;
        }

        public static CortoHistoria EncontrarDatosCortoHistoria(MySqlConnection conexion, string tituloch)
        {
            string consulta = string.Format("SELECT * FROM cortohistoria WHERE titulo = '{0}'", tituloch);

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
                    string categoria = reader.GetString(4);
                    bool continuable = reader.GetBoolean(5);
                    bool finalizada = reader.GetBoolean(6);
                    int id_usuario = reader.GetInt32(7);
                    string texto = reader.GetString(9);

                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    // Crear el objeto Usuario y agregarlo a la lista
                    ch = new CortoHistoria(idch, titulo, autor, fecha, categoria, continuable, finalizada, id_usuario, foto, texto);
                }


            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return ch;
        }
        public static List<CortoHistoria> BuscarBorradores(MySqlConnection conexion,int id_usu)
        {
            List<CortoHistoria> lista = new List<CortoHistoria>();
            string consulta = string.Format("SELECT  titulo, autor, fechaPublicacion, categoria, continuable, finalizada, imagen from cortohistoria where id_usuario = {0} and finalizada =0", id_usu);

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
                    string categoria = reader.GetString(3);
                    bool continuable = reader.GetBoolean(4);
                    bool finalizada = reader.GetBoolean(5);
                    byte[] img = (byte[])reader["imagen"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms); ;



                    // Crear el objeto Usuario y agregarlo a la lista
                    CortoHistoria ch = new CortoHistoria(titulo, autor, fecha, categoria, continuable, finalizada, foto);
                    lista.Add(ch);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }


        public static List<string> EncontrarCortoHistoriasRecientes(MySqlConnection conexion)
        {
            List<string> lista = new List<string>();
            string consulta = string.Format("SELECT titulo FROM cortohistoria ORDER BY id desc");

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
                    lista.Add(titulo);
                }

            }
            // devolvemos la lista cargada con los usuarios.
            reader.Close();
            return lista;
        }
        /*public static List<CortoHistoria> BuscarCortoHistoriasUsuario(MySqlConnection conexion, int idUsuario)
        {
            List<CortoHistoria> lista = new List<CortoHistoria>();
            string consulta = string.Format("SELECT id, titulo, autor, fechaPublicacion, categoria, continuable, finalizada from cortohistoria where id_usuario = {0}", idUsuario);

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
        }*/

    }
}

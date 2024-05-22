using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_mockup.clases
{
    internal class Valoracion
    {
        string isbnLibro;
        int idUsuario;
        int valoracion;


        public Valoracion()
        {

        }

        public static int insertarValoracion(MySqlConnection conexion, string isbn, int idusuario, int valoracion)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO Valoraciones (isbnLibro,idUsuario,valoracion) " +
                "VALUES " + "('{0}','{1}','{2}')", isbn, idusuario, valoracion);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static bool EncontrarValoracion(MySqlConnection conexion, int idUs, string isbn)
        {
            string consulta = string.Format("SELECT * FROM Valoraciones WHERE idUsuario = '{0}' and isbnLibro = '{1}'", idUs,isbn);

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

        public static int EditarValoracion(MySqlConnection conexion, int idUusario, string isbnLibro, int valoracion)
        {
            int retorno;

            string consulta = String.Format("UPDATE Valoraciones SET valoracion = '{0}' WHERE isbnLibro = '{1}' and idUsuario = '{2}'", valoracion, isbnLibro,idUusario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static List<string> librosMasValorados(MySqlConnection conexion) 
        {
            List<string> lista = new List<string>();
            string consulta = string.Format("SELECT titulo FROM libro ORDER BY valoracion desc");

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
    }
    }

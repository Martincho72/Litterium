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
    }
    }

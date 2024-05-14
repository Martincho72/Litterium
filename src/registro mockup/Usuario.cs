using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace registro_mockup
{
    internal class Usuario
    {
        int id=0;
        string usuario;
        string clave;
        bool esAdmin;
        string nombre;
        string correoElectronico;
        string direccion;
        int telefono;
        bool vetado;
        bool baja;



        public static bool EncontrarUsuario(MySqlConnection conexion, string usuario)
        {
            string consulta = string.Format("SELECT usuario FROM empleados WHERE usuario = '{0}'", usuario);

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

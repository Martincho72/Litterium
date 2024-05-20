using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace registro_mockup
{
    internal class BDatos
    {

        private MySqlConnection conexion;

        public MySqlConnection Conexion { get { return conexion; } }

        public BDatos() { 
                // Conexión Local
                string server = "server=sql7.freesqldatabase.com;";
                string port = "port=3306;";
                string database = "database=sql7707748;";
                string usuario = "uid=sql7707748;";
                string password = "pwd=pfAYYE6jhC;";
                string convert = "Convert Zero Datetime=true;";
                string connectionstring = server + port + database + usuario + password + convert;

                conexion = new MySqlConnection(connectionstring);
            }

            public bool AbrirConexion()
            {
                try
                {
                    conexion.Open();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }

            public bool CerrarConexion()
            {
                try
                {
                    conexion.Close();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }
        }
    }



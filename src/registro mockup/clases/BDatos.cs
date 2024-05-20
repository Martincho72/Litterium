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
                string server = "server=database-1.c2x0fjvt1inr.us-east-1.rds.amazonaws.com;";
                string port = "port=3306;";
                string database = "database=litterium;";
                string usuario = "uid=admin;";
                string password = "pwd=testtest;";
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



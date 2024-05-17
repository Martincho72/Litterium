using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace registro_mockup.clases
{
    internal static class Correo
    {
        public static int NuevaContrasena()
        {
            int nuevaContrasena;
            Random rand = new Random();

            nuevaContrasena = rand.Next(10000, 100000);
            return nuevaContrasena;
        }

        public static  bool ActualizarContrasena(MySqlConnection conexion, string correo, int nuevaContrasena)
        {
            try
            {
                string consulta = "UPDATE usuarios SET contrasenya = @nuevaContrasena WHERE correo = @correo";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nuevaContrasena", nuevaContrasena);
                    comando.Parameters.AddWithValue("@correo", correo);

                    int rowsAffected = comando.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }


        public static bool validarCorreo(MySqlConnection conexion, string correo)
        {

            bool validador = false;
            string consulta = string.Format("SELECT correo FROM usuarios where correo='{0}'", correo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (correo == reader.GetString(0)) { validador = true; }
                }
            }
            reader.Close();
            return validador;
        }

        public static void enviarCorreo(string enlace,int nuevacontrasena,MailMessage correo,string destinatario)
        {
            correo.From = new MailAddress("ayudalitterium@outlook.com", "Litteriumsupport", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add(destinatario);
            correo.Subject = "Restablecer Contraseña"; //Asunto
            correo.Body = "<p>Tu nueva contraseña es: " + nuevacontrasena + "<br>Para cambiar su contraseña haga click en este enlace:<a href=" + enlace + ">" + enlace + "</a>"; //Mensaje del correo
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp-mail.outlook.com"; //Host del servidor de correo
            smtp.Port = 587; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential("ayudalitterium@outlook.com", "Litterium2024");//Cuenta de correo
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            smtp.Send(correo);
        }
    }
}

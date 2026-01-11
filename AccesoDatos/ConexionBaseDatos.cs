using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaZamaca.AccesoDatos
{
    public class ConexionBaseDatos

    {

        private static string connectionString = "Server=localhost;Database=ligafutbol;Uid=root;Pwd=;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public static bool ProbarConexion()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return connection.State == System.Data.ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
        
    }

}

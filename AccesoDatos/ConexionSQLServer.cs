using System;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace LigaZamaca.AccesoDatos
{
    /// <summary>
    /// Clase para gestionar la conexión a SQL Server
    /// </summary>
    public class ConexionSQLServer
    {
        #region Cadena de Conexión


        private static string connectionString = ConfigurationManager.ConnectionStrings["LigaConexion"].ConnectionString;


        #endregion

        #region Métodos de Conexión

        /// <summary>
        /// Obtiene una nueva conexión a SQL Server
        /// </summary>
        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectar con SQL Server: {ex.Message}");
            }
        }

        /// <summary>
        /// Prueba la conexión a SQL Server
        /// </summary>
        public static bool ProbarConexion()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
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

        /// <summary>
        /// Obtiene información detallada del estado de la conexión
        /// </summary>
        public static string ObtenerEstadoConexion()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        // Obtener versión de SQL Server
                        using (SqlCommand cmd = new SqlCommand("SELECT @@VERSION", connection))
                        {
                            string version = cmd.ExecuteScalar()?.ToString() ?? "Desconocida";

                            // Extraer solo la parte importante de la versión
                            if (version.Contains("Microsoft SQL Server"))
                            {
                                int inicio = version.IndexOf("Microsoft SQL Server");
                                int fin = version.IndexOf("-", inicio);
                                if (fin > inicio)
                                    version = version.Substring(inicio, fin - inicio).Trim();
                            }

                            return $"✅ Conexión exitosa\n" +
                                   $"Servidor: {connection.DataSource}\n" +
                                   $"Base de datos: {connection.Database}\n" +
                                   $"Versión: {version}";
                        }
                    }
                    else
                    {
                        return "❌ No se pudo establecer la conexión";
                    }
                }
            }
            catch (SqlException ex)
            {
                // Errores específicos de SQL Server
                string mensaje = "❌ Error de conexión SQL Server:\n\n";

                switch (ex.Number)
                {
                    case -1:
                    case -2:
                        mensaje += "No se puede conectar al servidor.\n" +
                                  "Verifica que SQL Server esté ejecutándose.\n" +
                                  "Verifica el nombre del servidor (localhost, .\\SQLEXPRESS, etc.)";
                        break;
                    case 4060:
                        mensaje += "La base de datos 'LigaFutbol' no existe.\n" +
                                  "Ejecuta el script CrearBD_SQLServer_Prueba.sql primero.";
                        break;
                    case 18456:
                        mensaje += "Error de autenticación.\n" +
                                  "Verifica usuario y contraseña.\n" +
                                  "O usa Integrated Security=true para Windows Authentication.";
                        break;
                    default:
                        mensaje += $"Código de error: {ex.Number}\n" +
                                  $"Mensaje: {ex.Message}";
                        break;
                }

                return mensaje;
            }
            catch (Exception ex)
            {
                return $"❌ Error general: {ex.Message}";
            }
        }

        /// <summary>
        /// Verifica si la base de datos existe
        /// </summary>
        public static bool ExisteBaseDatos()
        {
            try
            {
                // Usar un generador de cadenas de conexión para cambiar de base de datos de forma segura
                var builder = new SqlConnectionStringBuilder(connectionString);
                builder.InitialCatalog = "master";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM sys.databases WHERE name = 'LigaFutbol'";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene el número de tablas en la base de datos
        /// </summary>
        public static int ObtenerNumeroTablas()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        #endregion

        #region Métodos de Configuración

        /// <summary>
        /// Configura la cadena de conexión
        /// </summary>
        public static void ConfigurarConexion(string servidor, string baseDatos, bool windowsAuth,
                                              string usuario = "", string contraseña = "")
        {
            if (windowsAuth)
            {
                connectionString = $"Server={servidor};Database={baseDatos};Integrated Security=true;TrustServerCertificate=true;";
            }
            else
            {
                connectionString = $"Server={servidor};Database={baseDatos};User Id={usuario};Password={contraseña};TrustServerCertificate=true;";
            }
        }

        /// <summary>
        /// Obtiene la cadena de conexión actual (sin mostrar la contraseña)
        /// </summary>
        public static string ObtenerCadenaConexionSegura()
        {
            if (connectionString.Contains("Password="))
            {
                string temp = connectionString;
                int inicio = temp.IndexOf("Password=") + 9;
                int fin = temp.IndexOf(";", inicio);
                if (fin > inicio)
                {
                    string password = temp.Substring(inicio, fin - inicio);
                    temp = temp.Replace($"Password={password}", "Password=****");
                }
                return temp;
            }
            return connectionString;
        }

        #endregion
    }
}
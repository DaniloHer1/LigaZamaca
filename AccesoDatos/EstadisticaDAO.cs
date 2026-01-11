using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LigaZamaca.Modelos;

namespace LigaZamaca.AccesoDatos
{
    /// <summary>
    /// Clase DAO para gestionar operaciones CRUD de Estadísticas en SQL Server
    /// </summary>
    public class EstadisticaDAO
    {
        #region CREATE - Insertar

        /// <summary>
        /// Inserta una nueva estadística en la base de datos
        /// </summary>
        public int Insertar(Estadistica estadistica)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Estadisticas 
                                    (IdJugador, IdPartido, Goles, TarjetasAmarillas, TarjetasRojas, 
                                     Asistencias, MinutosJugados, Titular) 
                                    VALUES 
                                    (@IdJugador, @IdPartido, @Goles, @TarjetasAmarillas, @TarjetasRojas, 
                                     @Asistencias, @MinutosJugados, @Titular);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdJugador", estadistica.IdJugador);
                        cmd.Parameters.AddWithValue("@IdPartido", estadistica.IdPartido);
                        cmd.Parameters.AddWithValue("@Goles", estadistica.Goles);
                        cmd.Parameters.AddWithValue("@TarjetasAmarillas", estadistica.TarjetasAmarillas);
                        cmd.Parameters.AddWithValue("@TarjetasRojas", estadistica.TarjetasRojas);
                        cmd.Parameters.AddWithValue("@Asistencias", estadistica.Asistencias);
                        cmd.Parameters.AddWithValue("@MinutosJugados", estadistica.MinutosJugados);
                        cmd.Parameters.AddWithValue("@Titular", estadistica.Titular);

                        int idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                        return idGenerado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar estadística: {ex.Message}");
            }
        }

        #endregion

        #region READ - Consultar

        /// <summary>
        /// Obtiene todas las estadísticas
        /// </summary>
        public List<Estadistica> ObtenerTodas()
        {
            List<Estadistica> estadisticas = new List<Estadistica>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdEstadistica, IdJugador, IdPartido, Goles, 
                                           TarjetasAmarillas, TarjetasRojas, Asistencias, 
                                           MinutosJugados, Titular, FechaRegistro 
                                    FROM Estadisticas 
                                    ORDER BY IdPartido DESC, Goles DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            estadisticas.Add(MapearEstadistica(reader));
                        }
                    }
                }

                return estadisticas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener estadísticas: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene una estadística por su ID
        /// </summary>
        public Estadistica ObtenerPorId(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdEstadistica, IdJugador, IdPartido, Goles, 
                                           TarjetasAmarillas, TarjetasRojas, Asistencias, 
                                           MinutosJugados, Titular, FechaRegistro 
                                    FROM Estadisticas 
                                    WHERE IdEstadistica = @IdEstadistica";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEstadistica", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapearEstadistica(reader);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener estadística: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene todas las estadísticas de un jugador
        /// </summary>
        public List<Estadistica> ObtenerPorJugador(int idJugador)
        {
            List<Estadistica> estadisticas = new List<Estadistica>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdEstadistica, IdJugador, IdPartido, Goles, 
                                           TarjetasAmarillas, TarjetasRojas, Asistencias, 
                                           MinutosJugados, Titular, FechaRegistro 
                                    FROM Estadisticas 
                                    WHERE IdJugador = @IdJugador 
                                    ORDER BY IdPartido DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdJugador", idJugador);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estadisticas.Add(MapearEstadistica(reader));
                            }
                        }
                    }
                }

                return estadisticas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener estadísticas del jugador: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene todas las estadísticas de un partido
        /// </summary>
        public List<Estadistica> ObtenerPorPartido(int idPartido)
        {
            List<Estadistica> estadisticas = new List<Estadistica>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdEstadistica, IdJugador, IdPartido, Goles, 
                                           TarjetasAmarillas, TarjetasRojas, Asistencias, 
                                           MinutosJugados, Titular, FechaRegistro 
                                    FROM Estadisticas 
                                    WHERE IdPartido = @IdPartido 
                                    ORDER BY Titular DESC, Goles DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPartido", idPartido);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estadisticas.Add(MapearEstadistica(reader));
                            }
                        }
                    }
                }

                return estadisticas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener estadísticas del partido: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene estadísticas totales de un jugador
        /// </summary>
        public Dictionary<string, object> ObtenerEstadisticasTotalesJugador(int idJugador)
        {
            Dictionary<string, object> totales = new Dictionary<string, object>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        COUNT(*) AS PartidosJugados,
                                        SUM(CASE WHEN Titular = 1 THEN 1 ELSE 0 END) AS PartidosTitular,
                                        ISNULL(SUM(Goles), 0) AS TotalGoles,
                                        ISNULL(SUM(Asistencias), 0) AS TotalAsistencias,
                                        ISNULL(SUM(TarjetasAmarillas), 0) AS TotalAmarillas,
                                        ISNULL(SUM(TarjetasRojas), 0) AS TotalRojas,
                                        ISNULL(SUM(MinutosJugados), 0) AS MinutosTotales,
                                        ISNULL(AVG(CAST(Goles AS FLOAT)), 0) AS PromedioGoles
                                    FROM Estadisticas 
                                    WHERE IdJugador = @IdJugador";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdJugador", idJugador);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totales["PartidosJugados"] = reader.GetInt32(reader.GetOrdinal("PartidosJugados"));
                                totales["PartidosTitular"] = reader.GetInt32(reader.GetOrdinal("PartidosTitular"));
                                totales["TotalGoles"] = reader.GetInt32(reader.GetOrdinal("TotalGoles"));
                                totales["TotalAsistencias"] = reader.GetInt32(reader.GetOrdinal("TotalAsistencias"));
                                totales["TotalAmarillas"] = reader.GetInt32(reader.GetOrdinal("TotalAmarillas"));
                                totales["TotalRojas"] = reader.GetInt32(reader.GetOrdinal("TotalRojas"));
                                totales["MinutosTotales"] = reader.GetInt32(reader.GetOrdinal("MinutosTotales"));
                                totales["PromedioGoles"] = reader.GetDouble(reader.GetOrdinal("PromedioGoles"));
                            }
                        }
                    }
                }

                return totales;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener estadísticas totales: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene los máximos goleadores
        /// </summary>
        public List<Dictionary<string, object>> ObtenerMaximosGoleadores(int limite = 10)
        {
            List<Dictionary<string, object>> goleadores = new List<Dictionary<string, object>>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT TOP (@Limite)
                                        e.IdJugador,
                                        j.Nombre,
                                        j.Apellidos,
                                        SUM(e.Goles) AS TotalGoles,
                                        SUM(e.Asistencias) AS TotalAsistencias,
                                        COUNT(*) AS PartidosJugados
                                    FROM Estadisticas e
                                    INNER JOIN Jugadores j ON e.IdJugador = j.IdJugador
                                    GROUP BY e.IdJugador, j.Nombre, j.Apellidos
                                    HAVING SUM(e.Goles) > 0
                                    ORDER BY TotalGoles DESC, TotalAsistencias DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Limite", limite);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Dictionary<string, object> goleador = new Dictionary<string, object>
                                {
                                    ["IdJugador"] = reader.GetInt32(reader.GetOrdinal("IdJugador")),
                                    ["Nombre"] = reader.GetString(reader.GetOrdinal("Nombre")),
                                    ["Apellidos"] = reader.GetString(reader.GetOrdinal("Apellidos")),
                                    ["TotalGoles"] = reader.GetInt32(reader.GetOrdinal("TotalGoles")),
                                    ["TotalAsistencias"] = reader.GetInt32(reader.GetOrdinal("TotalAsistencias")),
                                    ["PartidosJugados"] = reader.GetInt32(reader.GetOrdinal("PartidosJugados"))
                                };

                                goleadores.Add(goleador);
                            }
                        }
                    }
                }

                return goleadores;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener máximos goleadores: {ex.Message}");
            }
        }

        #endregion

        #region UPDATE - Actualizar

        /// <summary>
        /// Actualiza una estadística existente
        /// </summary>
        public bool Actualizar(Estadistica estadistica)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Estadisticas SET 
                                    IdJugador = @IdJugador, 
                                    IdPartido = @IdPartido, 
                                    Goles = @Goles, 
                                    TarjetasAmarillas = @TarjetasAmarillas, 
                                    TarjetasRojas = @TarjetasRojas, 
                                    Asistencias = @Asistencias, 
                                    MinutosJugados = @MinutosJugados, 
                                    Titular = @Titular 
                                    WHERE IdEstadistica = @IdEstadistica";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEstadistica", estadistica.IdEstadistica);
                        cmd.Parameters.AddWithValue("@IdJugador", estadistica.IdJugador);
                        cmd.Parameters.AddWithValue("@IdPartido", estadistica.IdPartido);
                        cmd.Parameters.AddWithValue("@Goles", estadistica.Goles);
                        cmd.Parameters.AddWithValue("@TarjetasAmarillas", estadistica.TarjetasAmarillas);
                        cmd.Parameters.AddWithValue("@TarjetasRojas", estadistica.TarjetasRojas);
                        cmd.Parameters.AddWithValue("@Asistencias", estadistica.Asistencias);
                        cmd.Parameters.AddWithValue("@MinutosJugados", estadistica.MinutosJugados);
                        cmd.Parameters.AddWithValue("@Titular", estadistica.Titular);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar estadística: {ex.Message}");
            }
        }

        #endregion

        #region DELETE - Eliminar

        /// <summary>
        /// Elimina una estadística de la base de datos
        /// </summary>
        public bool Eliminar(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM Estadisticas WHERE IdEstadistica = @IdEstadistica";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEstadistica", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar estadística: {ex.Message}");
            }
        }

        /// <summary>
        /// Elimina todas las estadísticas de un partido
        /// </summary>
        public bool EliminarPorPartido(int idPartido)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM Estadisticas WHERE IdPartido = @IdPartido";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPartido", idPartido);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar estadísticas del partido: {ex.Message}");
            }
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Mapea un registro de la BD a un objeto Estadistica
        /// </summary>
        private Estadistica MapearEstadistica(SqlDataReader reader)
        {
            return new Estadistica
            {
                IdEstadistica = reader.GetInt32(reader.GetOrdinal("IdEstadistica")),
                IdJugador = reader.GetInt32(reader.GetOrdinal("IdJugador")),
                IdPartido = reader.GetInt32(reader.GetOrdinal("IdPartido")),
                Goles = reader.GetInt32(reader.GetOrdinal("Goles")),
                TarjetasAmarillas = reader.GetInt32(reader.GetOrdinal("TarjetasAmarillas")),
                TarjetasRojas = reader.GetInt32(reader.GetOrdinal("TarjetasRojas")),
                Asistencias = reader.GetInt32(reader.GetOrdinal("Asistencias")),
                MinutosJugados = reader.GetInt32(reader.GetOrdinal("MinutosJugados")),
                Titular = reader.GetBoolean(reader.GetOrdinal("Titular")),
                FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"))
            };
        }

        /// <summary>
        /// Verifica si ya existe una estadística para un jugador en un partido
        /// </summary>
        public bool ExisteEstadistica(int idJugador, int idPartido, int idEstadisticaExcluir = 0)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) FROM Estadisticas 
                                    WHERE IdJugador = @IdJugador 
                                    AND IdPartido = @IdPartido 
                                    AND IdEstadistica != @IdEstadisticaExcluir";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdJugador", idJugador);
                        cmd.Parameters.AddWithValue("@IdPartido", idPartido);
                        cmd.Parameters.AddWithValue("@IdEstadisticaExcluir", idEstadisticaExcluir);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar estadística: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene el total de estadísticas registradas
        /// </summary>
        public int ObtenerTotal()
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Estadisticas";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener total de estadísticas: {ex.Message}");
            }
        }

        #endregion
    }
}
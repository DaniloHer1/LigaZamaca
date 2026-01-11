using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LigaZamaca.Modelos;

namespace LigaZamaca.AccesoDatos
{
    /// <summary>
    /// Clase DAO para gestionar operaciones CRUD de Partidos en SQL Server
    /// </summary>
    public class PartidoDAO
    {
        #region CREATE - Insertar

        /// <summary>
        /// Inserta un nuevo partido en la base de datos
        /// </summary>
        public int Insertar(Partido partido)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Partidos 
                                    (IdEquipoLocal, IdEquipoVisitante, Fecha, Jornada, 
                                     GolesLocal, GolesVisitante, Estadio, Arbitro, Estado, Asistencia) 
                                    VALUES 
                                    (@IdEquipoLocal, @IdEquipoVisitante, @Fecha, @Jornada, 
                                     @GolesLocal, @GolesVisitante, @Estadio, @Arbitro, @Estado, @Asistencia);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipoLocal", partido.IdEquipoLocal);
                        cmd.Parameters.AddWithValue("@IdEquipoVisitante", partido.IdEquipoVisitante);
                        cmd.Parameters.AddWithValue("@Fecha", partido.Fecha);
                        cmd.Parameters.AddWithValue("@Jornada", partido.Jornada);
                        cmd.Parameters.AddWithValue("@GolesLocal", partido.GolesLocal);
                        cmd.Parameters.AddWithValue("@GolesVisitante", partido.GolesVisitante);
                        cmd.Parameters.AddWithValue("@Estadio", partido.Estadio);
                        cmd.Parameters.AddWithValue("@Arbitro",
                            string.IsNullOrEmpty(partido.Arbitro) ? DBNull.Value : (object)partido.Arbitro);
                        cmd.Parameters.AddWithValue("@Estado", partido.Estado);
                        cmd.Parameters.AddWithValue("@Asistencia",
                            partido.Asistencia.HasValue ? (object)partido.Asistencia.Value : DBNull.Value);

                        int idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                        return idGenerado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar partido: {ex.Message}");
            }
        }

        #endregion

        #region READ - Consultar

        /// <summary>
        /// Obtiene todos los partidos
        /// </summary>
        public List<Partido> ObtenerTodos()
        {
            List<Partido> partidos = new List<Partido>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdPartido, IdEquipoLocal, IdEquipoVisitante, Fecha, 
                                           Jornada, GolesLocal, GolesVisitante, Estadio, 
                                           Arbitro, Estado, Asistencia, FechaRegistro 
                                    FROM Partidos 
                                    ORDER BY Fecha DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            partidos.Add(MapearPartido(reader));
                        }
                    }
                }

                return partidos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener partidos: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene un partido por su ID
        /// </summary>
        public Partido ObtenerPorId(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdPartido, IdEquipoLocal, IdEquipoVisitante, Fecha, 
                                           Jornada, GolesLocal, GolesVisitante, Estadio, 
                                           Arbitro, Estado, Asistencia, FechaRegistro 
                                    FROM Partidos 
                                    WHERE IdPartido = @IdPartido";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPartido", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapearPartido(reader);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener partido: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene partidos de una jornada específica
        /// </summary>
        public List<Partido> ObtenerPorJornada(int jornada)
        {
            List<Partido> partidos = new List<Partido>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdPartido, IdEquipoLocal, IdEquipoVisitante, Fecha, 
                                           Jornada, GolesLocal, GolesVisitante, Estadio, 
                                           Arbitro, Estado, Asistencia, FechaRegistro 
                                    FROM Partidos 
                                    WHERE Jornada = @Jornada 
                                    ORDER BY Fecha";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Jornada", jornada);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                partidos.Add(MapearPartido(reader));
                            }
                        }
                    }
                }

                return partidos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener partidos de la jornada: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene todos los partidos de un equipo (local o visitante)
        /// </summary>
        public List<Partido> ObtenerPorEquipo(int idEquipo)
        {
            List<Partido> partidos = new List<Partido>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdPartido, IdEquipoLocal, IdEquipoVisitante, Fecha, 
                                           Jornada, GolesLocal, GolesVisitante, Estadio, 
                                           Arbitro, Estado, Asistencia, FechaRegistro 
                                    FROM Partidos 
                                    WHERE IdEquipoLocal = @IdEquipo OR IdEquipoVisitante = @IdEquipo 
                                    ORDER BY Fecha DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                partidos.Add(MapearPartido(reader));
                            }
                        }
                    }
                }

                return partidos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener partidos del equipo: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene partidos filtrados por estado
        /// </summary>
        public List<Partido> FiltrarPorEstado(string estado)
        {
            List<Partido> partidos = new List<Partido>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdPartido, IdEquipoLocal, IdEquipoVisitante, Fecha, 
                                           Jornada, GolesLocal, GolesVisitante, Estadio, 
                                           Arbitro, Estado, Asistencia, FechaRegistro 
                                    FROM Partidos 
                                    WHERE Estado = @Estado 
                                    ORDER BY Fecha";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Estado", estado);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                partidos.Add(MapearPartido(reader));
                            }
                        }
                    }
                }

                return partidos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar partidos por estado: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene partidos entre dos fechas
        /// </summary>
        public List<Partido> ObtenerPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Partido> partidos = new List<Partido>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdPartido, IdEquipoLocal, IdEquipoVisitante, Fecha, 
                                           Jornada, GolesLocal, GolesVisitante, Estadio, 
                                           Arbitro, Estado, Asistencia, FechaRegistro 
                                    FROM Partidos 
                                    WHERE Fecha BETWEEN @FechaInicio AND @FechaFin 
                                    ORDER BY Fecha";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                partidos.Add(MapearPartido(reader));
                            }
                        }
                    }
                }

                return partidos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener partidos por rango de fechas: {ex.Message}");
            }
        }

        #endregion

        #region UPDATE - Actualizar

        /// <summary>
        /// Actualiza un partido existente
        /// </summary>
        public bool Actualizar(Partido partido)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Partidos SET 
                                    IdEquipoLocal = @IdEquipoLocal, 
                                    IdEquipoVisitante = @IdEquipoVisitante, 
                                    Fecha = @Fecha, 
                                    Jornada = @Jornada, 
                                    GolesLocal = @GolesLocal, 
                                    GolesVisitante = @GolesVisitante, 
                                    Estadio = @Estadio, 
                                    Arbitro = @Arbitro, 
                                    Estado = @Estado, 
                                    Asistencia = @Asistencia 
                                    WHERE IdPartido = @IdPartido";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPartido", partido.IdPartido);
                        cmd.Parameters.AddWithValue("@IdEquipoLocal", partido.IdEquipoLocal);
                        cmd.Parameters.AddWithValue("@IdEquipoVisitante", partido.IdEquipoVisitante);
                        cmd.Parameters.AddWithValue("@Fecha", partido.Fecha);
                        cmd.Parameters.AddWithValue("@Jornada", partido.Jornada);
                        cmd.Parameters.AddWithValue("@GolesLocal", partido.GolesLocal);
                        cmd.Parameters.AddWithValue("@GolesVisitante", partido.GolesVisitante);
                        cmd.Parameters.AddWithValue("@Estadio", partido.Estadio);
                        cmd.Parameters.AddWithValue("@Arbitro",
                            string.IsNullOrEmpty(partido.Arbitro) ? DBNull.Value : (object)partido.Arbitro);
                        cmd.Parameters.AddWithValue("@Estado", partido.Estado);
                        cmd.Parameters.AddWithValue("@Asistencia",
                            partido.Asistencia.HasValue ? (object)partido.Asistencia.Value : DBNull.Value);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar partido: {ex.Message}");
            }
        }

        /// <summary>
        /// Actualiza el resultado de un partido
        /// </summary>
        public bool ActualizarResultado(int idPartido, int golesLocal, int golesVisitante)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Partidos SET 
                                    GolesLocal = @GolesLocal, 
                                    GolesVisitante = @GolesVisitante, 
                                    Estado = 'Finalizado' 
                                    WHERE IdPartido = @IdPartido";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPartido", idPartido);
                        cmd.Parameters.AddWithValue("@GolesLocal", golesLocal);
                        cmd.Parameters.AddWithValue("@GolesVisitante", golesVisitante);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar resultado: {ex.Message}");
            }
        }

        #endregion

        #region DELETE - Eliminar

        /// <summary>
        /// Elimina un partido de la base de datos
        /// </summary>
        public bool Eliminar(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM Partidos WHERE IdPartido = @IdPartido";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPartido", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar partido: {ex.Message}");
            }
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Mapea un registro de la BD a un objeto Partido
        /// </summary>
        private Partido MapearPartido(SqlDataReader reader)
        {
            return new Partido
            {
                IdPartido = reader.GetInt32(reader.GetOrdinal("IdPartido")),
                IdEquipoLocal = reader.GetInt32(reader.GetOrdinal("IdEquipoLocal")),
                IdEquipoVisitante = reader.GetInt32(reader.GetOrdinal("IdEquipoVisitante")),
                Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                Jornada = reader.GetInt32(reader.GetOrdinal("Jornada")),
                GolesLocal = reader.GetInt32(reader.GetOrdinal("GolesLocal")),
                GolesVisitante = reader.GetInt32(reader.GetOrdinal("GolesVisitante")),
                Estadio = reader.GetString(reader.GetOrdinal("Estadio")),
                Arbitro = reader.IsDBNull(reader.GetOrdinal("Arbitro"))
                    ? null : reader.GetString(reader.GetOrdinal("Arbitro")),
                Estado = reader.GetString(reader.GetOrdinal("Estado")),
                Asistencia = reader.IsDBNull(reader.GetOrdinal("Asistencia"))
                    ? (int?)null : reader.GetInt32(reader.GetOrdinal("Asistencia")),
                FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"))
            };
        }

        /// <summary>
        /// Obtiene el total de partidos
        /// </summary>
        public int ObtenerTotal()
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Partidos";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener total de partidos: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene el número total de jornadas
        /// </summary>
        public int ObtenerTotalJornadas()
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT ISNULL(MAX(Jornada), 0) FROM Partidos";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener total de jornadas: {ex.Message}");
            }
        }

        #endregion
    }
}
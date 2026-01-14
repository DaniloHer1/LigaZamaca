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
                                    (IdEquipoLocal, IdEquipoVisitante, FechaHora, Jornada, 
                                     GolesLocal, GolesVisitante, Estadio, Arbitro, Estado, Asistencia) 
                                    VALUES 
                                    (@IdEquipoLocal, @IdEquipoVisitante, @FechaHora, @Jornada, 
                                     @GolesLocal, @GolesVisitante, @Estadio, @Arbitro, @Estado, @Asistencia);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipoLocal", partido.IdEquipoLocal);
                        cmd.Parameters.AddWithValue("@IdEquipoVisitante", partido.IdEquipoVisitante);
                        cmd.Parameters.AddWithValue("@FechaHora", partido.FechaHora);
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
        /// Obtiene todos los partidos CON nombres de equipos
        /// </summary>
        public List<Partido> ObtenerTodos()
        {
            List<Partido> partidos = new List<Partido>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    // ⭐ Consulta con alias explícitos para evitar conflictos
                    string query = @"SELECT 
                                        p.IdPartido, 
                                        p.IdEquipoLocal, 
                                        p.IdEquipoVisitante, 
                                        p.FechaHora, 
                                        p.Jornada, 
                                        p.GolesLocal, 
                                        p.GolesVisitante, 
                                        p.Estadio, 
                                        p.Arbitro, 
                                        p.Estado, 
                                        p.Asistencia, 
                                        p.FechaRegistro,
                                        el.Nombre AS NombreEquipoLocal,
                                        ev.Nombre AS NombreEquipoVisitante
                                    FROM Partidos p
                                    INNER JOIN Equipos el ON p.IdEquipoLocal = el.IdEquipo
                                    INNER JOIN Equipos ev ON p.IdEquipoVisitante = ev.IdEquipo
                                    ORDER BY p.Fecha DESC, p.Jornada DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            partidos.Add(MapearPartidoConEquipos(reader));
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
        /// Obtiene un partido por su ID CON nombres de equipos
        /// </summary>
        public Partido ObtenerPorId(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        p.IdPartido, 
                                        p.IdEquipoLocal, 
                                        p.IdEquipoVisitante, 
                                        p.FechaHora, 
                                        p.Jornada, 
                                        p.GolesLocal, 
                                        p.GolesVisitante, 
                                        p.Estadio, 
                                        p.Arbitro, 
                                        p.Estado, 
                                        p.Asistencia, 
                                        p.FechaRegistro,
                                        el.Nombre AS NombreEquipoLocal,
                                        ev.Nombre AS NombreEquipoVisitante
                                    FROM Partidos p
                                    INNER JOIN Equipos el ON p.IdEquipoLocal = el.IdEquipo
                                    INNER JOIN Equipos ev ON p.IdEquipoVisitante = ev.IdEquipo
                                    WHERE p.IdPartido = @IdPartido";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPartido", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapearPartidoConEquipos(reader);
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
                                    FechaHora = @FechaHora,
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
                        cmd.Parameters.AddWithValue("@FechaHora", partido.FechaHora);
                        cmd.Parameters.AddWithValue("@Jornada", partido.Jornada);
                        cmd.Parameters.AddWithValue("@GolesLocal", partido.GolesLocal);
                        cmd.Parameters.AddWithValue("@GolesVisitante", partido.GolesVisitante);
                        cmd.Parameters.AddWithValue("@Estadio", partido.Estadio);
                        cmd.Parameters.AddWithValue("@Arbitro",
                            string.IsNullOrEmpty(partido.Arbitro) ? DBNull.Value : (object)partido.Arbitro);
                        cmd.Parameters.AddWithValue("@Estado", partido.Estado);
                        cmd.Parameters.AddWithValue("@Asistencia",
                            partido.Asistencia.HasValue ? (object)partido.Asistencia.Value : DBNull.Value);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar partido: {ex.Message}");
            }
        }

        #endregion

        #region DELETE - Eliminar

        /// <summary>
        /// Elimina un partido por su ID
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
                        return cmd.ExecuteNonQuery() > 0;
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
        /// Mapea un registro de la BD a un objeto Partido INCLUYENDO nombres de equipos
        /// </summary>
        private Partido MapearPartidoConEquipos(SqlDataReader reader)
        {
            return new Partido
            {
                IdPartido = reader.GetInt32(reader.GetOrdinal("IdPartido")),
                IdEquipoLocal = reader.GetInt32(reader.GetOrdinal("IdEquipoLocal")),
                IdEquipoVisitante = reader.GetInt32(reader.GetOrdinal("IdEquipoVisitante")),

                // ⭐ Nombres de equipos
                NombreEquipoLocal = reader.GetString(reader.GetOrdinal("NombreEquipoLocal")),
                NombreEquipoVisitante = reader.GetString(reader.GetOrdinal("NombreEquipoVisitante")),

                // ⭐ Usar el alias FechaPartido en lugar de Fecha
                FechaHora = reader.GetDateTime(reader.GetOrdinal("FechaHora")),
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

        #endregion
    }
}
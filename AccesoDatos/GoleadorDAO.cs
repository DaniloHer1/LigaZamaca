using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LigaZamaca.Modelos;

namespace LigaZamaca.AccesoDatos
{
    /// <summary>
    /// Clase DAO para consultar el ranking de goleadores
    /// </summary>
    public class GoleadoresDAO
    {
        /// <summary>
        /// Obtiene el ranking de máximos goleadores
        /// </summary>
        public List<TopGoleador> ObtenerTopGoleadores(int limite = 20)
        {
            List<TopGoleador> goleadores = new List<TopGoleador>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT TOP (@Limite)
                            j.IdJugador,
                            j.Nombre,
                            j.Apellidos,
                            e.Nombre AS NombreEquipo,
                            e.Escudo AS EscudoEquipo,
                            ISNULL(SUM(est.Goles), 0) AS TotalGoles,
                            ISNULL(SUM(est.Asistencias), 0) AS TotalAsistencias,
                            COUNT(DISTINCT est.IdPartido) AS PartidosJugados
                        FROM Jugadores j
                        INNER JOIN Equipos e ON j.IdEquipo = e.IdEquipo
                        LEFT JOIN Estadisticas est ON j.IdJugador = est.IdJugador
                        WHERE j.Activo = 1
                        GROUP BY j.IdJugador, j.Nombre, j.Apellidos, e.Nombre, e.Escudo
                        HAVING ISNULL(SUM(est.Goles), 0) > 0
                        ORDER BY TotalGoles DESC, TotalAsistencias DESC, PartidosJugados ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Limite", limite);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int posicion = 1;

                            while (reader.Read())
                            {
                                TopGoleador goleador = new TopGoleador
                                {
                                    Posicion = posicion,
                                    IdJugador = reader.GetInt32(reader.GetOrdinal("IdJugador")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Apellidos = reader.GetString(reader.GetOrdinal("Apellidos")),
                                    NombreEquipo = reader.GetString(reader.GetOrdinal("NombreEquipo")),
                                    EscudoEquipo = reader.IsDBNull(reader.GetOrdinal("EscudoEquipo"))
                                        ? null : reader.GetString(reader.GetOrdinal("EscudoEquipo")),
                                    TotalGoles = reader.GetInt32(reader.GetOrdinal("TotalGoles")),
                                    TotalAsistencias = reader.GetInt32(reader.GetOrdinal("TotalAsistencias")),
                                    PartidosJugados = reader.GetInt32(reader.GetOrdinal("PartidosJugados"))
                                };

                                goleadores.Add(goleador);
                                posicion++;
                            }
                        }
                    }
                }

                return goleadores;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener top goleadores: {ex.Message}");
            }
        }
    }
}
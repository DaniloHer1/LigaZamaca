using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LigaZamaca.Modelos;

namespace LigaZamaca.AccesoDatos
{
    /// <summary>
    /// Clase DAO para consultar la clasificación de la liga
    /// </summary>
    public class ClasificacionDAO
    {
        /// <summary>
        /// Obtiene la clasificación completa de la liga ordenada por puntos
        /// </summary>
        public List<Clasificacion> ObtenerClasificacion()
        {
            List<Clasificacion> clasificacion = new List<Clasificacion>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    // Consulta a la vista ordenada por Puntos, Diferencia de Goles y Goles a Favor
                    string query = @"SELECT IdEquipo, Equipo, Escudo, PJ, PG, PE, PP, 
                                           GF, GC, DG, Puntos
                                    FROM VistaClasificacion
                                    ORDER BY Puntos DESC, DG DESC, GF DESC, Equipo ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int posicion = 1;

                        while (reader.Read())
                        {
                            Clasificacion equipo = MapearClasificacion(reader);
                            equipo.Posicion = posicion; // Asignar posición
                            clasificacion.Add(equipo);
                            posicion++;
                        }
                    }
                }

                return clasificacion;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener clasificación: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene el top N equipos de la clasificación
        /// </summary>
        public List<Clasificacion> ObtenerTopEquipos(int cantidad)
        {
            List<Clasificacion> clasificacion = new List<Clasificacion>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = $@"SELECT TOP {cantidad} IdEquipo, Equipo, Escudo, PJ, PG, PE, PP, 
                                            GF, GC, DG, Puntos
                                     FROM VistaClasificacion
                                     ORDER BY Puntos DESC, DG DESC, GF DESC, Equipo ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int posicion = 1;

                        while (reader.Read())
                        {
                            Clasificacion equipo = MapearClasificacion(reader);
                            equipo.Posicion = posicion;
                            clasificacion.Add(equipo);
                            posicion++;
                        }
                    }
                }

                return clasificacion;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener top equipos: {ex.Message}");
            }
        }

        /// <summary>
        /// Mapea un registro de la BD a un objeto Clasificacion
        /// </summary>
        private Clasificacion MapearClasificacion(SqlDataReader reader)
        {
            return new Clasificacion
            {
                IdEquipo = reader.GetInt32(reader.GetOrdinal("IdEquipo")),
                Equipo = reader.GetString(reader.GetOrdinal("Equipo")),
                Escudo = reader.IsDBNull(reader.GetOrdinal("Escudo"))
                    ? null : reader.GetString(reader.GetOrdinal("Escudo")),
                PJ = reader.GetInt32(reader.GetOrdinal("PJ")),
                PG = reader.GetInt32(reader.GetOrdinal("PG")),
                PE = reader.GetInt32(reader.GetOrdinal("PE")),
                PP = reader.GetInt32(reader.GetOrdinal("PP")),
                GF = reader.GetInt32(reader.GetOrdinal("GF")),
                GC = reader.GetInt32(reader.GetOrdinal("GC")),
                DG = reader.GetInt32(reader.GetOrdinal("DG")),
                Puntos = reader.GetInt32(reader.GetOrdinal("Puntos"))
            };
        }
    }
}
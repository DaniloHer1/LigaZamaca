using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LigaZamaca.AccesoDatos
{
    /// <summary>
    /// Clase DAO para obtener datos de los informes Crystal Reports
    /// </summary>
    public class InformeDAO
    {
        #region Informe Clasificación

        /// <summary>
        /// Obtiene los datos de clasificación para el informe
        /// </summary>
        public DataTable ObtenerDatosClasificacion()
        {
            DataTable dt = new DataTable("Clasificacion");

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            ROW_NUMBER() OVER (ORDER BY Puntos DESC, DG DESC, GF DESC) AS Posicion,
                            IdEquipo,
                            Equipo,
                            Escudo,
                            PJ,
                            PG,
                            PE,
                            PP,
                            GF,
                            GC,
                            DG,
                            Puntos
                        FROM Vista_Clasificacion";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos de clasificación: {ex.Message}");
            }

            return dt;
        }

        #endregion

        #region Informe Goleadores (con parámetro)

        /// <summary>
        /// Obtiene los datos de goleadores para el informe con parámetro de cantidad
        /// </summary>
        /// <param name="cantidad">Número de goleadores a mostrar</param>
        public DataTable ObtenerDatosGoleadores(int cantidad)
        {
            DataTable dt = new DataTable("Goleadores");

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT TOP (@Cantidad)
                            ROW_NUMBER() OVER (ORDER BY ISNULL(SUM(est.Goles), 0) DESC) AS Posicion,
                            j.IdJugador,
                            CONCAT(j.Nombre, ' ', j.Apellidos) AS NombreCompleto,
                            e.Nombre AS NombreEquipo,
                            e.Escudo AS EscudoEquipo,
                            ISNULL(SUM(est.Goles), 0) AS TotalGoles,
                            ISNULL(SUM(est.Asistencias), 0) AS TotalAsistencias,
                            COUNT(DISTINCT est.IdPartido) AS PartidosJugados,
                            CASE 
                                WHEN COUNT(DISTINCT est.IdPartido) > 0 
                                THEN CAST(ISNULL(SUM(est.Goles), 0) AS DECIMAL(5,2)) / COUNT(DISTINCT est.IdPartido)
                                ELSE 0 
                            END AS PromedioGoles
                        FROM Jugadores j
                        INNER JOIN Equipos e ON j.IdEquipo = e.IdEquipo
                        LEFT JOIN Estadisticas est ON j.IdJugador = est.IdJugador
                        WHERE j.Activo = 1
                        GROUP BY j.IdJugador, j.Nombre, j.Apellidos, e.Nombre, e.Escudo
                        HAVING ISNULL(SUM(est.Goles), 0) > 0
                        ORDER BY TotalGoles DESC, TotalAsistencias DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos de goleadores: {ex.Message}");
            }

            return dt;
        }

        #endregion

        #region Informe Partidos por Equipo (con gráfico)

        /// <summary>
        /// Obtiene los partidos de un equipo específico
        /// </summary>
        /// <param name="idEquipo">ID del equipo</param>
        public DataTable ObtenerPartidosEquipo(int idEquipo)
        {
            DataTable dt = new DataTable("PartidosEquipo");

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.IdPartido,
                            p.Jornada,
                            p.FechaHora,
                            CASE 
                                WHEN p.IdEquipoLocal = @IdEquipo THEN ev.Nombre
                                ELSE el.Nombre 
                            END AS Rival,
                            CASE 
                                WHEN p.IdEquipoLocal = @IdEquipo THEN ev.Escudo
                                ELSE el.Escudo 
                            END AS EscudoRival,
                            CASE WHEN p.IdEquipoLocal = @IdEquipo THEN 1 ELSE 0 END AS Local,
                            CASE 
                                WHEN p.IdEquipoLocal = @IdEquipo THEN p.GolesLocal
                                ELSE p.GolesVisitante 
                            END AS GolesAFavor,
                            CASE 
                                WHEN p.IdEquipoLocal = @IdEquipo THEN p.GolesVisitante
                                ELSE p.GolesLocal 
                            END AS GolesEnContra,
                            CASE 
                                WHEN p.Estado != 'Finalizado' THEN 'Pendiente'
                                WHEN (p.IdEquipoLocal = @IdEquipo AND p.GolesLocal > p.GolesVisitante)
                                     OR (p.IdEquipoVisitante = @IdEquipo AND p.GolesVisitante > p.GolesLocal)
                                THEN 'Victoria'
                                WHEN p.GolesLocal = p.GolesVisitante THEN 'Empate'
                                ELSE 'Derrota'
                            END AS Resultado,
                            CASE 
                                WHEN p.Estado != 'Finalizado' THEN 0
                                WHEN (p.IdEquipoLocal = @IdEquipo AND p.GolesLocal > p.GolesVisitante)
                                     OR (p.IdEquipoVisitante = @IdEquipo AND p.GolesVisitante > p.GolesLocal)
                                THEN 3
                                WHEN p.GolesLocal = p.GolesVisitante THEN 1
                                ELSE 0
                            END AS Puntos,
                            p.Estado
                        FROM Partidos p
                        INNER JOIN Equipos el ON p.IdEquipoLocal = el.IdEquipo
                        INNER JOIN Equipos ev ON p.IdEquipoVisitante = ev.IdEquipo
                        WHERE p.IdEquipoLocal = @IdEquipo OR p.IdEquipoVisitante = @IdEquipo
                        ORDER BY p.Jornada";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener partidos del equipo: {ex.Message}");
            }

            return dt;
        }

        /// <summary>
        /// Obtiene el resumen estadístico de un equipo
        /// </summary>
        /// <param name="idEquipo">ID del equipo</param>
        public DataTable ObtenerResumenEquipo(int idEquipo)
        {
            DataTable dt = new DataTable("ResumenEquipo");

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            e.IdEquipo,
                            e.Nombre AS NombreEquipo,
                            e.Escudo,
                            COUNT(CASE WHEN p.Estado = 'Finalizado' THEN 1 END) AS PartidosJugados,
                            COUNT(CASE 
                                WHEN p.Estado = 'Finalizado' AND 
                                     ((p.IdEquipoLocal = @IdEquipo AND p.GolesLocal > p.GolesVisitante)
                                      OR (p.IdEquipoVisitante = @IdEquipo AND p.GolesVisitante > p.GolesLocal))
                                THEN 1 
                            END) AS Victorias,
                            COUNT(CASE 
                                WHEN p.Estado = 'Finalizado' AND p.GolesLocal = p.GolesVisitante
                                THEN 1 
                            END) AS Empates,
                            COUNT(CASE 
                                WHEN p.Estado = 'Finalizado' AND 
                                     ((p.IdEquipoLocal = @IdEquipo AND p.GolesLocal < p.GolesVisitante)
                                      OR (p.IdEquipoVisitante = @IdEquipo AND p.GolesVisitante < p.GolesLocal))
                                THEN 1 
                            END) AS Derrotas,
                            ISNULL(SUM(CASE 
                                WHEN p.Estado = 'Finalizado' AND p.IdEquipoLocal = @IdEquipo THEN p.GolesLocal
                                WHEN p.Estado = 'Finalizado' AND p.IdEquipoVisitante = @IdEquipo THEN p.GolesVisitante
                                ELSE 0
                            END), 0) AS GolesAFavor,
                            ISNULL(SUM(CASE 
                                WHEN p.Estado = 'Finalizado' AND p.IdEquipoLocal = @IdEquipo THEN p.GolesVisitante
                                WHEN p.Estado = 'Finalizado' AND p.IdEquipoVisitante = @IdEquipo THEN p.GolesLocal
                                ELSE 0
                            END), 0) AS GolesEnContra,
                            ISNULL(SUM(CASE 
                                WHEN p.Estado = 'Finalizado' AND p.IdEquipoLocal = @IdEquipo THEN p.GolesLocal - p.GolesVisitante
                                WHEN p.Estado = 'Finalizado' AND p.IdEquipoVisitante = @IdEquipo THEN p.GolesVisitante - p.GolesLocal
                                ELSE 0
                            END), 0) AS DiferenciaGoles,
                            ISNULL(SUM(CASE 
                                WHEN p.Estado != 'Finalizado' THEN 0
                                WHEN (p.IdEquipoLocal = @IdEquipo AND p.GolesLocal > p.GolesVisitante)
                                     OR (p.IdEquipoVisitante = @IdEquipo AND p.GolesVisitante > p.GolesLocal)
                                THEN 3
                                WHEN p.GolesLocal = p.GolesVisitante THEN 1
                                ELSE 0
                            END), 0) AS PuntosTotales
                        FROM Equipos e
                        LEFT JOIN Partidos p ON (p.IdEquipoLocal = e.IdEquipo OR p.IdEquipoVisitante = e.IdEquipo)
                        WHERE e.IdEquipo = @IdEquipo
                        GROUP BY e.IdEquipo, e.Nombre, e.Escudo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener resumen del equipo: {ex.Message}");
            }

            return dt;
        }

        /// <summary>
        /// Obtiene datos para el gráfico de resultados (Victorias, Empates, Derrotas)
        /// </summary>
        public DataTable ObtenerDatosGraficoResultados(int idEquipo)
        {
            DataTable dt = new DataTable("GraficoResultados");
            dt.Columns.Add("Categoria", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));

            try
            {
                DataTable resumen = ObtenerResumenEquipo(idEquipo);
                if (resumen.Rows.Count > 0)
                {
                    dt.Rows.Add("Victorias", Convert.ToInt32(resumen.Rows[0]["Victorias"]));
                    dt.Rows.Add("Empates", Convert.ToInt32(resumen.Rows[0]["Empates"]));
                    dt.Rows.Add("Derrotas", Convert.ToInt32(resumen.Rows[0]["Derrotas"]));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos del gráfico: {ex.Message}");
            }

            return dt;
        }

        #endregion
    }
}

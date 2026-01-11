using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LigaZamaca.Modelos;

namespace LigaZamaca.AccesoDatos
{
    /// <summary>
    /// Clase DAO para gestionar operaciones CRUD de Equipos en SQL Server
    /// </summary>
    public class EquipoDAO
    {
        #region CREATE - Insertar

        /// <summary>
        /// Inserta un nuevo equipo en la base de datos
        /// </summary>
        public int Insertar(Equipo equipo)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Equipos 
                                    (Nombre, Estadio, Ciudad, Entrenador, Escudo, 
                                     FechaFundacion, Presupuesto, Email, Telefono) 
                                    VALUES 
                                    (@Nombre, @Estadio, @Ciudad, @Entrenador, @Escudo, 
                                     @FechaFundacion, @Presupuesto, @Email, @Telefono);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                        cmd.Parameters.AddWithValue("@Estadio", equipo.Estadio);
                        cmd.Parameters.AddWithValue("@Ciudad", equipo.Ciudad);
                        cmd.Parameters.AddWithValue("@Entrenador",
                            string.IsNullOrEmpty(equipo.Entrenador) ? DBNull.Value : (object)equipo.Entrenador);
                        cmd.Parameters.AddWithValue("@Escudo",
                            string.IsNullOrEmpty(equipo.Escudo) ? DBNull.Value : (object)equipo.Escudo);
                        cmd.Parameters.AddWithValue("@FechaFundacion",
                            equipo.FechaFundacion.HasValue ? (object)equipo.FechaFundacion.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Presupuesto",
                            equipo.Presupuesto.HasValue ? (object)equipo.Presupuesto.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email",
                            string.IsNullOrEmpty(equipo.Email) ? DBNull.Value : (object)equipo.Email);
                        cmd.Parameters.AddWithValue("@Telefono",
                            string.IsNullOrEmpty(equipo.Telefono) ? DBNull.Value : (object)equipo.Telefono);

                        int idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                        return idGenerado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar equipo: {ex.Message}");
            }
        }

        #endregion

        #region READ - Consultar

        /// <summary>
        /// Obtiene todos los equipos de la base de datos
        /// </summary>
        public List<Equipo> ObtenerTodos()
        {
            List<Equipo> equipos = new List<Equipo>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdEquipo, Nombre, Estadio, Ciudad, Entrenador, 
                                           Escudo, FechaFundacion, Presupuesto, Email, 
                                           Telefono, FechaRegistro 
                                    FROM Equipos 
                                    ORDER BY Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            equipos.Add(MapearEquipo(reader));
                        }
                    }
                }

                return equipos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener equipos: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene un equipo por su ID
        /// </summary>
        public Equipo ObtenerPorId(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdEquipo, Nombre, Estadio, Ciudad, Entrenador, 
                                           Escudo, FechaFundacion, Presupuesto, Email, 
                                           Telefono, FechaRegistro 
                                    FROM Equipos 
                                    WHERE IdEquipo = @IdEquipo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapearEquipo(reader);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener equipo: {ex.Message}");
            }
        }

        /// <summary>
        /// Busca equipos por nombre (búsqueda aproximada)
        /// </summary>
        public List<Equipo> BuscarPorNombre(string nombre)
        {
            List<Equipo> equipos = new List<Equipo>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdEquipo, Nombre, Estadio, Ciudad, Entrenador, 
                                           Escudo, FechaFundacion, Presupuesto, Email, 
                                           Telefono, FechaRegistro 
                                    FROM Equipos 
                                    WHERE Nombre LIKE @Nombre 
                                    ORDER BY Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", $"%{nombre}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                equipos.Add(MapearEquipo(reader));
                            }
                        }
                    }
                }

                return equipos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar equipos: {ex.Message}");
            }
        }

        /// <summary>
        /// Filtra equipos por ciudad
        /// </summary>
        public List<Equipo> FiltrarPorCiudad(string ciudad)
        {
            List<Equipo> equipos = new List<Equipo>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdEquipo, Nombre, Estadio, Ciudad, Entrenador, 
                                           Escudo, FechaFundacion, Presupuesto, Email, 
                                           Telefono, FechaRegistro 
                                    FROM Equipos 
                                    WHERE Ciudad = @Ciudad 
                                    ORDER BY Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ciudad", ciudad);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                equipos.Add(MapearEquipo(reader));
                            }
                        }
                    }
                }

                return equipos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar equipos: {ex.Message}");
            }
        }

        #endregion

        #region UPDATE - Actualizar

        /// <summary>
        /// Actualiza un equipo existente en la base de datos
        /// </summary>
        public bool Actualizar(Equipo equipo)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Equipos SET 
                                    Nombre = @Nombre, 
                                    Estadio = @Estadio, 
                                    Ciudad = @Ciudad, 
                                    Entrenador = @Entrenador, 
                                    Escudo = @Escudo, 
                                    FechaFundacion = @FechaFundacion, 
                                    Presupuesto = @Presupuesto, 
                                    Email = @Email, 
                                    Telefono = @Telefono 
                                    WHERE IdEquipo = @IdEquipo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", equipo.IdEquipo);
                        cmd.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                        cmd.Parameters.AddWithValue("@Estadio", equipo.Estadio);
                        cmd.Parameters.AddWithValue("@Ciudad", equipo.Ciudad);
                        cmd.Parameters.AddWithValue("@Entrenador",
                            string.IsNullOrEmpty(equipo.Entrenador) ? DBNull.Value : (object)equipo.Entrenador);
                        cmd.Parameters.AddWithValue("@Escudo",
                            string.IsNullOrEmpty(equipo.Escudo) ? DBNull.Value : (object)equipo.Escudo);
                        cmd.Parameters.AddWithValue("@FechaFundacion",
                            equipo.FechaFundacion.HasValue ? (object)equipo.FechaFundacion.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Presupuesto",
                            equipo.Presupuesto.HasValue ? (object)equipo.Presupuesto.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email",
                            string.IsNullOrEmpty(equipo.Email) ? DBNull.Value : (object)equipo.Email);
                        cmd.Parameters.AddWithValue("@Telefono",
                            string.IsNullOrEmpty(equipo.Telefono) ? DBNull.Value : (object)equipo.Telefono);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar equipo: {ex.Message}");
            }
        }

        #endregion

        #region DELETE - Eliminar

        /// <summary>
        /// Elimina un equipo de la base de datos
        /// </summary>
        public bool Eliminar(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM Equipos WHERE IdEquipo = @IdEquipo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar equipo: {ex.Message}");
            }
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Mapea un registro de la base de datos a un objeto Equipo
        /// </summary>
        private Equipo MapearEquipo(SqlDataReader reader)
        {
            return new Equipo
            {
                IdEquipo = reader.GetInt32(reader.GetOrdinal("IdEquipo")),
                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                Estadio = reader.GetString(reader.GetOrdinal("Estadio")),
                Ciudad = reader.GetString(reader.GetOrdinal("Ciudad")),
                Entrenador = reader.IsDBNull(reader.GetOrdinal("Entrenador"))
                    ? null : reader.GetString(reader.GetOrdinal("Entrenador")),
                Escudo = reader.IsDBNull(reader.GetOrdinal("Escudo"))
                    ? null : reader.GetString(reader.GetOrdinal("Escudo")),
                FechaFundacion = reader.IsDBNull(reader.GetOrdinal("FechaFundacion"))
                    ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("FechaFundacion")),
                Presupuesto = reader.IsDBNull(reader.GetOrdinal("Presupuesto"))
                    ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("Presupuesto")),
                Email = reader.IsDBNull(reader.GetOrdinal("Email"))
                    ? null : reader.GetString(reader.GetOrdinal("Email")),
                Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono"))
                    ? null : reader.GetString(reader.GetOrdinal("Telefono")),
                FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"))
            };
        }

        /// <summary>
        /// Verifica si existe un equipo con el nombre especificado
        /// </summary>
        public bool ExisteEquipo(string nombre, int idExcluir = 0)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) FROM Equipos 
                                    WHERE Nombre = @Nombre AND IdEquipo != @IdExcluir";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@IdExcluir", idExcluir);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar equipo: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene el número total de equipos
        /// </summary>
        public int ObtenerTotal()
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Equipos";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener total de equipos: {ex.Message}");
            }
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LigaZamaca.Modelos;

namespace LigaZamaca.AccesoDatos
{
    /// <summary>
    /// Clase DAO para gestionar operaciones CRUD de Jugadores en SQL Server
    /// </summary>
    public class JugadorDAO
    {
        #region CREATE - Insertar

        /// <summary>
        /// Inserta un nuevo jugador en la base de datos
        /// </summary>
        public int Insertar(Jugador jugador)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Jugadores 
                                    (IdEquipo, Nombre, Apellidos, FechaNacimiento, Posicion, 
                                     Dorsal, Nacionalidad, Altura, Peso, Foto, Activo) 
                                    VALUES 
                                    (@IdEquipo, @Nombre, @Apellidos, @FechaNacimiento, @Posicion, 
                                     @Dorsal, @Nacionalidad, @Altura, @Peso, @Foto, @Activo);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", jugador.IdEquipo);
                        cmd.Parameters.AddWithValue("@Nombre", jugador.Nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", jugador.Apellidos);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", jugador.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Posicion", jugador.Posicion);
                        cmd.Parameters.AddWithValue("@Dorsal", jugador.Dorsal);
                        cmd.Parameters.AddWithValue("@Nacionalidad", jugador.Nacionalidad);
                        cmd.Parameters.AddWithValue("@Altura",
                            jugador.Altura.HasValue ? (object)jugador.Altura.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Peso",
                            jugador.Peso.HasValue ? (object)jugador.Peso.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Foto",
                            string.IsNullOrEmpty(jugador.Foto) ? DBNull.Value : (object)jugador.Foto);
                        cmd.Parameters.AddWithValue("@Activo", jugador.Activo);

                        int idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                        return idGenerado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar jugador: {ex.Message}");
            }
        }

        #endregion

        #region READ - Consultar

        /// <summary>
        /// Obtiene todos los jugadores activos
        /// </summary>
        public List<Jugador> ObtenerTodos()
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdJugador, IdEquipo, Nombre, Apellidos, FechaNacimiento, 
                                           Posicion, Dorsal, Nacionalidad, Altura, Peso, Foto, 
                                           Activo, FechaAlta 
                                    FROM Jugadores 
                                    WHERE Activo = 1
                                    ORDER BY Apellidos, Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            jugadores.Add(MapearJugador(reader));
                        }
                    }
                }

                return jugadores;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener jugadores: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene un jugador por su ID
        /// </summary>
        public Jugador ObtenerPorId(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdJugador, IdEquipo, Nombre, Apellidos, FechaNacimiento, 
                                           Posicion, Dorsal, Nacionalidad, Altura, Peso, Foto, 
                                           Activo, FechaAlta 
                                    FROM Jugadores 
                                    WHERE IdJugador = @IdJugador";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdJugador", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapearJugador(reader);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener jugador: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene todos los jugadores de un equipo
        /// </summary>
        public List<Jugador> ObtenerPorEquipo(int idEquipo)
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdJugador, IdEquipo, Nombre, Apellidos, FechaNacimiento, 
                                           Posicion, Dorsal, Nacionalidad, Altura, Peso, Foto, 
                                           Activo, FechaAlta 
                                    FROM Jugadores 
                                    WHERE IdEquipo = @IdEquipo AND Activo = 1
                                    ORDER BY Dorsal";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                jugadores.Add(MapearJugador(reader));
                            }
                        }
                    }
                }

                return jugadores;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener jugadores del equipo: {ex.Message}");
            }
        }

        /// <summary>
        /// Busca jugadores por nombre o apellidos
        /// </summary>
        public List<Jugador> BuscarPorNombre(string nombre)
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdJugador, IdEquipo, Nombre, Apellidos, FechaNacimiento, 
                                           Posicion, Dorsal, Nacionalidad, Altura, Peso, Foto, 
                                           Activo, FechaAlta 
                                    FROM Jugadores 
                                    WHERE (Nombre LIKE @Nombre OR Apellidos LIKE @Nombre) 
                                    AND Activo = 1
                                    ORDER BY Apellidos, Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", $"%{nombre}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                jugadores.Add(MapearJugador(reader));
                            }
                        }
                    }
                }

                return jugadores;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar jugadores: {ex.Message}");
            }
        }

        /// <summary>
        /// Filtra jugadores por posición
        /// </summary>
        public List<Jugador> FiltrarPorPosicion(string posicion)
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT IdJugador, IdEquipo, Nombre, Apellidos, FechaNacimiento, 
                                           Posicion, Dorsal, Nacionalidad, Altura, Peso, Foto, 
                                           Activo, FechaAlta 
                                    FROM Jugadores 
                                    WHERE Posicion = @Posicion AND Activo = 1
                                    ORDER BY Apellidos, Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Posicion", posicion);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                jugadores.Add(MapearJugador(reader));
                            }
                        }
                    }
                }

                return jugadores;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar jugadores: {ex.Message}");
            }
        }

        #endregion

        #region UPDATE - Actualizar

        /// <summary>
        /// Actualiza un jugador existente
        /// </summary>
        public bool Actualizar(Jugador jugador)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Jugadores SET 
                                    IdEquipo = @IdEquipo,
                                    Nombre = @Nombre, 
                                    Apellidos = @Apellidos, 
                                    FechaNacimiento = @FechaNacimiento, 
                                    Posicion = @Posicion, 
                                    Dorsal = @Dorsal, 
                                    Nacionalidad = @Nacionalidad, 
                                    Altura = @Altura, 
                                    Peso = @Peso, 
                                    Foto = @Foto, 
                                    Activo = @Activo 
                                    WHERE IdJugador = @IdJugador";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdJugador", jugador.IdJugador);
                        cmd.Parameters.AddWithValue("@IdEquipo", jugador.IdEquipo);
                        cmd.Parameters.AddWithValue("@Nombre", jugador.Nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", jugador.Apellidos);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", jugador.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Posicion", jugador.Posicion);
                        cmd.Parameters.AddWithValue("@Dorsal", jugador.Dorsal);
                        cmd.Parameters.AddWithValue("@Nacionalidad", jugador.Nacionalidad);
                        cmd.Parameters.AddWithValue("@Altura",
                            jugador.Altura.HasValue ? (object)jugador.Altura.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Peso",
                            jugador.Peso.HasValue ? (object)jugador.Peso.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Foto",
                            string.IsNullOrEmpty(jugador.Foto) ? DBNull.Value : (object)jugador.Foto);
                        cmd.Parameters.AddWithValue("@Activo", jugador.Activo);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar jugador: {ex.Message}");
            }
        }

        #endregion

        #region DELETE - Eliminar

        /// <summary>
        /// Elimina un jugador (marcándolo como inactivo)
        /// </summary>
        public bool Eliminar(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "UPDATE Jugadores SET Activo = 0 WHERE IdJugador = @IdJugador";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdJugador", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar jugador: {ex.Message}");
            }
        }

        /// <summary>
        /// Elimina físicamente un jugador de la base de datos
        /// </summary>
        public bool EliminarFisicamente(int id)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM Jugadores WHERE IdJugador = @IdJugador";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdJugador", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar jugador: {ex.Message}");
            }
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Mapea un registro de la BD a un objeto Jugador
        /// </summary>
        private Jugador MapearJugador(SqlDataReader reader)
        {
            return new Jugador
            {
                IdJugador = reader.GetInt32(reader.GetOrdinal("IdJugador")),
                IdEquipo = reader.GetInt32(reader.GetOrdinal("IdEquipo")),
                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                Apellidos = reader.GetString(reader.GetOrdinal("Apellidos")),
                FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                Posicion = reader.GetString(reader.GetOrdinal("Posicion")),
                Dorsal = reader.GetInt32(reader.GetOrdinal("Dorsal")),
                Nacionalidad = reader.GetString(reader.GetOrdinal("Nacionalidad")),
                Altura = reader.IsDBNull(reader.GetOrdinal("Altura"))
                    ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("Altura")),
                Peso = reader.IsDBNull(reader.GetOrdinal("Peso"))
                    ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("Peso")),
                Foto = reader.IsDBNull(reader.GetOrdinal("Foto"))
                    ? null : reader.GetString(reader.GetOrdinal("Foto")),
                Activo = reader.GetBoolean(reader.GetOrdinal("Activo")),
                FechaAlta = reader.GetDateTime(reader.GetOrdinal("FechaAlta"))
            };
        }

        /// <summary>
        /// Verifica si un dorsal está disponible en un equipo
        /// </summary>
        public bool DorsalDisponible(int idEquipo, int dorsal, int idJugadorExcluir = 0)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) FROM Jugadores 
                                    WHERE IdEquipo = @IdEquipo 
                                    AND Dorsal = @Dorsal 
                                    AND IdJugador != @IdJugadorExcluir
                                    AND Activo = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);
                        cmd.Parameters.AddWithValue("@Dorsal", dorsal);
                        cmd.Parameters.AddWithValue("@IdJugadorExcluir", idJugadorExcluir);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar dorsal: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene el total de jugadores activos
        /// </summary>
        public int ObtenerTotal()
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Jugadores WHERE Activo = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener total de jugadores: {ex.Message}");
            }
        }

        /// <summary>
        /// Devuelve true si el dorsal ya esta elegido y false en el caso contrario
        /// </summary>
        public bool ExisteDorsal(int idEquipo, int dorsal, int idJugadorActual = 0)
        {
            try
            {
                using (SqlConnection connection = ConexionSQLServer.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT COUNT(*) 
                           FROM Jugadores 
                           WHERE IdEquipo = @IdEquipo 
                           AND Dorsal = @Dorsal 
                           AND IdJugador != @IdJugadorActual";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);
                        cmd.Parameters.AddWithValue("@Dorsal", dorsal);
                        cmd.Parameters.AddWithValue("@IdJugadorActual", idJugadorActual);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar dorsal: {ex.Message}");
            }
        }

        #endregion
    }
}
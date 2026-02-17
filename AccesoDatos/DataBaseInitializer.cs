using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace LigaZamaca.AccesoDatos
{
    /// <summary>
    /// Clase para inicializar y crear la base de datos automáticamente
    /// </summary>
    public static class DatabaseInitializer
    {
        private const string DATABASE_NAME = "LigaFutbol";

        /// <summary>
        /// Verifica si la base de datos existe y la crea si no existe
        /// </summary>
        /// <returns>True si la BD está lista, False si hubo error</returns>
        public static bool InicializarBaseDatos()
        {
            try
            {
                // Primero intentar conectar a la BD existente
                if (ExisteBaseDatos())
                {
                    return true;
                }

                // Si no existe, preguntar al usuario si quiere crearla
                DialogResult resultado = MessageBox.Show(
                    "La base de datos 'LigaFutbol' no existe.\n\n" +
                    "¿Desea crearla automáticamente con datos de ejemplo?",
                    "Base de datos no encontrada",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    return CrearBaseDatos();
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al inicializar la base de datos:\n\n{ex.Message}\n\n" +
                    "Asegúrese de que SQL Server esté instalado y en ejecución.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Verifica si la base de datos existe
        /// </summary>
        private static bool ExisteBaseDatos()
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Crea la base de datos completa con tablas, vistas y datos de ejemplo
        /// </summary>
        private static bool CrearBaseDatos()
        {
            try
            {
                // Obtener cadena de conexión a master
                string connectionStringMaster = ObtenerConnectionStringMaster();

                using (SqlConnection conn = new SqlConnection(connectionStringMaster))
                {
                    conn.Open();

                    // 1. Crear la base de datos
                    ExecuteNonQuery(conn, $@"
                        IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '{DATABASE_NAME}')
                        BEGIN
                            CREATE DATABASE [{DATABASE_NAME}]
                        END");
                }

                // Esperar un momento para que la BD se cree
                System.Threading.Thread.Sleep(1000);

                // 2. Conectar a la nueva BD y crear tablas
                using (SqlConnection conn = ConexionSQLServer.GetConnection())
                {
                    conn.Open();

                    // Crear tablas
                    CrearTablas(conn);

                    // Crear vistas para informes
                    CrearVistas(conn);

                    // Insertar datos de ejemplo
                    InsertarDatosEjemplo(conn);
                }

                MessageBox.Show(
                    "✅ Base de datos creada correctamente.\n\n" +
                    "Se han insertado datos de ejemplo para que puedas probar la aplicación.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al crear la base de datos:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Obtiene la cadena de conexión a la base de datos master
        /// </summary>
        private static string ObtenerConnectionStringMaster()
        {
            // Intentar diferentes servidores comunes
            string[] servidores = new string[]
            {
                @".\SQLEXPRESS",
                @"(localdb)\MSSQLLocalDB",
                @"localhost",
                @"localhost\SQLEXPRESS",
                @"(local)",
                @"(local)\SQLEXPRESS"
            };

            foreach (string servidor in servidores)
            {
                string connStr = $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        // Si llegamos aquí, el servidor funciona
                        return connStr;
                    }
                }
                catch
                {
                    continue;
                }
            }

            throw new Exception(
                "No se pudo encontrar un servidor SQL Server.\n\n" +
                "Servidores probados:\n" +
                "- .\\SQLEXPRESS\n" +
                "- (localdb)\\MSSQLLocalDB\n" +
                "- localhost\n\n" +
                "Asegúrese de que SQL Server esté instalado y en ejecución.");
        }

        /// <summary>
        /// Crea las tablas de la base de datos
        /// </summary>
        private static void CrearTablas(SqlConnection conn)
        {
            // Tabla Equipos
            ExecuteNonQuery(conn, @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Equipos')
                BEGIN
                    CREATE TABLE Equipos (
                        IdEquipo INT IDENTITY(1,1) PRIMARY KEY,
                        Nombre NVARCHAR(100) NOT NULL,
                        Estadio NVARCHAR(100) NOT NULL,
                        Ciudad NVARCHAR(100) NOT NULL,
                        Entrenador NVARCHAR(100),
                        Escudo NVARCHAR(255),
                        FechaFundacion DATE,
                        Presupuesto DECIMAL(18,2),
                        Email NVARCHAR(100),
                        Telefono NVARCHAR(20),
                        FechaRegistro DATETIME DEFAULT GETDATE()
                    )
                END");

            // Tabla Jugadores
            ExecuteNonQuery(conn, @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Jugadores')
                BEGIN
                    CREATE TABLE Jugadores (
                        IdJugador INT IDENTITY(1,1) PRIMARY KEY,
                        IdEquipo INT NOT NULL,
                        Nombre NVARCHAR(100) NOT NULL,
                        Apellidos NVARCHAR(100) NOT NULL,
                        FechaNacimiento DATE NOT NULL,
                        Posicion NVARCHAR(50) NOT NULL,
                        Dorsal INT NOT NULL,
                        Nacionalidad NVARCHAR(50) NOT NULL,
                        Altura DECIMAL(3,2),
                        Peso DECIMAL(5,2),
                        Foto NVARCHAR(255),
                        Activo BIT DEFAULT 1,
                        FechaAlta DATETIME DEFAULT GETDATE(),
                        FOREIGN KEY (IdEquipo) REFERENCES Equipos(IdEquipo)
                    )
                END");

            // Tabla Partidos
            ExecuteNonQuery(conn, @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Partidos')
                BEGIN
                    CREATE TABLE Partidos (
                        IdPartido INT IDENTITY(1,1) PRIMARY KEY,
                        IdEquipoLocal INT NOT NULL,
                        IdEquipoVisitante INT NOT NULL,
                        FechaHora DATETIME NOT NULL,
                        Jornada INT NOT NULL,
                        GolesLocal INT DEFAULT 0,
                        GolesVisitante INT DEFAULT 0,
                        Estadio NVARCHAR(100) NOT NULL,
                        Arbitro NVARCHAR(100),
                        Estado NVARCHAR(20) DEFAULT 'Programado',
                        Asistencia INT,
                        FechaRegistro DATETIME DEFAULT GETDATE(),
                        FOREIGN KEY (IdEquipoLocal) REFERENCES Equipos(IdEquipo),
                        FOREIGN KEY (IdEquipoVisitante) REFERENCES Equipos(IdEquipo)
                    )
                END");

            // Tabla Estadisticas
            ExecuteNonQuery(conn, @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Estadisticas')
                BEGIN
                    CREATE TABLE Estadisticas (
                        IdEstadistica INT IDENTITY(1,1) PRIMARY KEY,
                        IdJugador INT NOT NULL,
                        IdPartido INT NOT NULL,
                        Goles INT DEFAULT 0,
                        TarjetasAmarillas INT DEFAULT 0,
                        TarjetasRojas INT DEFAULT 0,
                        Asistencias INT DEFAULT 0,
                        MinutosJugados INT DEFAULT 0,
                        Titular BIT DEFAULT 0,
                        FechaRegistro DATETIME DEFAULT GETDATE(),
                        FOREIGN KEY (IdJugador) REFERENCES Jugadores(IdJugador),
                        FOREIGN KEY (IdPartido) REFERENCES Partidos(IdPartido)
                    )
                END");
        }

        /// <summary>
        /// Crea las vistas para los informes
        /// </summary>
        private static void CrearVistas(SqlConnection conn)
        {
            // Vista Clasificación
            ExecuteNonQuery(conn, @"
                IF EXISTS (SELECT * FROM sys.views WHERE name = 'Vista_Clasificacion')
                    DROP VIEW Vista_Clasificacion");

            ExecuteNonQuery(conn, @"
                CREATE VIEW Vista_Clasificacion AS
                SELECT 
                    e.IdEquipo,
                    e.Nombre AS Equipo,
                    e.Escudo,
                    COUNT(CASE WHEN p.Estado = 'Finalizado' THEN 1 END) AS PJ,
                    COUNT(CASE WHEN p.Estado = 'Finalizado' AND 
                          ((p.IdEquipoLocal = e.IdEquipo AND p.GolesLocal > p.GolesVisitante) OR
                           (p.IdEquipoVisitante = e.IdEquipo AND p.GolesVisitante > p.GolesLocal)) THEN 1 END) AS PG,
                    COUNT(CASE WHEN p.Estado = 'Finalizado' AND p.GolesLocal = p.GolesVisitante THEN 1 END) AS PE,
                    COUNT(CASE WHEN p.Estado = 'Finalizado' AND 
                          ((p.IdEquipoLocal = e.IdEquipo AND p.GolesLocal < p.GolesVisitante) OR
                           (p.IdEquipoVisitante = e.IdEquipo AND p.GolesVisitante < p.GolesLocal)) THEN 1 END) AS PP,
                    ISNULL(SUM(CASE WHEN p.IdEquipoLocal = e.IdEquipo THEN p.GolesLocal 
                                    WHEN p.IdEquipoVisitante = e.IdEquipo THEN p.GolesVisitante END), 0) AS GF,
                    ISNULL(SUM(CASE WHEN p.IdEquipoLocal = e.IdEquipo THEN p.GolesVisitante 
                                    WHEN p.IdEquipoVisitante = e.IdEquipo THEN p.GolesLocal END), 0) AS GC,
                    ISNULL(SUM(CASE WHEN p.IdEquipoLocal = e.IdEquipo THEN p.GolesLocal - p.GolesVisitante
                                    WHEN p.IdEquipoVisitante = e.IdEquipo THEN p.GolesVisitante - p.GolesLocal END), 0) AS DG,
                    (COUNT(CASE WHEN p.Estado = 'Finalizado' AND 
                          ((p.IdEquipoLocal = e.IdEquipo AND p.GolesLocal > p.GolesVisitante) OR
                           (p.IdEquipoVisitante = e.IdEquipo AND p.GolesVisitante > p.GolesLocal)) THEN 1 END) * 3 +
                     COUNT(CASE WHEN p.Estado = 'Finalizado' AND p.GolesLocal = p.GolesVisitante THEN 1 END)) AS Puntos
                FROM Equipos e
                LEFT JOIN Partidos p ON (p.IdEquipoLocal = e.IdEquipo OR p.IdEquipoVisitante = e.IdEquipo)
                GROUP BY e.IdEquipo, e.Nombre, e.Escudo");

            // Vista Top Goleadores
            ExecuteNonQuery(conn, @"
                IF EXISTS (SELECT * FROM sys.views WHERE name = 'Vista_TopGoleadores')
                    DROP VIEW Vista_TopGoleadores");

            ExecuteNonQuery(conn, @"
                CREATE VIEW Vista_TopGoleadores AS
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY ISNULL(SUM(est.Goles), 0) DESC) AS Posicion,
                    j.IdJugador,
                    CONCAT(j.Nombre, ' ', j.Apellidos) AS NombreCompleto,
                    e.Nombre AS NombreEquipo,
                    e.Escudo AS EscudoEquipo,
                    ISNULL(SUM(est.Goles), 0) AS TotalGoles,
                    ISNULL(SUM(est.Asistencias), 0) AS TotalAsistencias,
                    COUNT(DISTINCT est.IdPartido) AS PartidosJugados
                FROM Jugadores j
                INNER JOIN Equipos e ON j.IdEquipo = e.IdEquipo
                LEFT JOIN Estadisticas est ON j.IdJugador = est.IdJugador
                WHERE j.Activo = 1
                GROUP BY j.IdJugador, j.Nombre, j.Apellidos, e.Nombre, e.Escudo");
        }

        /// <summary>
        /// Inserta datos de ejemplo en la base de datos
        /// </summary>
        private static void InsertarDatosEjemplo(SqlConnection conn)
        {
            // Insertar equipos de ejemplo
            ExecuteNonQuery(conn, @"
                IF NOT EXISTS (SELECT * FROM Equipos)
                BEGIN
                    INSERT INTO Equipos (Nombre, Estadio, Ciudad, Entrenador, Escudo, FechaFundacion, Presupuesto)
                    VALUES 
                    ('Real Madrid CF', 'Santiago Bernabéu', 'Madrid', 'Carlo Ancelotti', 'https://a.espncdn.com/i/teamlogos/soccer/500/86.png', '1902-03-06', 750000000),
                    ('FC Barcelona', 'Camp Nou', 'Barcelona', 'Xavi Hernández', 'https://a.espncdn.com/i/teamlogos/soccer/500/83.png', '1899-11-29', 700000000),
                    ('Atlético de Madrid', 'Civitas Metropolitano', 'Madrid', 'Diego Simeone', 'https://a.espncdn.com/i/teamlogos/soccer/500/1068.png', '1903-04-26', 400000000),
                    ('Sevilla FC', 'Ramón Sánchez-Pizjuán', 'Sevilla', 'Quique Sánchez Flores', 'https://a.espncdn.com/i/teamlogos/soccer/500/243.png', '1890-01-25', 200000000),
                    ('Real Betis', 'Benito Villamarín', 'Sevilla', 'Manuel Pellegrini', 'https://a.espncdn.com/i/teamlogos/soccer/500/244.png', '1907-09-12', 150000000),
                    ('Real Sociedad', 'Reale Arena', 'San Sebastián', 'Imanol Alguacil', 'https://a.espncdn.com/i/teamlogos/soccer/500/89.png', '1909-09-07', 120000000),
                    ('Valencia CF', 'Mestalla', 'Valencia', 'Rubén Baraja', 'https://a.espncdn.com/i/teamlogos/soccer/500/94.png', '1919-03-18', 180000000),
                    ('Athletic Club', 'San Mamés', 'Bilbao', 'Ernesto Valverde', 'https://a.espncdn.com/i/teamlogos/soccer/500/93.png', '1898-06-14', 160000000)
                END");

            // Insertar jugadores de ejemplo
            ExecuteNonQuery(conn, @"
                IF NOT EXISTS (SELECT * FROM Jugadores)
                BEGIN
                    -- Real Madrid
                    INSERT INTO Jugadores (IdEquipo, Nombre, Apellidos, FechaNacimiento, Posicion, Dorsal, Nacionalidad, Altura, Peso)
                    VALUES 
                    (1, 'Vinícius', 'Júnior', '2000-07-12', 'Delantero', 7, 'Brasil', 1.76, 73),
                    (1, 'Jude', 'Bellingham', '2003-06-29', 'Centrocampista', 5, 'Inglaterra', 1.86, 75),
                    (1, 'Thibaut', 'Courtois', '1992-05-11', 'Portero', 1, 'Bélgica', 1.99, 96),
                    
                    -- Barcelona
                    (2, 'Robert', 'Lewandowski', '1988-08-21', 'Delantero', 9, 'Polonia', 1.85, 81),
                    (2, 'Pedri', 'González', '2002-11-25', 'Centrocampista', 8, 'España', 1.74, 63),
                    (2, 'Marc-André', 'ter Stegen', '1992-04-30', 'Portero', 1, 'Alemania', 1.87, 85),
                    
                    -- Atlético
                    (3, 'Antoine', 'Griezmann', '1991-03-21', 'Delantero', 7, 'Francia', 1.76, 73),
                    (3, 'Álvaro', 'Morata', '1992-10-23', 'Delantero', 9, 'España', 1.90, 84),
                    
                    -- Sevilla
                    (4, 'Youssef', 'En-Nesyri', '1997-06-01', 'Delantero', 15, 'Marruecos', 1.89, 78),
                    
                    -- Betis
                    (5, 'Borja', 'Iglesias', '1993-01-17', 'Delantero', 9, 'España', 1.87, 82)
                END");

            // Insertar partidos de ejemplo
            ExecuteNonQuery(conn, @"
                IF NOT EXISTS (SELECT * FROM Partidos)
                BEGIN
                    INSERT INTO Partidos (IdEquipoLocal, IdEquipoVisitante, FechaHora, Jornada, GolesLocal, GolesVisitante, Estadio, Arbitro, Estado)
                    VALUES 
                    (1, 2, '2025-01-15 21:00', 1, 2, 1, 'Santiago Bernabéu', 'Mateu Lahoz', 'Finalizado'),
                    (3, 4, '2025-01-15 18:30', 1, 1, 1, 'Civitas Metropolitano', 'Gil Manzano', 'Finalizado'),
                    (5, 6, '2025-01-16 21:00', 1, 0, 2, 'Benito Villamarín', 'Del Cerro Grande', 'Finalizado'),
                    (7, 8, '2025-01-16 18:30', 1, 1, 0, 'Mestalla', 'Hernández Hernández', 'Finalizado'),
                    (2, 3, '2025-01-22 21:00', 2, 3, 1, 'Camp Nou', 'Martínez Munuera', 'Finalizado'),
                    (4, 1, '2025-01-22 18:30', 2, 0, 2, 'Ramón Sánchez-Pizjuán', 'Soto Grado', 'Finalizado'),
                    (6, 7, '2025-01-23 21:00', 2, 2, 2, 'Reale Arena', 'Cuadra Fernández', 'Finalizado'),
                    (8, 5, '2025-01-23 18:30', 2, 1, 1, 'San Mamés', 'Alberola Rojas', 'Finalizado')
                END");

            // Insertar estadísticas de ejemplo
            ExecuteNonQuery(conn, @"
                IF NOT EXISTS (SELECT * FROM Estadisticas)
                BEGIN
                    -- Jornada 1: Real Madrid 2-1 Barcelona
                    INSERT INTO Estadisticas (IdJugador, IdPartido, Goles, Asistencias, TarjetasAmarillas, MinutosJugados, Titular)
                    VALUES 
                    (1, 1, 1, 0, 0, 90, 1),  -- Vinícius gol
                    (2, 1, 1, 1, 1, 90, 1),  -- Bellingham gol y asistencia
                    (4, 1, 1, 0, 0, 90, 1),  -- Lewandowski gol
                    (5, 1, 0, 1, 0, 85, 1),  -- Pedri asistencia
                    
                    -- Jornada 2: Barcelona 3-1 Atlético
                    (4, 5, 2, 0, 0, 90, 1),  -- Lewandowski 2 goles
                    (5, 5, 1, 2, 0, 90, 1),  -- Pedri gol y 2 asistencias
                    (7, 5, 1, 0, 1, 90, 1),  -- Griezmann gol
                    
                    -- Jornada 2: Sevilla 0-2 Real Madrid
                    (1, 6, 1, 1, 0, 90, 1),  -- Vinícius gol y asistencia
                    (2, 6, 1, 0, 0, 90, 1)   -- Bellingham gol
                END");
        }

        /// <summary>
        /// Ejecuta una consulta que no devuelve resultados
        /// </summary>
        private static void ExecuteNonQuery(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandTimeout = 60;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
using System;

namespace LigaZamaca.Modelos
{
    /// <summary>
    /// Modelo para representar un goleador en el ranking
    /// </summary>
    public class TopGoleador
    {
        public int IdJugador { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellidos}";
        public string NombreEquipo { get; set; }
        public string EscudoEquipo { get; set; }
        public int TotalGoles { get; set; }
        public int TotalAsistencias { get; set; }
        public int PartidosJugados { get; set; }

        // Propiedad calculada
        public int Posicion { get; set; }
        public double PromedioGoles => PartidosJugados > 0 ? (double)TotalGoles / PartidosJugados : 0;

        public TopGoleador()
        {
        }

        /// <summary>
        /// Representación en texto
        /// </summary>
        public override string ToString()
        {
            return $"{Posicion}. {NombreCompleto} - {TotalGoles} goles";
        }
    }
}
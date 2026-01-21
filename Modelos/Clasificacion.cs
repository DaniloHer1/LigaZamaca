using System;

namespace LigaZamaca.Modelos
{
    /// <summary>
    /// Modelo para representar la clasificación de un equipo en la liga
    /// </summary>
    public class Clasificacion
    {
        public int IdEquipo { get; set; }
        public string Equipo { get; set; }
        public string Escudo { get; set; }

        // Estadísticas
        public int PJ { get; set; }  // Partidos Jugados
        public int PG { get; set; }  // Partidos Ganados
        public int PE { get; set; }  // Partidos Empatados
        public int PP { get; set; }  // Partidos Perdidos
        public int GF { get; set; }  // Goles a Favor
        public int GC { get; set; }  // Goles en Contra
        public int DG { get; set; }  // Diferencia de Goles
        public int Puntos { get; set; }

        // Propiedad calculada para la posición (se asigna en el formulario)
        public int Posicion { get; set; }

        public Clasificacion()
        {
        }

        /// <summary>
        /// Representación en texto de la clasificación
        /// </summary>
        public override string ToString()
        {
            return $"{Posicion}. {Equipo} - {Puntos} pts";
        }
    }
}
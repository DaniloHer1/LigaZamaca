using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaZamaca.Modelos
{
    public class Jugador
    {


        public int? IdJugador { get; set; }
        public int? IdEquipo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Posicion { get; set; }
        public int? Dorsal { get; set; }
        public string Nacionalidad { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Peso { get; set; }
        public string Foto { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        public string NombreEquipo { get; set; }

        public Jugador()
        {

            FechaAlta = DateTime.Now;
            Activo = true;

        }

        public Jugador(int idEquipo, string nombre, string apellidos, DateTime fechaNacimiento, string posicion, int dorsal, string nacionalidad)
        {

            IdEquipo = idEquipo;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Posicion = posicion;
            Dorsal = dorsal;
            Nacionalidad = nacionalidad;
            Activo = true;
            FechaAlta = DateTime.Now;

        }


        public int CalcularEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Value.Year;


            if (DateTime.Now < FechaNacimiento.Value.AddYears(edad))
                edad--;

            return edad;
        }
    }
}

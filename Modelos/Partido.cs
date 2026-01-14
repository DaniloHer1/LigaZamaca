using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LigaZamaca.Modelos
{
    public class Partido
    {
        public int IdPartido { get; set; }
        public int IdEquipoLocal { get; set; }
        public int IdEquipoVisitante { get; set; }

        // ⭐ NUEVAS PROPIEDADES para mostrar en el DataGridView
        public string NombreEquipoLocal { get; set; }
        public string NombreEquipoVisitante { get; set; }

        public DateTime FechaHora { get; set; }
        public int Jornada { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public string Estadio { get; set; }
        public string Arbitro { get; set; }
        public string Estado { get; set; }
        public int? Asistencia { get; set; }
        public DateTime FechaRegistro { get; set; }

        // ⭐ Propiedad calculada para mostrar el resultado
        public string Resultado
        {
            get
            {
                if (Estado == "Programado")
                    return "-";
                return $"{GolesLocal} - {GolesVisitante}";
            }
        }

        public Partido()
        {
            FechaRegistro = DateTime.Now;
            Estado = "Programado";
            GolesLocal = 0;
            GolesVisitante = 0;
        }

        public Partido(int idPartido, int idEquipoLocal, int idEquipoVisitante, DateTime fecha, int jornada, int golesLocales, int golesVisitantes, string estadio, string arbitro, string estado, int asistencia, DateTime fechaRegistro)
        {
            IdPartido = idPartido;
            this.IdEquipoLocal = idEquipoLocal;
            this.IdEquipoVisitante = idEquipoVisitante;
            FechaHora = fecha;
            Jornada = jornada;
            GolesLocal = golesLocales;
            GolesVisitante = golesVisitantes;
            Estadio = estadio;
            Arbitro = arbitro;
            Estado = estado;
            Asistencia = asistencia;
            FechaRegistro = DateTime.Now;
        }
    }
}
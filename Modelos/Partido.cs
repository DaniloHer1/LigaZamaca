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
        public int IdEquipoLocal {  get; set; }
        public int IdEquipoVisitante { get; set; }
        public DateTime Fecha { get; set; }
        public int Jornada { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public string Estadio {  get; set; }
        public string Arbitro {  get; set; }
        public string Estado { get; set; }
        public int? Asistencia { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Partido()
        {
            FechaRegistro = DateTime.Now;
        }

        public Partido(int idPartido, int idEquipoLocal, int idEquipoVisitante, DateTime fecha, int jornada, int golesLocales, int golesVisitantes, string estadio, string arbitro, string estado, int asistencia, DateTime fechaRegistro)
        {
            IdPartido = idPartido;
            this.IdEquipoLocal = idEquipoLocal;
            this.IdEquipoVisitante = idEquipoVisitante;
            Fecha = fecha;
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

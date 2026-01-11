using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaZamaca.Modelos
{
    public class Equipo
    {


        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public string Estadio { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
        public string Escudo { get; set; }
        public DateTime? FechaFundacion { get; set; }
        public decimal? Presupuesto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Equipo()
        {

            FechaRegistro = DateTime.Now;
        }
        public Equipo(string nombre,string estadio,string ciudad)
        {
            Nombre = nombre;
            Estadio = estadio;
            Ciudad= ciudad;
            FechaRegistro=DateTime.Now;
        }

        public Equipo(int idEquipo, string nombre, string estadio, string ciudad, string entrenador, string escudo, DateTime? fechaFundacion, decimal? presupuesto, string email, string telefono, DateTime fechaRegistro)
        {
            this.IdEquipo = idEquipo;
            Nombre = nombre;
            Estadio = estadio;
            Ciudad = ciudad;
            Entrenador = entrenador;
            Escudo = escudo;
            FechaFundacion = fechaFundacion;
            Presupuesto = presupuesto;
            Email = email;
            Telefono = telefono;
            FechaRegistro = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{{{nameof(IdEquipo)}={IdEquipo.ToString()}, {nameof(Nombre)}={Nombre}, {nameof(Estadio)}={Estadio}, {nameof(Ciudad)}={Ciudad}, {nameof(Entrenador)}={Entrenador}, {nameof(Escudo)}={Escudo}, {nameof(FechaFundacion)}={FechaFundacion.ToString()}, {nameof(Presupuesto)}={Presupuesto.ToString()}, {nameof(Email)}={Email}, {nameof(Telefono)}={Telefono}, {nameof(FechaRegistro)}={FechaRegistro.ToString()}}}";
        }
    }
}

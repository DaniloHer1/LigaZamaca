using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaZamaca.Modelos
{
    public class Estadistica
    {


        public int IdEstadistica { get; set; }
        public int IdJugador { get; set; }
        public int IdPartido { get; set; }
        public int Goles { get; set; }
        public int TarjetasAmarillas { get; set; }
        public int TarjetasRojas { get; set; }
        public int Asistencias { get; set; }
        public int MinutosJugados { get; set; }
        public bool Titular { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Estadistica()
        {
            FechaRegistro= DateTime.Now;
        }
        public Estadistica(int idJugador, int idPartido, bool titular, int minutosJugados)
        {
            IdJugador = idJugador;
            IdPartido = idPartido;
            Titular = titular;
            MinutosJugados = minutosJugados;
            Goles = 0;
            TarjetasAmarillas = 0;
            TarjetasRojas = 0;
            Asistencias = 0;
            FechaRegistro = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Goles}G {Asistencias}A - {MinutosJugados}'";
        }
        public string ObtenerResumen()
        {
            string resumen = "";

            if (Goles > 0)
                resumen += $"{Goles} gol{(Goles > 1 ? "es" : "")}";

            if (Asistencias > 0)
            {
                if (resumen != "") resumen += ", ";
                resumen += $"{Asistencias} asistencia{(Asistencias > 1 ? "s" : "")}";
            }

            if (TarjetasAmarillas > 0)
            {
                if (resumen != "") resumen += ", ";
                resumen += $"{TarjetasAmarillas} tarjeta{(TarjetasAmarillas > 1 ? "s" : "")} amarilla{(TarjetasAmarillas > 1 ? "s" : "")}";
            }

            if (TarjetasRojas > 0)
            {
                if (resumen != "") resumen += ", ";
                resumen += "tarjeta roja";
            }

            if (resumen == "")
                resumen = "Sin incidencias";

            resumen += $" ({MinutosJugados} minutos)";

            return resumen;
        }
    }
}

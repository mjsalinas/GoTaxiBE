using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Dto
{
    public class ViajesDto
    {
        public int IdViaje { get; set; }
        public int IdConductor { get; set; }

        public int IdVehiculo { get; set; }

        public string PuntoPartida { get; set; }

        public string PuntoDestino { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime HoraRegistro { get; set; }

        public DateTime HoraProgramada { get; set; }

        public int NoPasajerosTotal { get; set; }

        public double Tarifa { get; set; }

        public string EstadoActual { get; set; }

        public string MensajeDeError { get; set; }
    }
}

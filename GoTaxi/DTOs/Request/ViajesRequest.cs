using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Request
{
    public class ObtenerViajesRequest
    {
    }

    public class NuevoViajeRequest
    {
        public int IdConductor { get; set; }
        public ConductorDto Conductor { get; set; }

        public int IdVehiculo { get; set; }
        public int IdPasajero { get; set; }

        public VehiculosDto Vehiculo { get; set; }

        public UsuariosDto Pasajero { get; set; }
        public string PuntoPartida { get; set; }

        public string PuntoDestino { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime HoraRegistro { get; set; }

        public DateTime HoraProgramada { get; set; }

        public int NoPasajerosTotal { get; set; }

        public double Tarifa { get; set; }

    }

    public class ModificarViajeRequest
    {
        public int IdViaje { get; set; }
        public int IdConductor { get; set; }
        public int IdPasajero { get; set; }

        public int IdVehiculo { get; set; }

        public string PuntoPartida { get; set; }

        public string PuntoDestino { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime HoraRegistro { get; set; }

        public DateTime HoraProgramada { get; set; }

        public int NoPasajerosTotal { get; set; }

        public double Tarifa { get; set; }
    }
}

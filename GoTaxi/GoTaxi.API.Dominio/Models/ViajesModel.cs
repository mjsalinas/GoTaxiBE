using GoTaxi.GoTaxi.API.Dominio.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoTaxi.API.Dominio.Models
{
    public class ViajesModel
    {
        [Key]
        public int IdViaje { get; set; }

        public int IdConductor { get; set; }
        [ForeignKey("IdConductor")]
        public ConductoresModel Conductor { get; set; }

        public int IdVehiculo { get; set; }
        [ForeignKey("IdVehiculo")]
        public VehiculosModel Vehiculo { get; set; }

        public int IdPasajero { get; set; }
        [ForeignKey("IdUsuario")]
        public UsuariosModel Pasajero { get; set; }

        public string PuntoPartida { get; set; }

        public string PuntoDestino { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime HoraRegistro { get; set; }

        public DateTime HoraProgramada { get; set; }

        public int NoPasajerosTotal { get; set; }

        public double Tarifa { get; set; }

        public string EstadoActual { get; set; }



    }
}

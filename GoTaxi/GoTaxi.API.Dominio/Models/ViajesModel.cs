using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GoTaxi.API.Dominio.Models
{
    public class ViajesModel
    {
        [Key]
        public int IdViaje { get; set; }

        public int IdConductor { get; set; }
        [ForeignKey("idUsuario")]

        public int IdVehiculo { get; set; }
        [ForeignKey("idVehiculo")]

        public int IdPasajero { get; set; }
        [ForeignKey("idUsuario")]

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

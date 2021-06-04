using GoTaxi.API.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Dto
{
    public class ViajeTransaccionesDto
    {
        public int IdViajeTransac { get; set; }
        public int IdViaje { get; set; }
        public ViajesModel Viaje { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
        public string MensajeDeError { get; set; }
    }
}

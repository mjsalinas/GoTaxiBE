using GoTaxi.API.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Request
{
    public class ViajeTransaccionesRequest
    {
    }

    public class ObtenerViajeTransaccionIdRequest
    {
        public int IdViajeTransac { get; set; }
    }

    public class NuevoViajeTransaccionRequest
    {
        public int IdViaje { get; set; }
        public ViajesModel Viaje { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
    }
    public class ModificarViajeTransaccionRequest
    {
        public int IdViajeTransac { get; set; }
        public int IdViaje { get; set; }
        public ViajesModel Viaje { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
    }
}

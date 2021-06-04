using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Request
{
    public class RetroalimentacionRequest
    {
    }

    public class NuevoRetroalimentacionRequest
    {
        public int IdRetroalimentacion { get; set; }

        public int IdViaje { get; set; }

        public ViajesDto Viaje { get; set; }

        public double Puntuacion { set; get; }

        public string Comentarios { set; get; }

        public DateTime FechaHora { get; set; }



    }
    public class ModificarRetroalimentacionRequest
    {
        public int IdRetroalimentacion { get; set; }

        public int IdViaje { get; set; }

        public ViajesDto Viaje { get; set; }

        public double Puntuacion { set; get; }

        public string Comentarios { set; get; }

        public DateTime FechaHora { get; set; }


    }
}

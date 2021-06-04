using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Dto
{
    public class RetroalimentacionDTO
    {
        public int IdRetroalimentacion { get; set; }

        public int IdViaje { get; set; }
        public ViajesDto Viaje { get; set; }

        public double Puntuacion { get; set; }

        public string Comentarios { get; set; }

        public String mensajeException { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GoTaxi.API.Dominio.Models
{
    public class RetroalimentacionModel
    {
        [Key]
        public int IdRetroalimentacion { get; set; }

        public int IdViaje { get; set; }
        [ForeignKey("IdViaje")]
        public ViajesModel Viaje { get; set; }
                
        public double Puntuacion { get; set; }

        public string Comentarios { get; set; }
    }
}

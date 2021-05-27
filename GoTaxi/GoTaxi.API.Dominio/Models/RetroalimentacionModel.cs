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
        public int IdRetroalimentacion;
        
        public int IdViaje { get; set; }
        [ForeignKey("idViaje")]
                
        public double Puntuacion;

        public string Comentarios;
    }
}

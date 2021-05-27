using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GoTaxi.API.Dominio.Models
{
    public partial class ViajeTransaccionesModel
    {
        [Key]
        public int IdViajeTransac;

        public int IdViaje { get; set; }
        [ForeignKey("idViaje")]
        public ViajesModel Viaje { get; set; }

        public DateTime FechaHora;

        public string Estado;
    }
}

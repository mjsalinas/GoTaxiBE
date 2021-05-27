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
        public int IdViajeTransacciones { get; set; }

        public int IdViaje { get; set; }
        [ForeignKey("IdViaje")]
        public ViajesModel Viaje { get; set; }

        public DateTime FechaHora { get; set; }

        public string Estado { get; set; }
    }
}

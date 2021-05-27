using GoTaxi.API.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.GoTaxi.API.Dominio.Models
{
    public class ConductoresModel
    {
        [Key]
        public int IdConductor { get; set; }

        public int IdRol { get; set; }
        [ForeignKey("IdRol")]
        public RolesModel Rol { get; set; }

        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public string Telefono { get; set; }
    }
}

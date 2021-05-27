using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GoTaxi.API.Dominio.Models
{
    public class RolesModel
    {
        [Key]
        public int IdRol { get; set; }
        public string Rol { get; set; }
    }
}

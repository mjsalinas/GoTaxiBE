using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GoTaxi.API.Dominio.Models
{
    public class UsuariosModel
    {
        [Key]
        public int IdUsuario { get; set; }

        [ForeignKey("IdRol")]
        public int IdRol { get; set; }
        public RolesModel Rol { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public string Telefono { get; set; }
    }
}

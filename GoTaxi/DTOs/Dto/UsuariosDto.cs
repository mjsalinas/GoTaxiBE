using GoTaxi.API.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Dto
{
    public class UsuariosDto
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public RolesModel Rol { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public string Telefono { get; set; }
        public string MensajeDeError { get; set; }
    }
}

using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Request
{
    public class UsuariosRequest
    {
    }

    public class ObtenerUsuarioIdRequest
    {
        public int IdUsuario { get; set; }
    }

    public class NuevoUsuarioRequest
    {
        public string errorMessage;

        public int IdRol { get; set; }
        public RolesDto Rol { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public string Telefono { get; set; }
    }

    public class ModificarUsuarioRequest
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public RolesDto Rol { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public string Telefono { get; set; }
    }

    public class LoginUsuarioRequest
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
    }
}

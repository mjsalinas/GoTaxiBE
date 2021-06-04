using GoTaxi.API.Dominio.Models;
using GoTaxi.DTOs.Dto;
using GoTaxi.GoTaxi.API.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Roles
{
    public class RolesRepositorio : IRolesRepositorio
    {
        public GoTaxiContext Contexto = new GoTaxiContext();
        public List<RolesDto> ObtenerRoles()
        {
            List<RolesModel> roles = Contexto.Roles.ToList();
            List<RolesDto> rolesDTO = new List<RolesDto>();

            foreach (var rolDTO in roles)
            {
                rolesDTO.Add(new RolesDto
                {
                    IdRol = rolDTO.IdRol,
                    Rol = rolDTO.Rol,
                });
            }
            return rolesDTO;
        }
    }
}

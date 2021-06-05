using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Repositorios.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.RolesServices
{
    public class RolesAppService : IRolesAppService
    {
        private readonly IRolesRepositorio _rolesRepositorio;

        public RolesAppService(IRolesRepositorio rolesRepositorio)
        {
            if (rolesRepositorio == null) throw new ArgumentNullException("rolesRepositorio");
            _rolesRepositorio = rolesRepositorio;
        }
        public List<RolesDto> ObtenerRoles(RolesRequest request)
        {
            List<RolesDto> rolesExistentes = _rolesRepositorio.ObtenerRoles();
            return rolesExistentes;
        }
    }
}

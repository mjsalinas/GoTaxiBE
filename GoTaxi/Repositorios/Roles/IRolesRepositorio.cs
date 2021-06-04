using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Roles
{
    public interface IRolesRepositorio
    {
        public List<RolesDto> ObtenerRoles();
    }
}

using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.RolesServices
{
    public interface IRolesAppService
    {
        public List<RolesDto> ObtenerRoles(RolesRequest request);
    }
}

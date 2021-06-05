using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Servicios.RolesServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Controllers
{
    [ApiController]
    [Route("[/roles]")]
    public class RolController : ControllerBase
    {
        private readonly IRolesAppService _iRolesAppService;

        public RolController(IRolesAppService iRolesAppService)
        {
            _iRolesAppService = iRolesAppService;
        }

        [HttpGet]
        public IActionResult ObtenerRoles()
        {
            RolesRequest obtenerRolesRequest = new RolesRequest { };
            List<RolesDto> clientes = _iRolesAppService.ObtenerRoles(obtenerRolesRequest);
            return Ok(clientes);
        }
    }
}

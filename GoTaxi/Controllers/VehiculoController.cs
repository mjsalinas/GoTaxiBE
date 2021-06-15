using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Servicios.VehiculoService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Controllers
{
    [Route("vehiculos")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoAppService _ivehiculoAppService;

        public VehiculoController(IVehiculoAppService iVehiculoAppService)
        {
            _ivehiculoAppService = iVehiculoAppService;
        }


        [HttpGet]
        public IActionResult ObtenerVehiculo()
        {
            ObtenerVehiculoRequest obtenerVehiculoRequest = new ObtenerVehiculoRequest { };
            List<VehiculosDto> vehiculos = _ivehiculoAppService.ObtenerVehiculos(obtenerVehiculoRequest);
            return Ok(vehiculos);
        }

        [HttpPost]
        public IActionResult NuevoVehiculo()
        {
            var nuevoVehiculo = _ivehiculoAppService.NuevoVehiculos(request);
            if (string.IsNullOrEmpty(nuevoVehiculo.MensajeDeError))
            {
                return Ok(nuevoVehiculo);
            }
            else
            {
                return BadRequest(nuevoVehiculo);
            }
        }

    }
}
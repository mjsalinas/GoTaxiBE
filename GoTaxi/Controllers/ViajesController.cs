using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Servicios.ViajesServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Controllers
{

    [ApiController]
    [Route("[/viajes]")]
    public class ViajesController : ControllerBase
    {
        private readonly IViajesAppService _iViajesAppService;

        public ViajesController(IViajesAppService iViajesAppService)
        {
            _iViajesAppService = iViajesAppService;
        }

        [HttpGet]
        public IActionResult ObtenerViajes()
        {
            ObtenerViajesRequest obtenerViajesRequest = new ObtenerViajesRequest { };
            List<ViajesDto> viajes = _iViajesAppService.ObtenerViajes(obtenerViajesRequest);
            return Ok(viajes);
        }

        [HttpPost]
        public IActionResult CrearViaje(NuevoViajeRequest request)
        {
            var viaje = _iViajesAppService.CrearNuevoViaje(request);
            if (string.IsNullOrEmpty(viaje.MensajeDeError))
            {
                return Ok(viaje);
            }
            else
            {
                return BadRequest(viaje);
            }
        }
        [HttpPut]
        public IActionResult ModificarViaje(ModificarViajeRequest request)
        {
            var viaje = _iViajesAppService.ModificarViaje(request);
            if (string.IsNullOrEmpty(viaje.MensajeDeError))
            {
                return Ok(viaje);
            }
            else
            {
                return BadRequest(viaje);
            }
        }
    }
}

using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Servicios.ViajeService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Controllers
{
    [Route("transacciones")]
    [ApiController]
    public class ViajeTransaccionController : ControllerBase

    {
        private readonly IViajeTransaccionesAppService _IviajeTransaccionesAppService;

        public ViajeTransaccionController(IViajeTransaccionesAppService iViajeTransaccionesAppService)
        {
            _IviajeTransaccionesAppService = iViajeTransaccionesAppService;
        }

        [HttpGet]
        public IActionResult ObtenerViajesTransacciones()
        {
            ObtenerViajeTransaccionIdRequest obtenerViajesRequest = new ObtenerViajeTransaccionIdRequest { };
            List<ViajeTransaccionesDto> viajestransacciones = _IviajeTransaccionesAppService.ObtenerViajesTransacciones(obtenerViajesRequest);
            return Ok(viajestransacciones);
        }

        [HttpPost]
        public IActionResult CrearViajeTransaccion(NuevoViajeTransaccionRequest request)
        {
            var viajeTransaccion = _IviajeTransaccionesAppService.NuevoViajeTransaccion(request);
            if (string.IsNullOrEmpty(viajeTransaccion.MensajeDeError))
            {
                return Ok(viajeTransaccion);
            }
            else
            {
                return BadRequest(viajeTransaccion);
            }
        }
        [HttpPut]
        public IActionResult ModificarViajeTransaccion(ModificarViajeTransaccionRequest request)
        {
            var viajeTransaccion = _IviajeTransaccionesAppService.ModificarViajeTransaccio(request);
            if (string.IsNullOrEmpty(viajeTransaccion.MensajeDeError))
            {
                return Ok(viajeTransaccion);
            }
            else
            {
                return BadRequest(viajeTransaccion);
            }
        }
    }
}

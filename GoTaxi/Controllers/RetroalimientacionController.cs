using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Servicios.RetroalimentacionServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Controllers
{
    [ApiController]
    [Route("[/Retroalimentacion]")]
    public class RetroalimentacionController : ControllerBase
    {
        private readonly IRetroalimentacionAppService _iRetroalimentacionAppService;
        public RetroalimentacionController(IRetroalimentacionAppService iRetroalimentacionAppService)
        {
            _iRetroalimentacionAppService = iRetroalimentacionAppService;
        }

        [HttpGet]
        public IActionResult ObtnerRetroalimentacion()
        {
            RetroalimentacionRequest obtenerRetroalimentacionRequest = new RetroalimentacionRequest { };
            List<RetroalimentacionDTO> retroalimentacion = _iRetroalimentacionAppService.ObtenerRetroalimentacion(obtenerRetroalimentacionRequest);
            return Ok(retroalimentacion);
        }

        [HttpPost]
        public IActionResult CrearRetroalimentacion(NuevoRetroalimentacionRequest request)
        {
            var retroalimentacion = _iRetroalimentacionAppService.CrearRetroalimentacion(request);
            if (string.IsNullOrEmpty(retroalimentacion.mensajeException))
            {
                return Ok(retroalimentacion);
            }
            else
            {
                return BadRequest(retroalimentacion);
            }
        }
        [HttpPut]
        public IActionResult ModificarRetroalimentacion(ModificarRetroalimentacionRequest request)
        {
            var retroalimentacion = _iRetroalimentacionAppService.ModificarRetroalimentacion(request);
            if (string.IsNullOrEmpty(retroalimentacion.mensajeException))
            {
                return Ok(retroalimentacion);
            }
            else
            {
                return BadRequest(retroalimentacion);
            }
        }
    }
}

using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Servicios.ConductoresService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Controllers
{
    [Route("conductor")]
    [ApiController]
    class ConductorController : ControllerBase
    {
        private readonly IConductoresAppService _IconductorAppService;

        public ConductorController(IConductoresAppService iconductorAppService)
        {
            _IconductorAppService = iconductorAppService;
        }

        [HttpGet]
        public IActionResult ObtenerUsuarios()
        {
            ConductorRequest obtenerConductores = new ConductorRequest { };

            List<ConductorDto> usuarios = _IconductorAppService.ObtenerConductores(obtenerConductores);
            return Ok(usuarios);
        }



        [HttpPost]
        public IActionResult CrearConductor(NuevoConductorRequest usuarioRequest)
        {
            var usuario = _IconductorAppService.NuevoConductores(usuarioRequest);
            if (string.IsNullOrEmpty(usuarioRequest.errorMessage))
            {
                return Ok(usuario);
            }
            else
            {
                return BadRequest(usuario);
            }
        }

        [HttpPut]
        public IActionResult ModificarConductores(ModificarConductorRequest modificarUsuario)
        {
            var usuario = _IconductorAppService.ModificarConductores(modificarUsuario);
            if (String.IsNullOrEmpty(usuario.MensajeDeError))
            {
                return Ok(usuario);
            }
            else
            {
                return BadRequest(usuario);
            }
        }
    }
}

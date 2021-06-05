using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Servicios.UsuariosServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Controllers
{
    [ApiController]
    [Route("[/usuario]")]
    class UsuarioController : ControllerBase
    {
        private readonly IUsuariosAppService _IusuariosAppService;

        public UsuarioController(IUsuariosAppService iUsuariosAppService)
        {
            _IusuariosAppService = iUsuariosAppService;
        }

        [HttpGet]
        public IActionResult ObtenerUsuarios()
        {
            UsuariosRequest obtenerUsuarios = new UsuariosRequest { };

            List<UsuariosDto> usuarios = _IusuariosAppService.ObtenerUsuarios(obtenerUsuarios);
            return Ok(usuarios);
        }

        [HttpPost]
        public IActionResult CrearUsuario(NuevoUsuarioRequest usuarioRequest)
        {
            var usuario = _IusuariosAppService.NuevoUsuario(usuarioRequest);
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
        public IActionResult ModificarUsuario(ModificarUsuarioRequest modificarUsuario)
        {
            var usuario = _IusuariosAppService.ModificarUsuario(modificarUsuario);
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

using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Repositorios.Conductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.ConductoresService
{
    public class ConductoresAppService : IConductoresAppService
    {
        private readonly IConductorRepositorio _conductorRepositorio;

        public ConductoresAppService(IConductorRepositorio usuariosRepositorio)
        {
            if (usuariosRepositorio == null) throw new ArgumentNullException("usuariosRepositorio");
            _conductorRepositorio = usuariosRepositorio;
        }


        public List<ConductorDto> ObtenerConductores(ConductorRequest usuariosRequest)
        {
            List<ConductorDto> usuariosList = _conductorRepositorio.ObtenerConductores();
            return usuariosList;
        }
        public ConductorDto ObtenerIdConductores(ObtenerConductorIdRequest usuariosIdRequest)
        {
            ConductorDto usuarioID = _conductorRepositorio.ObtenerIdConductor(usuariosIdRequest.IdUsuario);
            return usuarioID;
        }

        public ConductorDto LoginConductores(LoginConductorRequest usuariosRequest)
        {
            ConductorDto usuarioLog = _conductorRepositorio.LoginConductor(usuariosRequest.Correo, usuariosRequest.Contrasenia);
            return usuarioLog;
        }

        public ConductorDto NuevoConductores(NuevoConductorRequest usuariosRequest)
        {
            ConductorDto correoExist = _conductorRepositorio.ObtenerMailConductor(usuariosRequest.Correo);

            if (correoExist != null)
            {
                return new ConductorDto
                {
                    MensajeDeError = "Usuario existe"
                };
            }

            ConductorDto usuariosDTO = new ConductorDto
            {
                IdRol = usuariosRequest.IdRol,
                Nombre = usuariosRequest.Nombre,
                FechaNacimiento = usuariosRequest.FechaNacimiento,
                Correo = usuariosRequest.Correo,
                Contrasenia = usuariosRequest.Contrasenia,
                Telefono = usuariosRequest.Telefono
            };

            ConductorDto response = _conductorRepositorio.GuardarConductor(usuariosDTO);
            return response;
        }

        public ConductorDto ModificarConductores(ModificarConductorRequest request)
        {

            ConductorDto existUser = _conductorRepositorio.ObtenerIdConductor(request.IdUsuario);
            if (existUser == null)
            {
                return new ConductorDto
                {
                    MensajeDeError = "Usuario no existe"
                };
            }

            ConductorDto mailUser = _conductorRepositorio.ObtenerMailConductor(request.Correo);
            if (mailUser == null)
            {
                return new ConductorDto
                {
                    MensajeDeError = "Email no existe"
                };
            }

            ConductorDto userDTO = new ConductorDto
            {
                IdConductor = request.IdUsuario,
                IdRol = request.IdRol,
                Nombre = request.Nombre,
                FechaNacimiento = request.FechaNacimiento,
                Correo = request.Correo,
                Contrasenia = request.Contrasenia,
                Telefono = request.Telefono
            };

            ConductorDto response = _conductorRepositorio.GuardarConductor(userDTO);
            return response;
        }
    }
}

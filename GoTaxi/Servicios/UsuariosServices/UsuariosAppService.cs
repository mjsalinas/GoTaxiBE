using GoTaxi.DTOs.Dto;
using GoTaxi.Repositorios;
using GoTaxi.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoTaxi.Repositorios.Usuarios;

namespace GoTaxi.Servicios.UsuariosServices
{
    public class UsuariosAppService : IUsuariosAppService
    {
        private readonly IUsuarioRepositorio _usuariosRepositorio;

        public UsuariosAppService(IUsuarioRepositorio usuariosRepositorio)
        {
            if (usuariosRepositorio == null) throw new ArgumentNullException("usuariosRepositorio");
            _usuariosRepositorio = usuariosRepositorio;
        }


        public List<UsuariosDto> ObtenerUsuarios(UsuariosRequest usuariosRequest)
        {
            List<UsuariosDto> usuariosList = _usuariosRepositorio.ObtenerUsuarios();
            return usuariosList;
        }
        public UsuariosDto ObtenerIdUsuario(ObtenerUsuarioIdRequest usuariosIdRequest)
        {
            UsuariosDto usuarioID = _usuariosRepositorio.ObtenerIdUsuario(usuariosIdRequest.IdUsuario);
            return usuarioID;
        }

        public UsuariosDto LoginUsuario(LoginUsuarioRequest usuariosRequest)
        {
            UsuariosDto usuarioLog = _usuariosRepositorio.LoginUsuario(usuariosRequest.Correo, usuariosRequest.Contrasenia);
            return usuarioLog;
        }

        public UsuariosDto NuevoUsuario(NuevoUsuarioRequest usuariosRequest)
        {
            UsuariosDto correoExist = _usuariosRepositorio.ObtenerMailUsuario(usuariosRequest.Correo);

            if (correoExist != null)
            {
                return new UsuariosDto
                {
                    MensajeDeError = "Usuario existe"
                };
            }

            UsuariosDto usuariosDTO = new UsuariosDto
            {
                IdRol = usuariosRequest.IdRol,
                Nombre = usuariosRequest.Nombre,
                FechaNacimiento = usuariosRequest.FechaNacimiento,
                Correo = usuariosRequest.Correo,
                Contrasenia = usuariosRequest.Contrasenia,
                Telefono = usuariosRequest.Telefono
            };

            UsuariosDto response = _usuariosRepositorio.GuardarUsuario(usuariosDTO);
            return response;
        }

        public UsuariosDto ModificarUsuario(ModificarUsuarioRequest request)
        {

            UsuariosDto existUser = _usuariosRepositorio.ObtenerIdUsuario(request.IdUsuario);
            if (existUser == null)
            {
                return new UsuariosDto
                {
                    MensajeDeError = "Usuario no existe"
                };
            }

            UsuariosDto mailUser = _usuariosRepositorio.ObtenerMailUsuario(request.Correo);
            if (mailUser == null)
            {
                return new UsuariosDto
                {
                    MensajeDeError = "Email no existe"
                };
            }

            UsuariosDto userDTO = new UsuariosDto
            {
                IdUsuario = request.IdUsuario,
                IdRol = request.IdRol,
                Nombre = request.Nombre,
                FechaNacimiento = request.FechaNacimiento,
                Correo = request.Correo,
                Contrasenia = request.Contrasenia,
                Telefono = request.Telefono
            };

            UsuariosDto response = _usuariosRepositorio.GuardarUsuario(userDTO);
            return response;
        }

    }
}

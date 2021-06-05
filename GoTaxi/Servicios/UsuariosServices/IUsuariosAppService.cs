using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.UsuariosServices
{
    public interface IUsuariosAppService
    {
        public List<UsuariosDto> ObtenerUsuarios(UsuariosRequest ListRequest);
        public UsuariosDto ObtenerIdUsuario(ObtenerUsuarioIdRequest idRequest);
        public UsuariosDto NuevoUsuario(NuevoUsuarioRequest nuevoUsuario);
        public UsuariosDto ModificarUsuario(ModificarUsuarioRequest modificarUsuario);
        public UsuariosDto LoginUsuario(LoginUsuarioRequest loginUsuario);
    }
}

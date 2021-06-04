using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Usuarios
{
    public interface IUsuarioRepositorio
    {
        public List<UsuariosDto> ObtenerUsuarios();
        public UsuariosDto ObtenerIdUsuario(int id);
        public UsuariosDto ObtenerMailUsuario(string email);
        public UsuariosDto GuardarUsuario(UsuariosDto nuevoUsuario);
    }
}

using GoTaxi.API.Dominio.Models;
using GoTaxi.DTOs.Dto;
using GoTaxi.GoTaxi.API.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Usuarios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public List<UsuariosDto> ObtenerUsuarios()
        {
            GoTaxiContext db = new GoTaxiContext();
            List<UsuariosModel> usuarios = db.Usuarios.ToList();
            List<UsuariosDto> usuariosDTOs = new List<UsuariosDto>();

            foreach (UsuariosModel usuario in usuarios)
            {
                usuariosDTOs.Add(new UsuariosDto
                {
                    IdUsuario = usuario.IdUsuario,
                    IdRol = usuario.IdRol,
                    Nombre = usuario.Nombre,
                    FechaNacimiento = usuario.FechaNacimiento,
                    Correo = usuario.Correo,
                    Contrasenia = usuario.Contrasenia,
                    Telefono = usuario.Telefono
                });
            }
            return usuariosDTOs;
        }

        public UsuariosDto ObtenerIdUsuario(int id)
        {
            GoTaxiContext db = new GoTaxiContext();
            UsuariosModel usuarioDTOs = new UsuariosModel();

            usuarioDTOs = db.Usuarios.FirstOrDefault(usuario => usuario.IdUsuario == id);

            if (usuarioDTOs == null)
            {
                return new UsuariosDto
                {
                    MensajeDeError = "Usuario no existente"
                };
            }

            return new UsuariosDto
            {
                IdUsuario = usuarioDTOs.IdUsuario,
                IdRol = usuarioDTOs.IdRol,
                Nombre = usuarioDTOs.Nombre,
                FechaNacimiento = usuarioDTOs.FechaNacimiento,
                Correo = usuarioDTOs.Correo,
                Contrasenia = usuarioDTOs.Contrasenia,
                Telefono = usuarioDTOs.Telefono
            };

        }

        public UsuariosDto ObtenerMailUsuario(string mail)
        {
            GoTaxiContext db = new GoTaxiContext();
            UsuariosModel usuarioDTOs = new UsuariosModel();

            usuarioDTOs = db.Usuarios.FirstOrDefault(usuario => usuario.Correo == mail);

            if (usuarioDTOs == null)
            {
                return new UsuariosDto
                {
                    MensajeDeError = "Usuario no existe"
                };
            }

            return new UsuariosDto
            {
                IdUsuario = usuarioDTOs.IdUsuario,
                IdRol = usuarioDTOs.IdRol,
                Nombre = usuarioDTOs.Nombre,
                FechaNacimiento = usuarioDTOs.FechaNacimiento,
                Correo = usuarioDTOs.Correo,
                Contrasenia = usuarioDTOs.Contrasenia,
                Telefono = usuarioDTOs.Telefono
            };

        }

        public UsuariosDto GuardarUsuario(UsuariosDto nuevoUsuario)
        {
            try
            {
                GoTaxiContext db = new GoTaxiContext();
                UsuariosModel newUser = new UsuariosModel
                {
                    IdRol = nuevoUsuario.IdRol,
                    Rol = nuevoUsuario.Rol,
                    Nombre = nuevoUsuario.Nombre,
                    FechaNacimiento = nuevoUsuario.FechaNacimiento,
                    Correo = nuevoUsuario.Correo,
                    Contrasenia = nuevoUsuario.Contrasenia,
                    Telefono = nuevoUsuario.Telefono
                };
                db.Usuarios.Add(newUser);
                db.SaveChanges();
                nuevoUsuario.IdUsuario = newUser.IdUsuario;
                return nuevoUsuario;
            }
            catch (Exception ex)
            {
                return new UsuariosDto
                {
                    MensajeDeError = ex.Message
                };
            }
        }

        public UsuariosDto LoginUsuario(string email, string password)
        {
            GoTaxiContext db = new GoTaxiContext();
            UsuariosModel userDTO = new UsuariosModel();

            bool verificaCorreo = ObtenerMailUsuario(email).Contrasenia.Equals(password);

            userDTO = db.Usuarios.FirstOrDefault(driver => driver.Correo == email);


            if (verificaCorreo)
            {
                return new UsuariosDto
                {
                    IdRol = userDTO.IdRol,
                    Rol = userDTO.Rol,
                    Nombre = userDTO.Nombre,
                    FechaNacimiento = userDTO.FechaNacimiento,
                    Correo = userDTO.Correo,
                    Contrasenia = userDTO.Contrasenia,
                    Telefono = userDTO.Telefono
                };
            }

            return new UsuariosDto
            {
                MensajeDeError = "Usuario o contraseña no valido"
            };

        }
    }


}

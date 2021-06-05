using GoTaxi.API.Dominio.Models;
using GoTaxi.DTOs.Dto;
using GoTaxi.GoTaxi.API.Dominio.Models;
using GoTaxi.GoTaxi.API.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Conductor
{
    public class ConductorRepositorio : IConductorRepositorio
    {
        public List<ConductorDto> ObtenerConductores()
        {
            GoTaxiContext db = new GoTaxiContext();
            List<ConductoresModel> conductores = db.Conductores.ToList();
            List<ConductorDto> driverDTOs = new List<ConductorDto>();

            foreach (ConductoresModel driver in conductores)
            {
                driverDTOs.Add(new ConductorDto
                {
                    IdConductor = driver.IdConductor,
                    IdRol = driver.IdRol,
                    Nombre = driver.Nombre,
                    FechaNacimiento = driver.FechaNacimiento,
                    Correo = driver.Correo,
                    Contrasenia = driver.Contrasenia,
                    Telefono = driver.Telefono
                });
            }
            return driverDTOs;
        }

        public ConductorDto ObtenerIdConductor(int id)
        {
            GoTaxiContext db = new GoTaxiContext();
            ConductoresModel driverDTOs = new ConductoresModel();

            driverDTOs = db.Conductores.FirstOrDefault(usuario => usuario.IdConductor == id);

            if (driverDTOs == null)
            {
                return new ConductorDto
                {
                    MensajeDeError = "Usuario no existente"
                };
            }

            return new ConductorDto
            {
                IdRol = driverDTOs.IdRol,
                Rol = driverDTOs.Rol,
                Nombre = driverDTOs.Nombre,
                FechaNacimiento = driverDTOs.FechaNacimiento,
                Correo = driverDTOs.Correo,
                Contrasenia = driverDTOs.Contrasenia,
                Telefono = driverDTOs.Telefono
            };

        }

        public ConductorDto ObtenerMailConductor(string mail)
        {
            GoTaxiContext db = new GoTaxiContext();
            ConductoresModel driverDTOs = new ConductoresModel();

            driverDTOs = db.Conductores.FirstOrDefault(usuario => usuario.Correo == mail);

            if (driverDTOs == null)
            {
                return new ConductorDto
                {
                    MensajeDeError = "Usuario no existe"
                };
            }

            return new ConductorDto
            {
                IdRol = driverDTOs.IdRol,
                Rol = driverDTOs.Rol,
                Nombre = driverDTOs.Nombre,
                FechaNacimiento = driverDTOs.FechaNacimiento,
                Correo = driverDTOs.Correo,
                Contrasenia = driverDTOs.Contrasenia,
                Telefono = driverDTOs.Telefono
            };

        }

        public ConductorDto GuardarConductor(ConductorDto nuevoConductor)
        {
            try
            {
                GoTaxiContext db = new GoTaxiContext();
                ConductoresModel newUser = new ConductoresModel
                {
                    IdRol = nuevoConductor.IdRol,
                    Rol = nuevoConductor.Rol,
                    Nombre = nuevoConductor.Nombre,
                    FechaNacimiento = nuevoConductor.FechaNacimiento,
                    Correo = nuevoConductor.Correo,
                    Contrasenia = nuevoConductor.Contrasenia,
                    Telefono = nuevoConductor.Telefono
                };
                db.Conductores.Add(newUser);
                db.SaveChanges();
                nuevoConductor.IdConductor = newUser.IdConductor;
                return nuevoConductor;
            }
            catch (Exception ex)
            {
                return new ConductorDto
                {
                    MensajeDeError = ex.Message
                };
            }
        }

        public ConductorDto LoginConductor(string email, string password)
        {
            GoTaxiContext db = new GoTaxiContext();
            ConductoresModel  driverDTO = new ConductoresModel();

            bool verificaCorreo = ObtenerMailConductor(email).Contrasenia.Equals(password);

            driverDTO = db.Conductores.FirstOrDefault(driver => driver.Correo == email);


            if (verificaCorreo)
            {
                return new ConductorDto
                {
                    IdRol = driverDTO.IdRol,
                    Rol = driverDTO.Rol,
                    Nombre = driverDTO.Nombre,
                    FechaNacimiento = driverDTO.FechaNacimiento,
                    Correo = driverDTO.Correo,
                    Contrasenia = driverDTO.Contrasenia,
                    Telefono = driverDTO.Telefono
                };
            }

            return new ConductorDto
            {
                MensajeDeError = "Usuario o contraseña no valido"
            };

        }
    }
}

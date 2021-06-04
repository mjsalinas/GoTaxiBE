using GoTaxi.API.Dominio.Models;
using GoTaxi.DTOs.Dto;
using GoTaxi.GoTaxi.API.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Vehiculos
{
    public class VehiculoRepositorio : IVehiculoRepositorio
    {
        public List<VehiculosDto> ObtenerRoles()
        {
            throw new NotImplementedException();
        }

        public List<VehiculosDto> ObtenerVehiculos()
        {
            GoTaxiContext db = new GoTaxiContext();
            List<VehiculosModel> vehiculos = db.Vehiculos.ToList();
            List<VehiculosDto> vehiculosDTO = new List<VehiculosDto>();

            foreach (var Vehiculos in vehiculos)
            {
                vehiculosDTO.Add(new VehiculosDto
                {
                    IdVehiculos = Vehiculos.IdVehiculos,
                    Vehiculos = Vehiculos.Vehiculos,
                });
            }
            return vehiculosDTO;
        }

        public VehiculosDto ObtenerVehiculoPorId(int id)
        {
            GoTaxiContext db = new GoTaxiContext();
            VehiculosModel vehiculoDTOs = new VehiculosModel();

            vehiculoDTOs = db.Vehiculos.FirstOrDefault(v => v.IdVehiculos == id);

            if (vehiculoDTOs == null)
            {
                return new VehiculosDto
                {
                    MensajeDeError = "Automovil no existente"
                };
            }

            return new VehiculosDto
            {
                IdVehiculos = vehiculoDTOs.IdVehiculos,
                Vehiculos = vehiculoDTOs.Vehiculos,
                Marca = vehiculoDTOs.Marca,
                Modelo = vehiculoDTOs.Modelo,
                TipoAuto = vehiculoDTOs.TipoAuto,
                Placa = vehiculoDTOs.Placa
            };
        }
    }
}

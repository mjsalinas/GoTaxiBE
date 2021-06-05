using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Repositorios.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.VehiculoService
{
    public class VehiculoAppService : IVehiculoAppService
    {
        private readonly IVehiculoRepositorio _VehiculosRepositorio;

        public VehiculoAppService(IVehiculoRepositorio VehiculosRepositorio)
        {
            if (VehiculosRepositorio == null) throw new ArgumentNullException("VehiculosRepositorio");
            _VehiculosRepositorio = VehiculosRepositorio;
        }
        public List<VehiculosDto> ObtenerRoles(VehiculoRequest request)
        {
            List<VehiculosDto> rolesExistentes = _VehiculosRepositorio.ObtenerRoles();
            return rolesExistentes;
        }

        public List<VehiculosDto> ObtenerVehiculos(VehiculoRequest request)
        {
            throw new NotImplementedException();
        }

        public List<VehiculosDto> ObtenerVehiculos(ObtenerVehiculoRequest obtenerVehiculoRequest)
        {
            throw new NotImplementedException();
        }
    }
}

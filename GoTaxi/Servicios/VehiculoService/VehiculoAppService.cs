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
        public List<VehiculosDto> ObtenerVehiculos(ObtenerVehiculoRequest request)
        {
            List<VehiculosDto> VehiculosExistentes = _VehiculosRepositorio.GuardarVehiculos();
            return VehiculosExistentes;
        }

        public List<VehiculosDto> NuevoVehiculos(NuevoVehiculoRequest request)
        {

            List<VehiculosDto> VehiculosExistentes = _VehiculosRepositorio.GuardarVehiculos();
            return VehiculosExistentes;
        }

        public List<VehiculosDto> GuardarVehiculos(GuardarVehiculoRequest obtenerVehiculoRequest)
        {
            List<VehiculosDto> VehiculosExistentes = _VehiculosRepositorio.GuardarVehiculos();
            return VehiculosExistentes;
        }
    }
}

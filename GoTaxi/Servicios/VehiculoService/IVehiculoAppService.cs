using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.VehiculoService
{
    public interface IVehiculoAppService
    {
        public List<VehiculosDto> ObtenerVehiculos(ObtenerVehiculoRequest request);
        public List<VehiculosDto> NuevoVehiculos(NuevoVehiculoRequest request);
        public List<VehiculosDto> GuardarVehiculos(GuardarVehiculoRequest request);

    }
}

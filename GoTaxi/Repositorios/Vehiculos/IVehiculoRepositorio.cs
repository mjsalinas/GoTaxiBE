using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Vehiculos
{
    public interface IVehiculoRepositorio
    {
        public List<VehiculosDto> ObtenerVehiculos();
        public List<VehiculosDto> NuevoVehiculos();
        public List<VehiculosDto> GuardarVehiculos();

        public VehiculosDto ObtenerVehiculoPorId(int idVehiculo);
    }
}

using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.ViajesServices
{
    public interface IViajesAppService
    {
        public List<ViajesDto> ObtenerViajes(ObtenerViajesRequest request);
        public ViajesDto CrearNuevoViaje(NuevoViajeRequest request);
        public ViajesDto ModificarViaje(ModificarViajeRequest request);
    }
}

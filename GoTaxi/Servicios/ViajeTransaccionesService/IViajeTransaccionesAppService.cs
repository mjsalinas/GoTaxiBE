using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.ViajeService
{
    public interface IViajeTransaccionesAppService
    {
        public List<ViajeTransaccionesDto> ObtenerViajesTransacciones(ObtenerViajeTransaccionIdRequest request);
        public ViajeTransaccionesDto NuevoViajeTransaccion(NuevoViajeTransaccionRequest request);
        public ViajeTransaccionesDto ModificarViajeTransaccio(ModificarViajeTransaccionRequest request);
    }
}

using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.ConductoresService
{
    public interface IConductoresAppService
    {
        public List<ConductorDto> ObtenerConductores(ConductorRequest ListRequest);
        public ConductorDto ObtenerIdConductores(ObtenerConductorIdRequest idRequest);
        public ConductorDto NuevoConductores(NuevoConductorRequest nuevoUsuario);
        public ConductorDto ModificarConductores(ModificarConductorRequest modificarUsuario);
        public ConductorDto LoginConductores(LoginConductorRequest loginUsuario);
    }
}

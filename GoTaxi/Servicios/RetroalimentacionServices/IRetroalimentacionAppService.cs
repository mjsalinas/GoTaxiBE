using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.RetroalimentacionServices
{
    public interface IRetroalimentacionAppService
    {
        public List<RetroalimentacionDTO> ObtenerRetroalimentacion(RetroalimentacionRequest request);
        public RetroalimentacionDTO CrearRetroalimentacion(NuevoRetroalimentacionRequest request);
        public RetroalimentacionDTO ModificarRetroalimentacion(ModificarRetroalimentacionRequest request);
    }
}

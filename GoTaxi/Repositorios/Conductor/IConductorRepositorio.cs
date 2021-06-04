using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Conductor
{
    public interface IConductorRepositorio
    {
        public List<ConductorDto> ObtenerConductores();
        public ConductorDto ObtenerIdConductor(int id);
        public ConductorDto ObtenerMailConductor(string email);
        public ConductorDto GuardarConductor(ConductorDto nuevoConductor);
    }
}

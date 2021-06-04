using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.RetroalimentacionRepositorio
{
    public interface IRetroalimentacionRepositorio
    {
        public List<RetroalimentacionDTO> ObetnerRetroalimentacion();

        public RetroalimentacionDTO ObetnerRetroalimentacionporID(int idretroalimentacion);

        public RetroalimentacionDTO GuardarRetroalimentacion(RetroalimentacionDTO retroalimentacion);

        public RetroalimentacionDTO ModificarRetroalimentacion(RetroalimentacionDTO retroalimentacion);

    }
}

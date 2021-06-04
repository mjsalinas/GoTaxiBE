using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Viajes
{
    public interface IViajesRepositorio
    {
        public List<ViajesDto> ObtenerViajes();

        public ViajesDto ObtenerViajePorId(int idViaje);
        public ViajesDto GuardarViaje(ViajesDto nuevoViaje);

        public ViajesDto ModificarViaje(ViajesDto nuevoViaje);
    }
}

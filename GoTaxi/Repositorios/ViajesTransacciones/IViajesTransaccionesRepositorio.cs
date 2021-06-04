using GoTaxi.API.Dominio.Models;
using GoTaxi.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.ViajesTransacciones
{
    public interface IViajesTransaccionesRepositorio
    {
        public List<ViajeTransaccionesDto> ObtenerViajesTransacciones();
        public ViajeTransaccionesDto GuardarViajeTransacciones(ViajeTransaccionesDto viajeTransacciones);

        public ViajeTransaccionesDto ModificarViajeTransacciones(ViajeTransaccionesDto viajeTransacciones);
        public ViajeTransaccionesDto ObtenerViajePorId(ViajesModel IdViaje);
    }
}

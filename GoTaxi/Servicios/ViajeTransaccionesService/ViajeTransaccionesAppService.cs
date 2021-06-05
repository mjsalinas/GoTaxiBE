using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Repositorios.ViajesTransacciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.ViajeService
{
    public class ViajeTransaccionesAppService : IViajeTransaccionesAppService
    {
        private readonly IViajesTransaccionesRepositorio _viajeTransaccionesRepositorio;


        public ViajeTransaccionesAppService(IViajesTransaccionesRepositorio ViajeTransaccionesRepositorio)
        {
            if (ViajeTransaccionesRepositorio == null) throw new ArgumentNullException("ViajeTransaccionesRepositorio");
            _viajeTransaccionesRepositorio = ViajeTransaccionesRepositorio;
        }

        public List<ViajeTransaccionesDto> ObtenerViajesTransacciones(ObtenerViajeTransaccionIdRequest request)
        {
            List<ViajeTransaccionesDto> ViajesTransaccionesListados = _viajeTransaccionesRepositorio.ObtenerViajesTransacciones();
            return ViajesTransaccionesListados;
        }

        public ViajeTransaccionesDto NuevoViajeTransaccion(NuevoViajeTransaccionRequest request)
        {
            if (request.FechaHora == null)
            {
                request.FechaHora = System.DateTime.Now;
            }

            ViajeTransaccionesDto existeViajeTransaccion = _viajeTransaccionesRepositorio.ObtenerViajePorId(request.Viaje);
            if (existeViajeTransaccion == null)
            {
                return new ViajeTransaccionesDto
                {
                    MensajeDeError = "Viaje no existe"
                };
            }
            ViajeTransaccionesDto viajeTransaccionesDTO = new ViajeTransaccionesDto
            {

                IdViaje = request.IdViaje,
                Viaje = request.Viaje,
                FechaHora = request.FechaHora,
                Estado = request.Estado,

            };
            ViajeTransaccionesDto response = _viajeTransaccionesRepositorio.GuardarViajeTransacciones(viajeTransaccionesDTO);
            return response;
        }




        public ViajeTransaccionesDto ModificarViajeTransaccio(ModificarViajeTransaccionRequest request)
        {
            if (request.FechaHora == null)
            {
                request.FechaHora = System.DateTime.Now;
            }

            ViajeTransaccionesDto existeViajeTransaccion = _viajeTransaccionesRepositorio.ObtenerViajePorId(request.Viaje);
            if (existeViajeTransaccion == null)
            {
                return new ViajeTransaccionesDto
                {
                    MensajeDeError = "Viaje Transaccion no existe"
                };
            }

            ViajeTransaccionesDto viajeTransaccionesDTO = new ViajeTransaccionesDto
            {
                IdViaje = request.IdViaje,
                Viaje = request.Viaje,
                FechaHora = request.FechaHora,
                Estado = request.Estado,
            };
            ViajeTransaccionesDto response = _viajeTransaccionesRepositorio.GuardarViajeTransacciones(viajeTransaccionesDTO);
            return response;
        }
    }
}

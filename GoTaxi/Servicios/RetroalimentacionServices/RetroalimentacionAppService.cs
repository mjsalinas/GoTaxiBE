using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Repositorios.RetroalimentacionRepositorio;
using GoTaxi.Repositorios.Viajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.RetroalimentacionServices
{
    public class RetroalimentacionAppService : IRetroalimentacionAppService
    {
        private readonly IRetroalimentacionRepositorio _retroalimentacionRepositorio;
        private readonly IViajesRepositorio _ViajesRepositorio;

        public RetroalimentacionAppService(IRetroalimentacionRepositorio retroalimentacionRepositorio, IViajesRepositorio viajesRepositorio)
        {
            if (retroalimentacionRepositorio == null) throw new ArgumentNullException("retroalimentacionRepositorio");
            _retroalimentacionRepositorio = retroalimentacionRepositorio;
            if (viajesRepositorio == null) throw new ArgumentNullException("ViajesRetroalimentacion");
            _ViajesRepositorio = viajesRepositorio;
        }

        public List<RetroalimentacionDTO> ObtenerRetroalimentacion(RetroalimentacionRequest request)
        {
            List<RetroalimentacionDTO> retroalimentacionexistente = _retroalimentacionRepositorio.ObetnerRetroalimentacion();
            return retroalimentacionexistente;
        }
        public RetroalimentacionDTO CrearRetroalimentacion(NuevoRetroalimentacionRequest request)
        {
            if (request.FechaHora == null)
            {
                request.FechaHora = System.DateTime.Now;
            }

            RetroalimentacionDTO existeviajeRetroalimentacion = _retroalimentacionRepositorio.ObetnerRetroalimentacionporID(request.IdRetroalimentacion);
            if (existeviajeRetroalimentacion == null)
            {
                return new RetroalimentacionDTO
                {
                    mensajeException = "Retroalimentacion no existe"
                };
            }

            return existeviajeRetroalimentacion;

        }
        public RetroalimentacionDTO ModificarRetroalimentacion(ModificarRetroalimentacionRequest request)
        {
            RetroalimentacionDTO retroalimentacionDTO = new RetroalimentacionDTO
            {
                IdRetroalimentacion = request.IdRetroalimentacion,
                Viaje = request.Viaje,
                Comentarios = request.Comentarios,
                Puntuacion = request.Puntuacion
            };

            if (request.FechaHora == null)
            {
                request.FechaHora = System.DateTime.Now;
            }

            ViajesDto existeViaje = _ViajesRepositorio.ObtenerViajePorId(request.IdViaje);
            if (existeViaje == null)
            {
                return new RetroalimentacionDTO
                {
                    mensajeException = "Viaje no existe"
                };
            }

            RetroalimentacionDTO retroalimentacionmodificada = _retroalimentacionRepositorio.ModificarRetroalimentacion(retroalimentacionDTO);
            if (retroalimentacionmodificada == null)
            {
                return new RetroalimentacionDTO
                {
                    mensajeException = "Error al modificar retroalimentacion"
                };
            }

            return retroalimentacionmodificada;

        }
    }
}

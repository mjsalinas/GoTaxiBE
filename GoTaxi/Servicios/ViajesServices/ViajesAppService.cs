using GoTaxi.DTOs.Dto;
using GoTaxi.DTOs.Request;
using GoTaxi.Repositorios.Usuarios;
using GoTaxi.Repositorios.Vehiculos;
using GoTaxi.Repositorios.Viajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Servicios.ViajesServices
{
    public class ViajesAppService
    {
        private readonly IViajesRepositorio _viajesRepositorio;
        private readonly IUsuarioRepositorio _usuariosRepositorio;
        private readonly IVehiculoRepositorio _vehiculosRepositorio;

        public ViajesAppService(IViajesRepositorio viajesRepositorio, IUsuarioRepositorio usuariosRepositorio)
        {
            if (viajesRepositorio == null) throw new ArgumentNullException("viajesRepositorio");
            if (usuariosRepositorio == null) throw new ArgumentNullException("usuariosRepositorio");
            _usuariosRepositorio = usuariosRepositorio;
        }

        public List<ViajesDto> ObtenerViajes(ObtenerViajesRequest request)
        {
            List<ViajesDto> viajesExistentes = _viajesRepositorio.ObtenerViajes();
            return viajesExistentes;
        }

        public ViajesDto CrearNuevoViaje(NuevoViajeRequest request)
        {
            if (request.HoraRegistro == null)
            {
                request.HoraRegistro = System.DateTime.Now;
            }

            UsuariosDto existeConductor = _usuariosRepositorio.ObtenerIdUsuario(request.IdConductor);
            if (existeConductor == null)
            {
                return new ViajesDto
                {
                    MensajeDeError = "Conductor no existe"
                };
            }

            UsuariosDto existePasajero = _usuariosRepositorio.ObtenerIdUsuario(request.IdPasajero);
            if (existeConductor == null)
            {
                return new ViajesDto
                {
                    MensajeDeError = "Usuario pasajero no existe"
                };
            }

            VehiculosDto existeVehiculo = _vehiculosRepositorio.ObtenerVehiculoPorId(request.IdVehiculo);
            if (existeVehiculo == null)
            {
                return new ViajesDto
                {
                    MensajeDeError = "Vehiculo no existe"
                };
            }

            ViajesDto viajeDTO = new ViajesDto
            {
                IdConductor = request.IdConductor,
                IdVehiculo = request.IdVehiculo,
                PuntoPartida = request.PuntoPartida,
                PuntoDestino = request.PuntoDestino,
                Fecha = request.Fecha,
                HoraRegistro = request.HoraRegistro,
                HoraProgramada = request.HoraProgramada,
                NoPasajerosTotal = request.NoPasajerosTotal,
                Tarifa = request.Tarifa,
            };
            ViajesDto response = _viajesRepositorio.GuardarViaje(viajeDTO);

            return response;
        }

        public ViajesDto ModificarViaje(ModificarViajeRequest request)
        {
            if (request.HoraRegistro == null)
            {
                request.HoraRegistro = System.DateTime.Now;
            }

            ViajesDto existeViaje = _viajesRepositorio.ObtenerViajePorId(request.IdViaje);
            if (existeViaje == null)
            {
                return new ViajesDto
                {
                    MensajeDeError = "Viaje no existe"
                };
            }

            UsuariosDto existeConductor = _usuariosRepositorio.ObtenerIdUsuario(request.IdConductor);
            if (existeConductor == null)
            {
                return new ViajesDto
                {
                    MensajeDeError = "Conductor no existe"
                };
            }

            UsuariosDto existePasajero = _usuariosRepositorio.ObtenerIdUsuario(request.IdPasajero);
            if (existeConductor == null)
            {
                return new ViajesDto
                {
                    MensajeDeError = "Usuario pasajero no existe"
                };
            }

            VehiculosDto existeVehiculo = _vehiculosRepositorio.ObtenerVehiculoPorId(request.IdVehiculo);
            if (existeVehiculo == null)
            {
                return new ViajesDto
                {
                    MensajeDeError = "Vehiculo no existe"
                };
            }

            ViajesDto viajeDTO = new ViajesDto
            {
                IdConductor = request.IdConductor,
                IdVehiculo = request.IdVehiculo,
                PuntoPartida = request.PuntoPartida,
                PuntoDestino = request.PuntoDestino,
                Fecha = request.Fecha,
                HoraRegistro = request.HoraRegistro,
                HoraProgramada = request.HoraProgramada,
                NoPasajerosTotal = request.NoPasajerosTotal,
                Tarifa = request.Tarifa,
            };
            ViajesDto response = _viajesRepositorio.GuardarViaje(viajeDTO);
            return response;
        }
    }
}

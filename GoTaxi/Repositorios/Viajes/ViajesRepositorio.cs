using GoTaxi.API.Dominio.Models;
using GoTaxi.DTOs.Dto;
using GoTaxi.GoTaxi.API.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.Viajes
{
    public class ViajesRepositorio : IViajesRepositorio
    {
        public List<ViajesDto> ObtenerViajes()
        {
            GoTaxiContext db = new GoTaxiContext();
            List<ViajesModel> viajes = db.Viajes.ToList();
            List<ViajesDto> viajesDTO = new List<ViajesDto>();

            foreach (var viajeDTO in viajes)
            {
                viajesDTO.Add(new ViajesDto
                {
                    IdViaje = viajeDTO.IdViaje,
                    IdConductor = viajeDTO.IdConductor,
                    IdVehiculo = viajeDTO.IdVehiculo,
                    PuntoPartida = viajeDTO.PuntoPartida,
                    PuntoDestino = viajeDTO.PuntoDestino,
                    Fecha = viajeDTO.Fecha,
                    HoraRegistro = viajeDTO.HoraRegistro,
                    HoraProgramada = viajeDTO.HoraProgramada,
                    NoPasajerosTotal = viajeDTO.NoPasajerosTotal,
                    Tarifa = viajeDTO.Tarifa,
                    EstadoActual = viajeDTO.EstadoActual,

                });
            }
            return viajesDTO;
        }

        public ViajesDto GuardarViaje(ViajesDto nuevoViaje)
        {
            try
            {
                GoTaxiContext db = new GoTaxiContext();
                ViajesModel viajeNuevo = new ViajesModel
                {
                    IdConductor = nuevoViaje.IdConductor,
                    IdVehiculo = nuevoViaje.IdVehiculo,
                    PuntoPartida = nuevoViaje.PuntoPartida,
                    PuntoDestino = nuevoViaje.PuntoDestino,
                    Fecha = nuevoViaje.Fecha,
                    HoraRegistro = nuevoViaje.HoraRegistro,
                    HoraProgramada = nuevoViaje.HoraProgramada,
                    NoPasajerosTotal = nuevoViaje.NoPasajerosTotal,
                    Tarifa = nuevoViaje.Tarifa,
                    EstadoActual = nuevoViaje.EstadoActual,
                };
                db.Viajes.Add(viajeNuevo);
                db.SaveChanges();
                nuevoViaje.IdViaje = viajeNuevo.IdViaje;
                return nuevoViaje;
            }
            catch (Exception ex)
            {
                return new ViajesDto
                {
                    MensajeDeError = ex.Message
                };
            }
        }

        public ViajesDto ModificarViaje(ViajesDto nuevoViaje)
        {
            try
            {
                GoTaxiContext db = new GoTaxiContext();
                ViajesModel viajeRegistrado = db.Viajes.FirstOrDefault(x => x.IdViaje == nuevoViaje.IdViaje);
                if (viajeRegistrado == null)
                {
                    return new ViajesDto
                    {
                        MensajeDeError = "Viaje no existente"
                    };
                }

                viajeRegistrado.IdConductor = nuevoViaje.IdConductor;
                viajeRegistrado.IdVehiculo = nuevoViaje.IdVehiculo;
                viajeRegistrado.PuntoPartida = nuevoViaje.PuntoPartida;
                viajeRegistrado.PuntoDestino = nuevoViaje.PuntoDestino;
                viajeRegistrado.Fecha = nuevoViaje.Fecha;
                viajeRegistrado.HoraRegistro = nuevoViaje.HoraRegistro;
                viajeRegistrado.HoraProgramada = nuevoViaje.HoraProgramada;
                viajeRegistrado.NoPasajerosTotal = nuevoViaje.NoPasajerosTotal;
                viajeRegistrado.Tarifa = nuevoViaje.Tarifa;
                viajeRegistrado.EstadoActual = nuevoViaje.EstadoActual;

                db.SaveChanges();
                return nuevoViaje;
            }
            catch (Exception ex)
            {
                return new ViajesDto
                {
                    MensajeDeError = ex.Message
                };
            }
        }

        public ViajesDto ObtenerViajePorId(int idViaje)
        {

            GoTaxiContext db = new GoTaxiContext();
            ViajesModel viajePorId = new ViajesModel();

            viajePorId = db.Viajes.FirstOrDefault(viaje => viaje.IdViaje == idViaje);

            if (viajePorId == null)
            {
                return new ViajesDto
                {
                    MensajeDeError = "Viaje no existente"
                };
            }

            return new ViajesDto
            {
                IdViaje = viajePorId.IdViaje,
                IdConductor = viajePorId.IdConductor,
                IdVehiculo = viajePorId.IdVehiculo,
                PuntoPartida = viajePorId.PuntoPartida,
                PuntoDestino = viajePorId.PuntoDestino,
                Fecha = viajePorId.Fecha,
                HoraRegistro = viajePorId.HoraRegistro,
                HoraProgramada = viajePorId.HoraProgramada,
                NoPasajerosTotal = viajePorId.NoPasajerosTotal,
                Tarifa = viajePorId.Tarifa,
                EstadoActual = viajePorId.EstadoActual,
            };
        }
    }
}

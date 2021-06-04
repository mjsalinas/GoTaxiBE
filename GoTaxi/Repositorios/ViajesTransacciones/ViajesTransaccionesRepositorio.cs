using GoTaxi.API.Dominio.Models;
using GoTaxi.DTOs.Dto;
using GoTaxi.GoTaxi.API.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.ViajesTransacciones
{
    public class ViajesTransaccionesRepositorio : IViajesTransaccionesRepositorio
    {
        public List<ViajeTransaccionesDto> ObtenerViajesTransacciones()
        {
            GoTaxiContext db = new GoTaxiContext();
            List<ViajeTransaccionesModel> viajeTransacciones = db.ViajeTransacciones.ToList();
            List<ViajeTransaccionesDto> ViajeTransaccionesDTO = new List<ViajeTransaccionesDto>();

            foreach (var ViajeTransacciones in viajeTransacciones)
            {
                ViajeTransaccionesDTO.Add(new ViajeTransaccionesDto
                {
                    IdViajeTransac = ViajeTransacciones.IdViajeTransacciones,
                    IdViaje = ViajeTransacciones.IdViaje,
                    Viaje = ViajeTransacciones.Viaje,
                    FechaHora = ViajeTransacciones.FechaHora,
                    Estado = ViajeTransacciones.Estado,

                });

            }
            return ViajeTransaccionesDTO;
        }
        public ViajeTransaccionesDto GuardarViajeTransacciones(ViajeTransaccionesDto viajeTransacciones)
        {
            try
            {
                GoTaxiContext db = new GoTaxiContext();
                ViajeTransaccionesModel viajeTransaccionesEntidad = new ViajeTransaccionesModel
                {
                    IdViajeTransacciones = viajeTransacciones.IdViajeTransac,
                    IdViaje = viajeTransacciones.IdViaje,
                    Viaje = viajeTransacciones.Viaje,
                    FechaHora = viajeTransacciones.FechaHora,
                    Estado = viajeTransacciones.Estado,
                };
                db.ViajeTransacciones.Add(viajeTransaccionesEntidad);
                db.SaveChanges();
                viajeTransacciones.IdViajeTransac = viajeTransaccionesEntidad.IdViajeTransacciones;
                return viajeTransacciones;
            }
            catch (Exception ex)
            {
                return new ViajeTransaccionesDto
                {
                    MensajeDeError = ex.Message
                };
            }
        }

        public ViajeTransaccionesDto ModificarViajeTransacciones(ViajeTransaccionesDto viajeTransacciones)
        {
            try
            {
                GoTaxiContext db = new GoTaxiContext();

                ViajeTransaccionesModel viajeTransaccionesEntidad = db.ViajeTransacciones.FirstOrDefault(x => x.IdViajeTransacciones == viajeTransacciones.IdViajeTransac);
                if (viajeTransaccionesEntidad == null)
                {
                    return new ViajeTransaccionesDto
                    {
                        MensajeDeError = "Registro no existe"
                    };
                };

                viajeTransaccionesEntidad.IdViajeTransacciones = viajeTransacciones.IdViajeTransac;
                viajeTransaccionesEntidad.IdViaje = viajeTransacciones.IdViaje;
                viajeTransaccionesEntidad.Viaje = viajeTransacciones.Viaje;
                viajeTransaccionesEntidad.FechaHora = viajeTransacciones.FechaHora;
                viajeTransaccionesEntidad.Estado = viajeTransacciones.Estado;

                db.SaveChanges();
                return viajeTransacciones;
            }
            catch (Exception ex)
            {
                return new ViajeTransaccionesDto
                {
                    MensajeDeError = ex.Message
                };
            }
        }

        public ViajeTransaccionesDto ObtenerViajePorId(ViajesModel IdViaje)
        {
            GoTaxiContext db = new GoTaxiContext();
            ViajeTransaccionesModel viajePorId = new ViajeTransaccionesModel();

            viajePorId = db.ViajeTransacciones.FirstOrDefault(viaje => viaje.IdViaje == IdViaje.IdViaje);

            if (viajePorId == null)
            {
                return new ViajeTransaccionesDto
                {
                    MensajeDeError = "Viaje no existente"
                };
            }

            return new ViajeTransaccionesDto
            {
                IdViajeTransac = viajePorId.IdViajeTransacciones,
                IdViaje = viajePorId.IdViaje,
                Viaje = viajePorId.Viaje,
                FechaHora = viajePorId.FechaHora,
                Estado = viajePorId.Estado,

            };
        }
    }
}

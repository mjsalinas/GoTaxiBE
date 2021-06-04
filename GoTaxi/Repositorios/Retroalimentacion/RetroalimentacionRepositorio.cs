using GoTaxi.API.Dominio.Models;
using GoTaxi.DTOs.Dto;
using GoTaxi.GoTaxi.API.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.Repositorios.RetroalimentacionRepositorio
{
    public class RetroalimentacionRepositorio : IRetroalimentacionRepositorio
    {
        public List<RetroalimentacionDTO> ObetnerRetroalimentacion()
        {
            GoTaxiContext db = new GoTaxiContext();
            List<RetroalimentacionModel> Retroalimentacion = db.Retroalimentacion.ToList();
            List<RetroalimentacionDTO> retroalimentacionDTO = new List<RetroalimentacionDTO>();

            foreach (var retroalimentacion in Retroalimentacion)
            {
                retroalimentacionDTO.Add(new RetroalimentacionDTO
                {
                    IdRetroalimentacion = retroalimentacion.IdRetroalimentacion,
                    Puntuacion = retroalimentacion.Puntuacion,
                    Comentarios = retroalimentacion.Comentarios

                });
            }
            return retroalimentacionDTO;
        }

        public RetroalimentacionDTO ObetnerRetroalimentacionporID(int idretroalimentacion)
        {
            GoTaxiContext db = new GoTaxiContext();
            RetroalimentacionModel retroalimentacionporID = new RetroalimentacionModel();

            retroalimentacionporID = db.Retroalimentacion.FirstOrDefault(retroalimentacion => retroalimentacion.IdRetroalimentacion == idretroalimentacion);

            if (retroalimentacionporID == null)
            {
                return new RetroalimentacionDTO
                {
                    mensajeException = "Viaje no existente"
                };
            }

            return new RetroalimentacionDTO
            {
                IdRetroalimentacion = retroalimentacionporID.IdRetroalimentacion,
                IdViaje = retroalimentacionporID.IdViaje,
                Puntuacion = retroalimentacionporID.Puntuacion,
                Comentarios = retroalimentacionporID.Comentarios
            };
        }

        public RetroalimentacionDTO GuardarRetroalimentacion(RetroalimentacionDTO retroalimentacion)
        {
            try
            {
                GoTaxiContext bt = new GoTaxiContext();
                RetroalimentacionModel Nretroalimentacion = new RetroalimentacionModel
                {
                    IdRetroalimentacion = retroalimentacion.IdRetroalimentacion,
                    Puntuacion = retroalimentacion.Puntuacion,
                    Comentarios = retroalimentacion.Comentarios

                };
                bt.Retroalimentacion.Add(Nretroalimentacion);
                bt.SaveChanges();
                retroalimentacion.IdRetroalimentacion = Nretroalimentacion.IdRetroalimentacion;
                return retroalimentacion;

            }
            catch (Exception ex)
            {
                return new RetroalimentacionDTO
                {
                    mensajeException = ex.Message
                };
            }
        }

        public RetroalimentacionDTO ModificarRetroalimentacion(RetroalimentacionDTO retroalimentacion)
        {
            try
            {
                GoTaxiContext bt = new GoTaxiContext();
                RetroalimentacionModel Nretroalimentacion = bt.Retroalimentacion.FirstOrDefault(x => x.IdRetroalimentacion == retroalimentacion.IdRetroalimentacion);
                if (Nretroalimentacion == null)
                {
                    return new RetroalimentacionDTO
                    {
                        mensajeException = "Registro no existe"
                    };
                };

                Nretroalimentacion.IdRetroalimentacion = retroalimentacion.IdRetroalimentacion;
                Nretroalimentacion.IdViaje = retroalimentacion.Viaje.IdViaje;
                Nretroalimentacion.Puntuacion = retroalimentacion.Puntuacion;
                Nretroalimentacion.Comentarios = retroalimentacion.Comentarios;

                bt.SaveChanges();
                return retroalimentacion;

            }
            catch (Exception ex)
            {
                return new RetroalimentacionDTO
                {
                    mensajeException = ex.Message
                };
            }
        }
    }
}

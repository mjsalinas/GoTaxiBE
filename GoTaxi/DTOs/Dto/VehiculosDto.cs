using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Dto
{
    public class VehiculosDto
    {
        public object idVehiculo;

        public int IdVehiculos { get; set; }
        public string Vehiculos { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Color { get; set; }

        public string Chasis { get; set; }

        public string TipoAuto { get; set; }
        public string MensajeDeError { get; set; }
        public object VehiculoDTO { get; set; }
    }
}

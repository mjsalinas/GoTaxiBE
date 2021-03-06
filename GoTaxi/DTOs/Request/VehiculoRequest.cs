using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Request
{
    public class ObtenerVehiculoRequest
    {
        public int IdVehiculos { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Color { get; set; }

        public string Chasis { get; set; }

        public string TipoAuto { get; set; }
        public string Vehiculos { get; set; }
    }
    public class NuevoVehiculoRequest
    {
        public int IdVehiculos { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Color { get; set; }

        public string Chasis { get; set; }

        public string TipoAuto { get; set; }
        public string Vehiculos { get; set; }
    }
    public class GuardarVehiculoRequest
    {
        public int IdVehiculos { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Color { get; set; }

        public string Chasis { get; set; }

        public string TipoAuto { get; set; }
        public string Vehiculos { get; set; }
    }
}

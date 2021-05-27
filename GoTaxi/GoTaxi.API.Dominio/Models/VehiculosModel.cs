using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GoTaxi.API.Dominio.Models
{
    public class VehiculosModel
    {
        [Key]
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

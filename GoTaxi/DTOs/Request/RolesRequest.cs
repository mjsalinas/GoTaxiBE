using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.DTOs.Request
{
    public class RolesRequest
    {
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public string MensajeDeError { get; set; }
    }
}

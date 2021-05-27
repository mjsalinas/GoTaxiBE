using GoTaxi.API.Dominio.Models;
using GoTaxi.GoTaxi.API.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi.GoTaxi.API.Infraestructura
{
    public class GoTaxiContext : DbContext
    {
        public DbSet<RolesModel> Roles { get; set; }
        public DbSet<UsuariosModel> Usuarios { get; set; }
        public DbSet<ConductoresModel> Conductores { get; set; }
        public DbSet<VehiculosModel> Vehiculos { get; set; }
        public DbSet<ViajesModel> Viajes { get; set; }
        public DbSet<ViajeTransaccionesModel> ViajeTransacciones { get; set; }
        public DbSet<RetroalimentacionModel> Retroalimentacion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;database=GoTaxiDAV", ServerVersion.AutoDetect("server=localhost;port=3306;user=root;database=GoTaxiDAV"));
        }
    }
}

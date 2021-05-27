using GoTaxi.API.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace GoTaxi 
{
    public class GoTaxiContext : DbContext
    {
        //public GoTaxiContext()
        //{

        //}
        //public GoTaxiContext(DbContextOptions<GoTaxiContext> options) 
        //    : base(options)
        //{

        //}
       
        public  DbSet<RolesModel> Roles { get; set; }
        public  DbSet<UsuariosModel> Usuarios { get; set; }
        public  DbSet<VehiculosModel> Vehiculos { get; set; }
        public  DbSet<ViajesModel> Viajes { get; set; }
        public  DbSet<ViajeTransaccionesModel> ViajeTransacciones { get; set; }
        public  DbSet<RetroalimentacionModel> Retroalimentacion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;port=3306;user=root;database=GoTaxiDAV";
            optionsBuilder.UseMySql(connectionString);
        }
    }
}

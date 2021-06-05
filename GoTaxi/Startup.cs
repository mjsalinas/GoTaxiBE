using GoTaxi.GoTaxi.API.Infraestructura;
using GoTaxi.Repositorios.Conductor;
using GoTaxi.Repositorios.RetroalimentacionRepositorio;
using GoTaxi.Repositorios.Roles;
using GoTaxi.Repositorios.Usuarios;
using GoTaxi.Repositorios.Vehiculos;
using GoTaxi.Repositorios.Viajes;
using GoTaxi.Repositorios.ViajesTransacciones;
using GoTaxi.Servicios.ConductoresService;
using GoTaxi.Servicios.RetroalimentacionServices;
using GoTaxi.Servicios.RolesServices;
using GoTaxi.Servicios.UsuariosServices;
using GoTaxi.Servicios.VehiculoService;
using GoTaxi.Servicios.ViajeService;
using GoTaxi.Servicios.ViajesServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTaxi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GoTaxiContext>();
            services.AddControllers();

            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IConductorRepositorio, ConductorRepositorio>();
            services.AddScoped<IViajesRepositorio, ViajesRepositorio>();
            services.AddScoped<IRolesRepositorio, RolesRepositorio>();
            services.AddScoped<IVehiculoRepositorio, VehiculoRepositorio>();
            services.AddScoped<IViajesTransaccionesRepositorio, ViajesTransaccionesRepositorio>();
            services.AddScoped<IRetroalimentacionRepositorio, RetroalimentacionRepositorio>();

            services.AddScoped<IRetroalimentacionAppService, RetroalimentacionAppService>();
            services.AddScoped<IVehiculoAppService, VehiculoAppService>();
            services.AddScoped<IRolesAppService, RolesAppService>();
            services.AddScoped<IViajesAppService, ViajesAppService>();
            services.AddScoped<IViajeTransaccionesAppService, ViajeTransaccionesAppService>();
            services.AddScoped < IUsuariosAppService, UsuariosAppService>();
            services.AddScoped<IConductoresAppService, ConductoresAppService>();

            services.AddCors(caption => caption.AddPolicy("AllowWebApp", builder =>
            builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GoTaxi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GoTaxi v1"));
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowWebApp");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

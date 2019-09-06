using Microsoft.Extensions.DependencyInjection;
using ReservaSalas.Models;
using ReservaSalas.Repository;
using ReservaSalas.Repository.Interface;
using ReservaSalas.Services;
using ReservaSalas.Services.Interfaces;

namespace ReservaSalas.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {

            services.AddScoped<AppDbContext>();
            services.AddScoped<ISalasRepository, SalaRepository>();
            services.AddScoped<ISalaService, SalaService>();

            return services;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Aeronaves.Domain.Repositories;
using Aeronave.Infraestructure.EF;
using Aeronave.Infraestructure.EF.Repository;
using Aeronave.Infraestructure.MemoryRepository;


namespace Aeronave.Infraestructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //TODO: Eliminar despues. Solo para proposito de pruebas
            services.AddSingleton<MemoryDatabase>();

            services.AddScoped<IAeronaveRepository, MemoryAeronaveRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            
            return services;
        }

    }
}

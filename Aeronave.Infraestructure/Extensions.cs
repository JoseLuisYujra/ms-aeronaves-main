using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Aeronaves.Domain.Repositories;
using Aeronave.Infraestructure.EF;
using Aeronaves.Aplication;
using Aeronave.Infraestructure.EF.Repository;
using Aeronave.Infraestructure.MemoryRepository;
using MediatR;
using Aeronave.Infraestructure.EF.Context;

namespace Aeronave.Infraestructure
{
    public static class Extensions
    {        

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)

        {
            //TODO: Eliminar despues. Solo para proposito de pruebas
            /*
            services.AddSingleton<MemoryDatabase>();

            services.AddScoped<IAeronaveRepository, MemoryAeronaveRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            */

            services.AddApplication();
            services.AddMediatR(Assembly.GetExecutingAssembly());

            var connectionString = configuration.GetConnectionString("AeronaveDbConnectionString");

            services.AddDbContext<ReadDbContext>(context => context.UseSqlServer(connectionString));
            services.AddDbContext<WriteDbContext>(context => context.UseSqlServer(connectionString));

            services.AddScoped<IAeronaveRepository, AeronaveRepository>();
            services.AddScoped<IAsignacionAeronaveRepository, AsignacionAeronaveRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

    }
}

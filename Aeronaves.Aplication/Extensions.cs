using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Domain.Factory;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Aeronaves.Aplication.Services;

namespace Aeronaves.Aplication
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<IAeoronaveService, AeronaveService>();
            services.AddTransient<IAeronaveFactory, AeronaveFactory>();

            return services;
        }

    }
}

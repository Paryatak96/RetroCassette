using RetroCassette.Domain.Interface;
using RetroCassette.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetroCassette.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICassetteRepository, CassetteRepository>();
            return services;
        }
    }
}

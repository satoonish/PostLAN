using Microsoft.Extensions.DependencyInjection;
using PostLAN.Core.Address.Interfaces;
using PostLAN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLAN.Infrastructure
{
    public static class InfrastructureService
    {
        public static IServiceCollection AddInfrastructureService(
            this IServiceCollection services)
        {
            services.AddTransient<IAddressRepository, AddressRepository>();

            return services;
        }
    }
}

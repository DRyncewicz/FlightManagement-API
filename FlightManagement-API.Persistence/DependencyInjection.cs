using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using FlightManagement_API.Application.Common.Interfaces.Database;

namespace FlightManagement_API.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IFlightDbContext, FlightDbContext>();
            return services;
        }
    }
}
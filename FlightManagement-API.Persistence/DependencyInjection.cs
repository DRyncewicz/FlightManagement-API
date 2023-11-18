using Microsoft.Extensions.DependencyInjection;
using FlightManagement_API.Application.Common.Interfaces;

namespace FlightManagement_API.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {

            services.AddScoped<IFlightDbContext, FlightDbContext>();
            return services;
        }
    }
}
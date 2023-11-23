using FlightManagement_API.Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Behaviours;
using FluentValidation;
using MediatR.Pipeline;

namespace FlightManagement_API.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddTransient(typeof(IRequestPreProcessor<>), typeof(LoggingBehaviour<>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}


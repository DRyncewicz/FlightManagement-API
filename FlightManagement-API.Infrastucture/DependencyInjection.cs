using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Infrastructure.DocumentsCreator.Tables;
using FlightManagement_API.Infrastructure.DocumentsCreator.Tickets;
using FlightManagement_API.Infrastructure.Services;
using FlightManagement_API.Infrastructure.FileStore;
using Microsoft.Extensions.Configuration;
using FlightManagement_API.Application.Common.Interfaces.Documents;
using FlightManagement_API.Application.Common.Interfaces.Files;
using FlightManagement_API.Application.Common.Interfaces.Times;

namespace FlightManagement_API.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IFileStore, FileStore.FileStore>();
            services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();
            services.AddTransient<IFileWrapper, FileWrapper>();
            services.AddTransient<IAirlineTicketBuilder, AirlineTicketPDFBuilder>();
            services.AddTransient<ITableData, TableData>();
            return services;
        }
    }
}
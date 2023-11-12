
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace FlightManagement_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
            options.AddPolicy(name: "MyAllowSpecificOrigins",
            builder =>
            {
                builder.WithOrigins("https://localhost:44364");
            }));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "FlightManagement-API",
                    Version = "v1",
                    Description = "Will be updated",
                    License = new Microsoft.OpenApi.Models.OpenApiLicense
                    {
                        Name = "Used license",
                        Url = new Uri("https://example.com/license")
                    }
                }
            );
                var filePath = Path.Combine(AppContext.BaseDirectory, "FlightManagement-API.xml");
                c.IncludeXmlComments(filePath);
            });
            builder.Services.AddHealthChecks();
            builder.Services.AddHealthChecksUI(opt =>
            {
                opt.SetEvaluationTimeInSeconds(15);
                opt.MaximumHistoryEntriesPerEndpoint(60);
                opt.SetApiMaxActiveRequests(1);

                opt.AddHealthCheckEndpoint("default api", "/hc");
            }).AddInMemoryStorage();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.MapHealthChecksUI();
            app.UseHealthChecksUI(config => config.UIPath = "/hc-ui");
            app.UseHealthChecks("/hc", new HealthCheckOptions
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
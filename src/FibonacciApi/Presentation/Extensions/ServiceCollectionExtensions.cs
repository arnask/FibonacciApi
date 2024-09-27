using FibonacciApi.BusinessLogic.Services;
using FibonacciApi.Presentation.Controllers;
using Microsoft.OpenApi.Models;

namespace FibonacciApi.Presentation.Extensions;

/// <summary>
/// Service collection extensions.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Confgures services.
    /// </summary>
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.ConfigureSwagger();
        services.AddMemoryCache();
        services.AddSingleton<IFibonacciSequenceService, FibonacciSequenceService>();

        return services;
    }

    private static IServiceCollection ConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Fibonacci API",
                Version = "v1"
            });

            string? xmlFilename = $"{typeof(FibonacciSequenceController).Assembly.GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });

        return services;
    }
}

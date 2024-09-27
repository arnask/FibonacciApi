using Serilog;

namespace FibonacciApi.Presentation.Extensions;

/// <summary>
/// Builder host extensions.
/// </summary>
public static class BuilderHostExtensions
{
    /// <summary>
    /// Configures logging.
    /// </summary>
    public static IHostBuilder ConfigureLogging(this IHostBuilder host)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        host.UseSerilog();
        return host;
    }
}

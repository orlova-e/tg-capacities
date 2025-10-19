using Capacities.Api.Client.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Capacities.Api.Client.Configuration;

public static class CapacitiesApiClientExtensions
{
    public static IServiceCollection AddCapacitiesApiClient(this IServiceCollection services, IConfiguration configuration)
    {
        return services
            .Configure<CapacitiesApiOptions>(configuration.GetSection("CapacitiesApiOptions"))
            .AddTransient<ICapacitiesClient, CapacitiesClient>();
    }
}
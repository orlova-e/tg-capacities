namespace Telegram.Bot.Api.Configuration;

public static class ApiExtensions
{
    public static IServiceCollection AddApiServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}
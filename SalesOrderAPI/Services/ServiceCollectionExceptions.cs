using SalesOrderAPI.Configurations.Interfaces;

namespace SalesOrderAPI.Services;
public static class ServiceCollectionExceptions
{
    public static IServiceCollection AddCorrelationIdManager(this IServiceCollection services)
    {
        services.AddScoped<ICorrelationIdGenerator, CorrelationIdGenerator>();

        return services;
    }
}


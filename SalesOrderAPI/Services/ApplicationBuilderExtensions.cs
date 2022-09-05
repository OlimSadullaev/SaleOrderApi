using SalesOrderAPI.Helpers;
using System.Runtime.CompilerServices;

namespace SalesOrderAPI.Services;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder AddCorrelationIdMiddleware(this IApplicationBuilder applicationBuilder)
        => applicationBuilder.UseMiddleware<CorrelationIdMiddleware>();
}
    

using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace BookHouse.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        Assembly currentAssembly = typeof(DependencyInjection).Assembly;

        return services;

    }
}
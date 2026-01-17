using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace BookHouse.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        Assembly currentAssembly = typeof(DependencyInjection).Assembly;

        return services;

    }
}
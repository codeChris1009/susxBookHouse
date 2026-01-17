using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace BookHouse.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        Assembly currentAssembly = typeof(DependencyInjection).Assembly;

        return services;

    }
}
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

namespace BookHouse.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        Assembly currentAssembly = typeof(DependencyInjection).Assembly;

        services.AddValidatorsFromAssembly(currentAssembly, includeInternalTypes: true);

        return services;
    }
}
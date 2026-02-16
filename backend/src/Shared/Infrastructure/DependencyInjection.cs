using Microsoft.Extensions.DependencyInjection;
using OpenTTRPG.Core.Abstractions;
using OpenTTRPG.Infrastructure.Security.Authorization;

namespace OpenTTRPG.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddScoped<ICurrentUser, CurrentUser>();

        return services;
    }
}
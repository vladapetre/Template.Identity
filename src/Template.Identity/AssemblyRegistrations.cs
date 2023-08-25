using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Template.Domain.Models;
using Template.Persistence.Contexts.Identity;

namespace Template.Identity;

public static class AssemblyRegistrations
{
    public static IServiceCollection AddIdentityServices(this IServiceCollection services)
    {
        services.AddIdentityCore<User>()
             .AddEntityFrameworkStores<IdentityContext>()
             .AddApiEndpoints();

        return services;
    }
}
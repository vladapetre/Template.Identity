using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Template.Persistence.Contexts.Identity;

namespace Template.Persistence
{
    public static class AssemblyRegistrations
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<IdentityContext>((options) =>
            {
                options.UseSqlite("DataSource=identity.db");
            });

            return services;
        }

        //public static IHost UsePersistenceServices(this IHost host)
        //{
        //    using (var scope = host.Services.CreateScope())
        //    {
        //        var database = scope.ServiceProvider.GetRequiredService<TemplateContext>();
        //        database.Database.Migrate();
        //    }

        //    return host;
        //}
    }
}
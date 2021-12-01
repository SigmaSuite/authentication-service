
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthenticationService.Infra.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContextFactory<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("default"),b=>b.MigrationsAssembly("AuthenticationService.Web")));

            return services;
        }
    }

}
using Gb.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Gb.Api.Extensions
{
    public static class ServiceConfigurationExtensions
    {
        public static IServiceCollection AddGbDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GbDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("GuestBookDb")));

            return services;
        }
    }
}

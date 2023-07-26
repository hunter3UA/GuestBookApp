using Gb.Application.Repositories;
using Gb.Infrastructure.DbContexts;
using Gb.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Gb.Api.Extensions
{
    public static class ServiceConfigurationExtensions
    {
        public static IServiceCollection AddGbDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GbDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("GuestBookDb")));
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            
            return services;
        }
    }
}

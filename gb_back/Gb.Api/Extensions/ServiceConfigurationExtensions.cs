using FluentValidation;
using FluentValidation.AspNetCore;
using Gb.Application;
using Gb.Application.Models;
using Gb.Application.Repositories;
using Gb.Infrastructure.DbContexts;
using Gb.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

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

        public static IServiceCollection AddExternalServices(this IServiceCollection services)
        {
            services.AddAutoMapper(ApplicationAssembly.GetAssembly());
            services.AddFluentValidationBehaviour();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(ApplicationAssembly.GetAssembly()));

            return services;
        }

        public static IServiceCollection AddFluentValidationBehaviour(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            services.AddValidatorsFromAssembly(ApplicationAssembly.GetAssembly());

            return services;
        }

        public static IMvcBuilder ConfigureApiBehavior(this IMvcBuilder builder)
        {
            builder.ConfigureApiBehaviorOptions(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    var errors = context.ModelState
                        .Where(ms => ms.Value is not null && !ms.Value.Errors.IsNullOrEmpty())
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value!.Errors.Select(e => e.ErrorMessage)).ToArray();

                    var validationErrors = new List<ErrorModel>();

                    foreach (var error in errors)
                    {
                        foreach (var subError in error.Value)
                        {
                            validationErrors.Add(new ErrorModel { Key = error.Key, Message = subError });
                        }
                    }

                    var jsonSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new DefaultContractResolver
                        {
                            NamingStrategy = new CamelCaseNamingStrategy()
                        }
                    };

                    var result = JsonConvert.SerializeObject(new ErrorResponse(validationErrors));

                    return new BadRequestObjectResult(result);
                };
            });

            return builder;
        }
    }
}
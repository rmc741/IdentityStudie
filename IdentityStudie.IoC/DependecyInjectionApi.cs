using IdentityStudie.Application.Mappings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityStudie.IoC
{
    public static class DependecyInjectionApi
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));

            var handlers = AppDomain.CurrentDomain.Load("IdentityStudie.Application");
            services.AddMediatR(config => config.RegisterServicesFromAssemblies(handlers));

            return services;
        }

    }
}

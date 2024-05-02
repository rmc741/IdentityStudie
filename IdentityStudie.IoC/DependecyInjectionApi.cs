using IdentityStudie.Application.Interfaces;
using IdentityStudie.Application.Mappings;
using IdentityStudie.Application.Services;
using IdentityStudie.Domain.Interfaces;
using IdentityStudie.Infra.Data.Context;
using IdentityStudie.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityStudie.IoC
{
    public static class DependecyInjectionApi
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<ISolicitationRepository, SolicitationRepository>();
            services.AddScoped<ISolicitationService, QuestionSolicitationService>();
            services.AddScoped<IAnswerSolicitationRepository, AnswerSolicitationRepository>();
            services.AddScoped<IAnswerSolicitationService, AnswerSolicitationService>();

            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));

            var handlers = AppDomain.CurrentDomain.Load("IdentityStudie.Application");
            services.AddMediatR(config => config.RegisterServicesFromAssemblies(handlers));

            return services;
        }

    }
}

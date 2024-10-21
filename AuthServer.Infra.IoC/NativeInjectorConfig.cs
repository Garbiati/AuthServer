using AuthServer.Application.Interfaces;
using AuthServer.Application.Mappings;
using AuthServer.Application.Services;

//using AuthServer.Application.Services;
using AuthServer.Domain.Interfaces;
using AuthServer.Infra.Data.Context;
using AuthServer.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthServer.Infra.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IServiceBase<,,,>), typeof(ServiceBase<,,,>));
        }
    }
}
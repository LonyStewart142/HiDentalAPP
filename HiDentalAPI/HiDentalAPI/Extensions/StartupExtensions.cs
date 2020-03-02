using BussinesLayer.UnitOfWork;
using DatabaseLayer.Persistence;
using DataBaseLayer.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace HiDentalAPI.Extensions
{
    public static class StartupExtensions
    {
        public static void ConfigureDbContexts(this IServiceCollection services, IConfiguration configuration)
            => services.AddDbContext<ApplicationDbContext>(options
                => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        public static void ImplementServices(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        public static void AddDocumentation(this IServiceCollection services)
            => services.AddSwaggerGen(x => x.SwaggerDoc("v1", new OpenApiInfo { Title = "Hi Dental Api!", Version = "v1" }));

        public static void AddSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SwaggerSetting>(configuration.GetSection(nameof(SwaggerSetting)));
        }
    }
}

using System;
using DataLayer.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DataLayer.Models;
using BussinesLogic.Contracts;
using BussinesLogic.Services;
using BussinesLogic.UnitOfWork;

namespace HiDentalAPI.Extensions
{
    public static class StartupExtensions
    {
        public static void ConfigureDbContexts(this IServiceCollection services, IConfiguration configuration)
    => services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

      
       

        public static void ImplementServices(this IServiceCollection services)
        {
            services.AddTransient<IPatientService, PatientService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}

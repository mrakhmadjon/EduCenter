using EduCenter.Data.IRepositories;
using EduCenter.Data.Repositories;
using EduCenter.Service.Interfaces;
using EduCenter.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EduCenter.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IStudentService, StudentService>();
        }
    }
}

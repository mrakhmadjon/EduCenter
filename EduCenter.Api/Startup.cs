using EduCenter.Data.Contexts;
using EduCenter.Data.IRepositories;
using EduCenter.Data.Repositories;
using EduCenter.Service.Helpers;
using EduCenter.Service.Interfaces;
using EduCenter.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace EduCenter.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EduCenterDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("EduCenter"));
            });

            services.AddControllers().AddNewtonsoftJson();

            services.AddHttpContextAccessor();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EduCenter.Api", Version = "v1" });
            });

            // custom services
            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EduCenter.Api v1"));
            }

            if (app.ApplicationServices.GetService<IHttpContextAccessor>() != null)
            {
                HttpContextHelper.Accessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

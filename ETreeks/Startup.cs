using ETreeks.Core.Common;
using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using ETreeks.Infra.Common;
using ETreeks.Infra.Repository;
using ETreeks.Infra.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETreeks
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

            //Common
            services.AddScoped<IDbContext, DbContext>();

            //Repository
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IManagepageRepository, ManagepageRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<ITestmonialRepository, TestmonialRepository>();

            //Service
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IManagepageService, ManagepageService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<ITestmonialService, TestmonialService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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

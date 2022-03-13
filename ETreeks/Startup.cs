using ETreeks.Core.Common;
using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using ETreeks.Infra.Common;
using ETreeks.Infra.Repository;
using ETreeks.Infra.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            services.AddAuthentication(opt => {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; // jwt berear middleware allow validating and auth header is usedalso for auth string
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "http://localhost:5000",
                    ValidAudience = "http://localhost:5000",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("([SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]"))
                };
            });


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
            services.AddScoped<IJWTRepoistory, JWTRepository>();

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
            services.AddScoped<IJWTService, JWTService>();

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

            app.UseAuthentication(); //1
            app.UseAuthorization(); //2

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

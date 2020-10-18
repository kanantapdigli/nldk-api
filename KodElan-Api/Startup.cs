using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KodElan_Api.Abstractions;
using KodElan_Api.Contexts;
using KodElan_Api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace KodElan_Api
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
            services.AddControllers();

            var connectionString = @"Server=DESKTOP-OR32EOP\SQLEXPRESS;Database=KodElan;Trusted_Connection=True;";
            services.AddDbContext<KodElanContext>(option => option.UseSqlServer(connectionString));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<KodElanContext>();

            services.AddScoped(typeof(ICategoryRepository),typeof(CategoryRepository));
            services.AddScoped(typeof(ICityRepository), typeof(CityRepository));
            services.AddScoped(typeof(ICompanyRepository), typeof(CompanyRepository));
            services.AddScoped(typeof(ICVRepository), typeof(CVRepository));
            services.AddScoped(typeof(ICVBookmarksRepository), typeof(CVBookmarksRepository));
            services.AddScoped(typeof(IDutyRepository), typeof(DutyRepository));
            services.AddScoped(typeof(IEducationRepository), typeof(EducationRepository));
            services.AddScoped(typeof(IExperienceRepository), typeof(ExperienceRepository));
            services.AddScoped(typeof(IGenderRepository), typeof(GenderRepository));
            services.AddScoped(typeof(IOperatingModeRepository), typeof(OperatingModeRepository));
            services.AddScoped(typeof(IPackageRepository), typeof(PackageRepository));
            services.AddScoped(typeof(IPackageTypeRepository), typeof(PackageTypeRepository));
            services.AddScoped(typeof(ISalaryRepository), typeof(SalaryRepository));
            services.AddScoped(typeof(ITagRepository), typeof(TagRepository));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(IVacancyRepository), typeof(VacancyRepository));
            services.AddScoped(typeof(IVacancyActivityRepository), typeof(VacancyActivityRepository));
            services.AddScoped(typeof(IVacancyBookmarksRepository), typeof(VacancyBookmarksRepository));
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

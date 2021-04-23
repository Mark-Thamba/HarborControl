using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarborControl.Data;
using HarborControl.Domains;
using Microsoft.EntityFrameworkCore;
using HarborControl.BusinessLogic;

namespace HarborControl
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
            services.AddControllersWithViews();
            services.AddDbContext<HarborControlContext>(
                option => option.UseSqlServer(Configuration.GetConnectionString("HarborControl")));

            services.AddScoped<IBoatStatusManager, BoatStatusManager>();
            services.AddScoped<IBoatTypeManager, BoatTypeManager>();
            services.AddScoped<IDockedBoatManager, DockedBoatManager>();
            services.AddScoped<IHarborManager, HarborManager>();
            services.AddScoped<IMesuringUnitManager, MesuringUnitManager>();
            services.AddScoped<IHarborQuesManager, HarborQuesManager>();

            services.AddScoped<IBoatStatusRepository, EFBoatStatusRepository>();
            services.AddScoped<IBoatTypeRepository, EFBoatTypeRepository>();
            services.AddScoped<IDockedBoatRepository, EFDockedBoatRepository>();
            services.AddScoped<IHarborRepository, EFHarborRepository>();
            services.AddScoped<IMesuringUnitRepository, EFMesuringUnitRepository>();
            services.AddScoped<IHarborQuesRepository, EFHarborQuesRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, HarborControlContext harborControlContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            harborControlContext.Database.Migrate();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=HarborControl}/{id?}");
            });
        }
    }
}

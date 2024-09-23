using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomationTravelAgency.Business.Interface;
using AutomationTravelAgency.Data.Data;
using AutomationTravelAgency.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace AutomationTravelAgency
{
    public class Startup
    {
        private readonly IConfiguration _config;
 
        public Startup(IConfiguration config)
        {
            this._config = config;
        }
 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(
                   options => options.UseSqlServer(_config.GetConnectionString("connection"),
                             b => b.MigrationsAssembly("AutomationTravelAgency"))
                    );
            services.AddScoped<IVehicleRepository,VehicleRepository>();
            services.AddScoped<IVehicleService,VehicleService>();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Automation Travel Agency", Version = "v1" });
            });
            // services.AddIdentity<AppUser, IdentityRole>()
            //         .AddEntityFrameworkStores<AppDbContect>().AddDefaultTokenProviders();
            services.AddControllersWithViews(options => options.EnableEndpointRouting=false);
        }
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                 app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
 
            app.UseHttpsRedirection();
            app.UseStaticFiles();
 
            app.UseRouting();
 
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
            });
        
            app.UseMvc();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
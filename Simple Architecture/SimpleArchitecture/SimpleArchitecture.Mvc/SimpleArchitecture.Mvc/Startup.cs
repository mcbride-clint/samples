using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleArchitecture.DataAccess.Repositories;
using SimpleArchitecture.Domain.Interfaces.Repositories;
using SimpleArchitecture.Domain.Services;

namespace SimpleArchitecture.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // ****************************8
            // Begin Custom Setup
            // ****************************8

            // Inject the UserRepositoryInMemory into needed IUserRepository Instances. 
            // This Instance is a Singleton so there will ever only be 1 between HTTP Transactions to Store Users in memory
            services.AddSingleton<IUserRepository, UserRepositoryInMemory>();

            // Inject a User Service Wherever Needed
            services.AddScoped<UserService>();

            // There is a Default ILogger Injected that will log messages to the Output and Debug Visual Studio Windows at Information and above levels
            // Inject a different one to redirect to other destinations

            // ****************************8
            // End Custom Setup
            // ****************************8

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

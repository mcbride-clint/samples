using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleArchitecture.DataAccess.Repositories;
using SimpleArchitecture.Domain.Interfaces.Repositories;
using SimpleArchitecture.Domain.Services;
using System.Net.Http;

namespace SimpleArchitecture.BlazorDevExpress
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
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

            services.AddScoped<HttpClient>();


            // ****************************8
            // End Custom Setup
            // ****************************8

            services.AddRazorPages();
            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}

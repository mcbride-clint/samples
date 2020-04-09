using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SimpleArchitecture.DataAccess.Repositories;
using SimpleArchitecture.Domain.Interfaces.Repositories;
using SimpleArchitecture.Domain.Services;

namespace SimpleArchitecture.Api
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

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Simple Architecture API",
                    Description = "Testing the Simple Architecture backend with a Swagger API",
                    Version = "v1"
                });
            });


            // ****************************8
            // End Custom Setup
            // ****************************8

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // ********************
            // Initialize Swagger
            // ********************

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Simple Architecture V1");
            });

            // ********************
            // ********************

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MdcLog.Data;
using Radzen.Blazor;
using MdcLog.Application.CommentTypes;
using MdcLog.Application.CommentTypes.Models;
using MdcLog.Infrastructure.Repositories;
using System.Data.SqlClient;
using System.Data;
namespace MdcLog
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
            string connString = @"Server=DESKTOP-KH6A94U;Database=mdc;Trusted_Connection = True;";
            services.AddScoped<IDbConnection, SqlConnection>(c =>
            {
                return new SqlConnection(connString);
            });
            
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
           
            
            services.AddScoped<ICommentTypeRepository, CommentTypeRepository>();            
            services.AddScoped<CommentTypeService>();
           
            services.AddScoped<Radzen.NotificationService>();
            services.AddScoped<Radzen.DialogService>();
            services.AddScoped<RadzenMenu>();
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

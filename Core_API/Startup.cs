using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_API.Models;
using Core_API.Services;
using Microsoft.EntityFrameworkCore;
using Core_API.CustomMiddlewares;
using Core_API.CustomFilters;
namespace Core_API
{
    public class Startup
    {
        /// <summary>
        /// Injeted with the IConfiguration Interface
        /// This is used to read configuration settings from appsettings.json file
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// THe method for DI Container, used to register all dependencies using
        /// IServiceColection Interface
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            // Register the CompenyContext class in Dependency Injection COntainer
            // Provide Connection String of Database to Connect
            // CompanyContext is scopped
            // We MUST proide the Connection string to it
            services.AddDbContext<CompanyContext>(options => 
            {
                // Inforam the DbCOntext that it connection to SQL Server
                // and the Connectio string is read from then appsettings.json
                options.UseSqlServer(Configuration.GetConnectionString("AppConnStr"));
            });

            // COnfigure CORS
            services.AddCors(options => {
                options.AddPolicy("corspolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
                });
            });


            // Register the Custom Services
            // INterface Name and the class that impements the interface
            services.AddScoped<IDbService<Department,int>, DepartmentDbService>();

            /// Method that informs the HOST that the Current Application is for API
            services.AddControllers(options => {
                options.Filters.Add(new LogFilterAttribute()); // Applying attribute at Global Scope (For All Controllers and ts actin methods) 
            })
                .AddJsonOptions(options => {
                    // suppress the CamelCasing fo the JSON Response
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                });

            //Generate the API DOcumentation 
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Core_API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// IApplicationBuilder : USed to configure Middlewares in the HTTP Request Pipeline
        /// IWebHostEnvironment : Specify that if the current projet is executed in Development Mode or Production mode
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Core_API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            // COnfiure the CORS Midleware
            app.UseCors("corspolicy");

            app.UseAuthorization();

            // APply the CUstom  Middleware
            app.UseCustomExceptionHandler();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

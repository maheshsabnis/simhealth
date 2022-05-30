using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        /// <summary>
        /// IHostBuilder: The Interface that detect the Actual Host for appication (e.g. IIS, Apache, NGinx, Self-Executable) and configure application for
        /// 1. Session State
        /// 2. Cache
        /// 3. Concurent Requests
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                { 
                    // Load the Startup class and istantiate it
                    // Startup class is used for following
                    // 1. Registering all dependencies in deendency contianer
                    // 2. Manage the Request Processing using Midlewares
                    // This is used to Resolve FOllowing Interfaces
                    // IConfiguration, IServiceCollection
                    // IApplicationBuilder, IHostingEnvironment
                    webBuilder.UseStartup<Startup>();
                });
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace dotnetcore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).
            ConfigureAppConfiguration((context,config)=> {
                var env = context.HostingEnvironment;
                config.AddJsonFile("appsettings.json", true, false).
                AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, false).AddJsonFile("content.json", true, true).AddEnvironmentVariables(); ;
            })
                .UseStartup<Startup>();
    }
}

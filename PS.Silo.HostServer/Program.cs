using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PS.Infrasture.Persistence;
using Serilog;

namespace PS.Silo.HostServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string appjson = "appsettings.json";
            string conjson = "values.json";
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToLower() == "development")
            {
                appjson = $"appsettings.{environmentName}.json";
                conjson = $"values.{environmentName}.json";
            }  

            var configuration = new ConfigurationBuilder()
                    .AddJsonFile(appjson)
                    .AddJsonFile(conjson)
                    .Build();
            Serilog.ILogger logger = Log.Logger = new LoggerConfiguration().
                ReadFrom.Configuration(configuration).
                CreateLogger();             
            try
            {
                Log.Information("상품 2.0 SILO");
                Log.Information("기동전 시스템 점검중");
                Log.Information("Ocatle 시스템 발진!");

                var host = CreateHostBuilder(args).Build();
                //using (var scope = host.Services.CreateScope())
                //{
                //    var services = scope.ServiceProvider;
                //    var context = services.GetRequiredService<ApplicationDbContext>();
                //    context.Database.Migrate();
                //}
                    //CreateHostBuilder(args).Build().Run();
               host.Run();

            }
            catch (Exception ex)
            {
                Log.Fatal(ex.Message);
                throw ex;
            }
            finally
            {
                Log.CloseAndFlush();
            }
             
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
          
    }
}

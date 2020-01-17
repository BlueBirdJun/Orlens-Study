using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Tenten.Clinet.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string appjson = "appsettings.json";
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToLower() == "development")
                appjson = $"appsettings.{environmentName}.json";
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile(appjson)
                    .Build();
            Serilog.ILogger logger = Log.Logger = new LoggerConfiguration().
                ReadFrom.Configuration(configuration).
                CreateLogger();

            try
            {
                Log.Information("OCatle Host 가동");

                Log.Information("OCatle Host 가동중!");

                //var serviceCollection = new ServiceCollection();

                //ServiceProvider = serviceCollection.BuildServiceProvider();

                //StartClientWithRetries().GetAwaiter().GetResult();

                CreateWebHostBuilder(args).Build().Run();


            }   
            catch (Exception ex)
            {
                Log.Fatal(ex, "API HOST 시작에러");
                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>()
               .ConfigureLogging(logging => { logging.SetMinimumLevel(LogLevel.Debug); })
               .UseSerilog()
               .UseMetricsWebTracking()
               .UseMetricsEndpoints()               
               .UseHealthEndpoints();
    }
}

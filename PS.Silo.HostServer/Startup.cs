using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;
using Orleans.Statistics;
using Orleans.Storage;
using PS.Applications;
using PS.Applications.Common.Interfaces;
using PS.Infrasture;
using PS.Silo.HostServer.Services;
using Microsoft.Extensions.Logging;
using PS.Common.OrlensHelper;
using PS.Infrasture.Persistence;
using Microsoft.EntityFrameworkCore;
using Serilog;
using PS.Infrasture.Identity;
using PS.Infrasture.Services;
using OCatle.inf.V1.Streaming;
using Orleans.Runtime.Configuration;
using PS.Database;
using PS.Application.Commands;

namespace PS.Silo.HostServer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        public IGrainStorage Storage { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            
            Environment = environment;
        
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddApplication();
            //services.AddInfrastructure(Configuration, Environment);
            //services.AddScoped<ICurrentUserService, CurrentUserService>();

            //각종서비스 
            services.AddAuthorization(); 
            services.AddHttpContextAccessor();
            services.AddControllersWithViews();
                                               //.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<IApplicationDbContext>())
                                               //.AddNewtonsoftJson();
            services.AddRazorPages();
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            //services.AddSingleton<IOrlensConfigurator, OrlensConfigurator>();
            //services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(GetLogger(), true));

        }
         

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //미들웨어
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();

            //크로스 브라우징 정책
            app.UseCors();
            //라우팅 사용
            app.UseRouting();
            //미들웨어를 지정해 권한 부여
            app.UseAuthorization();
            //라우팅 규칙
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            }); 

            await StartSilo();
        }

        private async Task<ISiloHost> StartSilo()
        {  
            OrlensConfigurator ofi = new OrlensConfigurator(Configuration);
            var dash = ofi.GetDashBoard();
            var lstdb = ofi.RegDatabaseContext();
            //var lstdb = ofi.RegDatabaseContext();
            var builder = new SiloHostBuilder()
              .ConfigureClustering(
                  ofi.GetOrlConfig(),
                  ofi.GetEnvironmentString()
              )              
              .Configure<ClusterOptions>(options =>
              {
                  options.ClusterId = "Siloserver";
                  options.ServiceId = "OcatleService";
              })
                .UseLocalhostClustering()
                //.AddSimpleMessageStreamProvider("bbb")
                .AddMemoryGrainStorage(StreamNames.PubSubStorageName)
                .AddMemoryGrainStorage(Constants.OrleansMemoryProvider)
                .UseInMemoryReminderService()                
                .AddMemoryGrainStorageAsDefault()
                .ConfigureServices(services =>
                {
                    services.AddApplication();
                    services.AddApplicationCommand();

                    services.AddInfrastructure(Configuration, Environment);
                    services.AddScoped<ICurrentUserService, CurrentUserService>();
                    //services..AddFluentVa1lidation(fv => fv.RegisterValidatorsFromAssemblyContaining<IApplicationDbContext>());
                    services.AddEntityFrameworkSqlServer().AddDbContext<db_itemcontext>(options =>
                    {
                        options.UseSqlServer(lstdb.Where(p => p.Dbkind == "db_item").Single().Connectstring);
                    });
                    services.AddEntityFrameworkSqlServer().AddDbContext<db_partnercontext>(options =>
                    {
                        options.UseSqlServer(lstdb.Where(p => p.Dbkind == "db_partner").Single().Connectstring);
                    });
                    services.AddEntityFrameworkSqlServer().AddDbContext<db_mechantcontext>(options =>
                    {
                        options.UseSqlServer(lstdb.Where(p => p.Dbkind == "db_merchant").Single().Connectstring);
                    });
                    services.AddEntityFrameworkSqlServer().AddDbContext<db_usercontext>(options =>
                    {
                        options.UseSqlServer(lstdb.Where(p => p.Dbkind == "db_user").Single().Connectstring);
                    });

                })
                //.ConfigureApplicationParts(parts =>
                //{
                //    parts.AddApplicationPart(typeof(IGrainInterfaceMarker).Assembly).WithReferences();
                //})                 
                //.ConfigureServices(DependencyInjectionHelper.IocContainerRegistration)                 
                .UsePerfCounterEnvironmentStatistics()
                //.UseDashboard
                //(options =>
                //{
                //    options.Username = dash.UserName;
                //    options.Password = dash.Password;
                //    options.Host = dash.Host;
                //    options.Port = dash.Port;
                //    options.HostSelf = true;
                //    options.CounterUpdateIntervalMs = dash.CounterUpdateIntervalMs;
                //})
                .ConfigureLogging(logging => logging.AddConsole().AddSerilog())
                .AddSimpleMessageStreamProvider(StreamNames.PubSubProviderName)
                ;

            var host = builder.Build();
            
            using (var scope = host.Services.CreateScope())
            {
                //var services = scope.ServiceProvider;
                //var context = services.GetRequiredService<ApplicationDbContext>();
                //await context.Database.MigrateAsync();
            }

            await host.StartAsync();
            return host;
        }
    }
}

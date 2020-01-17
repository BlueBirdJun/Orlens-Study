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
using PS.Common.Filters;
using PS.Common.Middleware;
using Tenten.Clinet.Api.Extensions;

namespace Tenten.Clinet.Api
{
    public class Startup
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _env;
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration,
            Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            _env = env;
            Configuration = configuration;

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
            .AddMvc(options => { options.Filters.Add(typeof(GlobalExceptionFilter)); })
                  .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            //services.AddSingleton<IClusterClient>(orleansClient);
            services.AddApiVersioning().AddHttpClient();
            
            services.AddConfigurations(_env, options =>
            {
                options.AddDefault()
                    .AddDataProtection()
                    //.AddDbContext()
                    .AddCors()
                    .AddSwagger()
                    .AddTraceId(); 
            });


            services.AddOrchardCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            
            app.UseMiddleware<TraceIdMiddleware>();
            app.UseCors();
            app.UseSwaagerOptions();            
            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //    endpoints.MapRazorPages();
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}

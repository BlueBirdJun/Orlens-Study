using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using PS.Common.Middleware;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Tenten.Clinet.Api.Extensions
{
    public class AddConfigutrationsOptions
    {
        private readonly IServiceCollection _serviceCollection;
        private readonly IHostingEnvironment _env;
        public AddConfigutrationsOptions(IServiceCollection serviceCollection, IHostingEnvironment env)
        {
            _serviceCollection = serviceCollection;
            _env = env;
        }
        public AddConfigutrationsOptions AddDefault()
        {
            _serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //_serviceCollection.AddSingleton<IRssFeedsDbContextFactory, RssFeedsDbContextFactory>();

            return this;
        }

        public AddConfigutrationsOptions AddDataProtection()
        {
            //_serviceCollection.AddDataProtection()
            //    .PersistKeysToFileSystem(new DirectoryInfo(Path.Combine(_env.ContentRootPath, "../DataProtection-Keys")))
            //   .DisableAutomaticKeyGeneration();
            return this;
        }

        

        public AddConfigutrationsOptions AddSwagger()
        {
            _serviceCollection.AddSwaggerGen(options =>
            {
                options.CustomSchemaIds(o => o.FullName);
                options.SwaggerDoc("", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "Product 2.0 OCatle",
                    Version = "v1",
                    License = new Swashbuckle.AspNetCore.Swagger.License { Name = "10X10", Url = "http://10x10.co.kr" }

                });

                Directory.GetFiles(PlatformServices.Default.Application.ApplicationBasePath, "*.xml")
                    .ToList()
                    .ForEach(filename =>
                    {
                        options.IncludeXmlComments(filename);
                    });
            });


            return this;
        }

        public AddConfigutrationsOptions AddCors()
        {
            //_serviceCollection.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
            //{
            //    builder.AllowAnyOrigin()
            //        .AllowAnyMethod()
            //        .AllowAnyHeader()
            //        .AllowCredentials();
            //}));

            return this;
        }

        public AddConfigutrationsOptions AddTraceId()
        {
            _serviceCollection.AddTraceId();

            return this;
        }

        public AddConfigutrationsOptions AddRegistComponents()
        {
            //_serviceCollection.AddRegistComponents();

            return this;
        }

        public void AddRegistDomainEventHandlers()
        {
            ///_serviceCollection.AddRegistDomainEventHandlers();
        }

    }
}

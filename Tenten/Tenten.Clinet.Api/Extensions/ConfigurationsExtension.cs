using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PS.Common.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tenten.Clinet.Api.Extensions
{
    public static class ConfigurationsExtension
    {

        public static AddConfigutrationsOptions AddConfigurations(
           this IServiceCollection serviceCollection,
           IHostingEnvironment hostingEnvironment,
           Action<AddConfigutrationsOptions> options)
        {
            var configurationsOptions =
                new AddConfigutrationsOptions(serviceCollection, hostingEnvironment);

            options(configurationsOptions);

            return configurationsOptions;
        }


        public static IApplicationBuilder UseSwaagerOptions(
            this IApplicationBuilder app)
        {
            app.UseSwagger()
                .UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "ProductSeoncd Api v1"))
                .UseTraceId()
                .UseCors("CorsPolicy");

            return app;

        }

    }
}

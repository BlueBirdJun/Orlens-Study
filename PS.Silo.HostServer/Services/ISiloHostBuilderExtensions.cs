using Orleans.Configuration;
using Orleans.Hosting;
using PS.Silo.HostServer.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PS.Silo.HostServer.Services
{
    public static class ISiloHostBuilderExtensions
    {
        /// <summary>
        /// Configures clustering for the Orleans Silo Host based on
        /// the Orleans environment.
        /// </summary>
        /// <param name="builder">The silo host builder.</param>
        /// <param name="orleansConfigOptions">The Orleans configuration options.</param>
        /// <param name="environmentName">The environment.</param>
        public static ISiloHostBuilder ConfigureClustering(
            this ISiloHostBuilder builder,
            OrleansConfig orleansConfigOptions,
            string environmentName
        )
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            switch (environmentName.ToLower())
            {
                case "development":
                    builder.UseLocalhostClustering();
                    builder.Configure<EndpointOptions>(options => options.AdvertisedIPAddress = IPAddress.Loopback);
                    break;
                default:
                    var orleansConfig = orleansConfigOptions;
                    // Configure the first listed node as the "primary node".
                    // Note this type of configuration should probably not be used in prod - using HA clustering instead.
                    builder.UseDevelopmentClustering(
                        new IPEndPoint(
                            IPAddress.Parse(orleansConfig.NodeIpAddresses[0]),
                            orleansConfig.SiloPort
                        )
                    );
                    builder.ConfigureEndpoints(
                        siloPort: orleansConfig.SiloPort,
                        gatewayPort: orleansConfig.GatewayPort
                    );
                    break;
            }

            return builder;
        }
    }
}

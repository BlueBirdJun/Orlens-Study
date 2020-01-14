using Microsoft.Extensions.Configuration;
using Orleans.Configuration;
using Orleans.Hosting;
using PS.Silo.HostServer.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace PS.Silo.HostServer
{
    public class OrlensConfigurator //: IOrlensConfigurator
    {
        private readonly IConfiguration _config;

        public OrlensConfigurator(IConfiguration config)
        {
            _config = config;
        }
        public   DashBoardConfig GetDashBoard()
        {
            DashBoardConfig dc = new DashBoardConfig();
            dc.UserName = _config.GetValue<string>("DashBoard:UserName");
            dc.Password = _config.GetValue<string>("DashBoard:Password");
            dc.Host = _config.GetValue<string>("DashBoard:Host");
            dc.Port = _config.GetValue<int>("DashBoard:Port");
            dc.CounterUpdateIntervalMs = _config.GetValue<int>("DashBoard:CounterUpdateIntervalMs");
            return dc;
        }

        public   OrleansConfig GetOrlConfig()
        {
            OrleansConfig dc = new OrleansConfig();
            dc.NodeIpAddresses = new List<string>();
            string nid = _config.GetValue<string>("OrleansConfig:NodeIpAddresses");
            string[] nidip = nid.Split(',');
            dc.NodeIpAddresses = nidip.ToList<string>();
            dc.GatewayPort = _config.GetValue<int>("OrleansConfig:GatewayPort");
            dc.SiloPort = _config.GetValue<int>("OrleansConfig:SiloPort");
            return dc;
        }

        public   string GetEnvironmentString()
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (string.IsNullOrEmpty(environmentName))
            {
                return "dev";
            }
            return environmentName;
        }

        
    }
}

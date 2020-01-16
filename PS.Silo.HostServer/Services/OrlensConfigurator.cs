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

        public  IConfigurationRoot GetConfigurationRoot()
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string appjson = "appsettings.json";
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToLower() == "development")
                appjson = $"appsettings.{environmentName}.json";

            string conjson = "values.json";
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToLower() == "development")
                conjson = $"values.{environmentName}.json";

            var cfb = new ConfigurationBuilder()
                   .AddJsonFile(appjson)
                   .AddJsonFile(conjson)
                   .Build();

            return cfb;
        }


        public List<DbInfo> RegDatabaseContext()
        {
            var configuration = GetConfigurationRoot();

            string skey = configuration.GetValue<string>("SECRETKEY"); 
            Common.Crypto.ICryptoProvider icp = new Common.Crypto.RijndaelCryptoProvider(skey);

            List<DbInfo> lstdb = new List<DbInfo>();
            lstdb.Add(new DbInfo() { Dbkind = "db_log" });
            lstdb.Add(new DbInfo() { Dbkind = "db_partner" });
            lstdb.Add(new DbInfo() { Dbkind = "db_user" });
            lstdb.Add(new DbInfo() { Dbkind = "db_etc" });
            lstdb.Add(new DbInfo() { Dbkind = "db_item" });
            lstdb.Add(new DbInfo() { Dbkind = "db_temp" });
            lstdb.Add(new DbInfo() { Dbkind = "db_merchant" });
            foreach (var ld in lstdb)
            {
                if (configuration.GetValue<string>(ld.Dbkind) != null)
                {
                    ld.Connectstring = icp.Decrypt(configuration.GetValue<string>(ld.Dbkind));
                }
            } 


            return lstdb;
        }



    }

    public class DbInfo
    {
        public string Dbkind { get; set; }
        public string Connectstring { get; set; }

    }
}

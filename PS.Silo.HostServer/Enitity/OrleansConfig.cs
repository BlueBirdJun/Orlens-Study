using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.Silo.HostServer.Enitity
{
    public class OrleansConfig
    {
        /// <summary>
        /// The IP addresses that will be utilized in the cluster.
        /// First IP address is the primary.
        /// </summary>
        //public string[] NodeIpAddresses { get; set; }
        public List<string> NodeIpAddresses { get; set; }
        /// <summary>
        /// The port used for Client to Server communication.
        /// </summary>
        public int GatewayPort { get; set; }
        /// <summary>
        /// The port for Silo to Silo communication
        /// </summary>
        public int SiloPort { get; set; }
    }
}

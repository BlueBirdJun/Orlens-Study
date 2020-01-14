using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.Silo.HostServer.Enitity
{
    public class DashBoardConfig
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public int CounterUpdateIntervalMs { get; set; }
    }
}

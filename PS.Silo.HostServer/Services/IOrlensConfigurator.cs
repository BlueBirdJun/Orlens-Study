using PS.Silo.HostServer.Enitity;
using System.Threading.Tasks;

namespace PS.Silo.HostServer
{
    public interface IOrlensConfigurator
    {
        //DashBoardConfig GetDashBoard();
        // OrleansConfig GetOrlConfig();
        Task<bool> StartSilo();
    }

    
}
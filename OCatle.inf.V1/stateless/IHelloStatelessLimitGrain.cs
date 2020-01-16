using System.Threading.Tasks;
using Orleans;

namespace OCatle.inf.V1.stateless
{
    public interface IHelloStatelessLimitGrain : IGrainWithIntegerKey
    {
        Task<string> SayAsync(string message);
    }
}

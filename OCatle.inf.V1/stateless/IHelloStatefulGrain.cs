using System.Threading.Tasks;
using Orleans;

namespace OCatle.inf.V1.stateless
{
    public interface IHelloStatefulGrain : IGrainWithIntegerKey
    {
        Task<string> SayAsync(string message);
    }
}

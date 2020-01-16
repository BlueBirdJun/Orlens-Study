using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OCatle.inf.V1.EentSourcing
{
    public interface IHelloGrain : IGrainWithIntegerKey
    {
        Task SayAsync(string message);
    }
}

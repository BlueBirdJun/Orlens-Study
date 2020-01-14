using Orleans;
using PS.Common.OrlensHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OCatle.inf.V1.EentSourcing
{
    public interface IEventSourcingGrain : IGrainWithIntegerKey, IGrainInterfaceMarker
    {
        Task Deposit(decimal amount);
        Task Withdraw(decimal amount);
        Task<decimal> Balance();


        Task<string> GetTest(string message);
    }
}

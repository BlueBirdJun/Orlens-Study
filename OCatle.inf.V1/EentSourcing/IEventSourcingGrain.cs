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
        Task Deposit(string name, decimal amount);
        Task Withdraw(string name, decimal amount);
        Task<decimal> Balance();


        Task<string> GetTest(string message);
    }
}

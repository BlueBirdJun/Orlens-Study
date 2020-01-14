using Orleans;
using PS.Common.OrlensHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OCatle.inf.V1.Streaming
{
    public interface IStreammingGrain : IGrainWithIntegerKey, IGrainInterfaceMarker
    {
        Task<Guid> JoinAsync();
        Task SayStreamAsync(string message);
    }
    
}

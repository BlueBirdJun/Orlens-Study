using Orleans;
using PS.Common.OrlensHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OCatle.inf.V1.Versions
{
    public interface IVersionProvider : IGrainWithIntegerKey, IGrainInterfaceMarker
    {
        Task Gett1();
        Task UpdateVersion(string source);
    }
}

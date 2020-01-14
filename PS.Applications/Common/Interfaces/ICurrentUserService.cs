using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Applications.Common.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
    }
}

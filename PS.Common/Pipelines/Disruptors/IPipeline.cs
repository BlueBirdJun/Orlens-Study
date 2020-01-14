using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PS.Common.Pipelines.Disruptors
{
    public interface IPipeline<TIn, TOut> : IDisposable
    {
        // TODO: use ValueTask + IValueTaskSource to avoid allocations
        Task<TOut> Execute(TIn data);
    }
}

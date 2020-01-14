using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PS.Common.Pipelines.BlockingCollection
{
    public interface IPipeline
    {
        void Execute(object input);
        event Action<object> Finished;
    }
    public interface IAwaitablePipeline<TOutput>
    {
        Task<TOutput> Execute(object input);
    }
}

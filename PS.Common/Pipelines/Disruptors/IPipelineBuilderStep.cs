using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common.Pipelines.Disruptors
{
    public interface IPipelineBuilderStep<TIn, TOut>
    {
        IPipelineBuilderStep<TIn, TNewStepOut> AddStep<TNewStepOut>(Func<TOut, TNewStepOut> stepFunc, int workerCount);
        IPipeline<TIn, TOut> Create();
    }
}

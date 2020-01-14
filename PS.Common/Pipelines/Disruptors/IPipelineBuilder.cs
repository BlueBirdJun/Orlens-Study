using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common.Pipelines.Disruptors
{
    public interface IPipelineBuilder
    {
        IPipelineBuilderStep<TStepIn, TStepOut> Build<TStepIn, TStepOut>(Func<TStepIn, TStepOut> stepFunc, int workerCount);
    }
}

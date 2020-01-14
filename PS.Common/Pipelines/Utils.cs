using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PS.Common.Pipelines
{
    public class Utils
    {
        public static int GetThreadPoolThreadsInUse()
        {
            int max, max2;
            ThreadPool.GetMaxThreads(out max, out max2);
            int available, available2;
            ThreadPool.GetAvailableThreads(out available, out available2);
            int running = max - available;
            return running;
        }
    }
}

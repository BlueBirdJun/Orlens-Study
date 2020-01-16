using OCatle.inf.V1.stateless;
using Orleans.Concurrency;
using PS.Common.OrlensHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OCatle.Grains.Common.Stateless
{
    public class HelloStatefulGrain : GrainBase, IHelloStatefulGrain
    {
        private int _count = 0;
        public Task<string> SayAsync(string message)
        {
            _count++;
            Console.WriteLine($"{this.GetType().Name} Count: {_count}");
            return Task.FromResult($"Hello {message} {_count}");
        }
    }

  


    [StatelessWorker]
    public class HelloStatelessGrain : GrainBase, IHelloStatelessGrain
    {
        private int _count;

        public Task<string> SayAsync(string message)
        {
            _count++;
            Console.WriteLine($"{this.GetType().Name} Count: {_count}");
            return Task.FromResult($"Hello {message} {_count}");
        }
    }

    [StatelessWorker(2)]
    public class HelloStatelessLimitGrain : GrainBase, IHelloStatelessLimitGrain
    {
        private int _count;

        public Task<string> SayAsync(string message)
        {
            _count++;
            Console.WriteLine($"{this.GetType().Name} Count: {_count}");
            return Task.FromResult($"Hello {message} {_count}");
        }
    }

}

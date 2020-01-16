
using OCatle.inf.V1.stateless;
using Orleans;
using System;
using System.Threading.Tasks;

namespace clienttest
{
    class Program5
    {
        static async Task cfdf()
        {
            try
            {
                Console.WriteLine("상태없음");
                Console.ReadLine();
                var client = new ClientBuilder()
                        .ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory())
                        .UseLocalhostClustering()
                        .Build();

                await client.Connect();

                Console.WriteLine(await client.GetGrain<IHelloStatefulGrain>(0).SayAsync("Stateful powerumc"));
                Console.WriteLine(await client.GetGrain<IHelloStatelessGrain>(0).SayAsync("Stateless powerumc"));
                Console.WriteLine(await client.GetGrain<IHelloStatelessLimitGrain>(0).SayAsync("StatelessLimit powerumc"));
                Console.ReadLine();
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);

                Console.ReadLine();
            }

        }
    }
}

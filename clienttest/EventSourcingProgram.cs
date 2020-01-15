
using OCatle.inf.V1.EentSourcing;
using OCatle.inf.V1.Streaming;
using OCatle.inf.V1.Versions;
using Orleans;
using Orleans.Hosting;
using Orleans.Streams;
using System;
using System.Threading.Tasks;

namespace clienttest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("시작");
                var cc1 = Console.ReadLine();

                var client = new ClientBuilder()
                    .ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory())
                    .UseLocalhostClustering()
                    .AddSimpleMessageStreamProvider("bbb")
                    .Build();

                await client.Connect();
                var grain = client.GetGrain<IEventSourcingGrain>(1);// Guid.NewGuid());
                while (true)
                {
                    Console.WriteLine("입력");
                    var cc= Console.ReadLine();
                    if (cc == "EXIT")
                        return;

                    var rt= await grain.Balance();

                    Console.WriteLine(rt);
                }

            }

            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

        }
    }
}

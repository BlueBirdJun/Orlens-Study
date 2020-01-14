
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
                ///sfawait Task.Delay(5000);
                Console.WriteLine("시작");
                var client = new ClientBuilder()
                       .ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory())
                       .UseLocalhostClustering()
                       .AddSimpleMessageStreamProvider(StreamNames.PubSubProviderName)
                       .Build();

                await client.Connect();
                var grain = client.GetGrain<IStreammingGrain>(1);// Guid.NewGuid());
                var streamId = await grain.JoinAsync();
                var streamProvider = client.GetStreamProvider(StreamNames.PubSubProviderName);
                var stream = streamProvider.GetStream<string>(streamId, StreamNames.HelloGrainNamespace);

                await stream.SubscribeAsync(new HelloGrainStreamObserver());

                while (true)
                {
                    var message = Console.ReadLine();
                    for (int i=0;i<100;i++)
                    {
                        await grain.SayStreamAsync("1번"+i.ToString());
                    }
                    //var message = Console.ReadLine();
                    Console.WriteLine("완료");
                }
            }
            catch(Exception exc)
            {

            }

        }

        internal class HelloGrainStreamObserver : IAsyncObserver<string>
        {

            public Task OnNextAsync(string item, StreamSequenceToken token = null)
            {
                Console.WriteLine("다음");
                return Task.CompletedTask;
            }

            public Task OnCompletedAsync()
            {
                Console.WriteLine("OnCompleted");
                return Task.CompletedTask;
            }

            public Task OnErrorAsync(Exception ex)
            {
                Console.Error.WriteLine("OnError");
                return Task.CompletedTask;
            }
        }

    }
}

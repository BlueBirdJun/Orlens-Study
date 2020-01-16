
using OCatle.inf.V1.EentSourcing;
using OCatle.inf.V1.Streaming;
using OCatle.inf.V1.Versions;
using Orleans;
using Orleans.Hosting;
using Orleans.Streams;
using System;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace clienttest
{
    class Program3
    {
        static async Task Mfffain(string[] args)
        {
            try
            {
                Console.WriteLine("시작");

                var cc = Console.ReadLine();
                var client = new ClientBuilder()
               .ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory().WithCodeGeneration())
               .UseLocalhostClustering()
               .Build();

                await client.Connect();
                AssemblyLoadContext.Default.Unloading += async context => await client.Close();
                var grain1 = client.GetGrain<IEventSourcingGrain>(0);

                string name = string.Empty;
                Console.WriteLine("이름이 뭐예요");
                name = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("뭘하시겠습니까?");
                    var ba = Console.ReadLine();
                    if (ba == "plus")
                    {
                        Console.WriteLine("얼마나");
                        var ba1 = Console.ReadLine();

                        for (int i = 0; i < int.Parse(ba1); i++)
                        {
                            Random rd = new Random();
                            await Task.Delay(1000);
                            //await grain1.Deposit(Decimal.Parse(rd.Next(1, 1000).ToString()));
                            await grain1.Deposit(name, 1);
                        }
                        Console.WriteLine("입금완료");
                    }
                    else if (ba == "minus")
                    {
                        Console.WriteLine("출금");
                        var mi = Console.ReadLine();
                        await grain1.Withdraw(name, Decimal.Parse(mi));
                        Console.WriteLine("출금완료");
                    }

                    var dei = await grain1.Balance();
                    Console.WriteLine(dei);
                    Console.WriteLine("작업완료");
                }




                //await client.Connect();
                //var grain = client.GetGrain<IVersionProvider>(1);// Guid.NewGuid());
                //await grain.Gett1();

                // var client = new ClientBuilder()
                //.ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory().WithCodeGeneration())
                //.UseLocalhostClustering()
                //.Build();
                // await client.Connect();
                // AssemblyLoadContext.Default.Unloading += async context => await client.Close();

                // var grain = client.GetGrain<IHelloGrain>(0);
                // var cc1 = Console.ReadLine();
                // await grain.SayAsync("ccc");


                // var client = new ClientBuilder()
                //.ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory().WithCodeGeneration())
                //.UseLocalhostClustering()
                //.Build();
                /*
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
                */
            }

            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

        }
    }
}

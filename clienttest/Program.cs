
using OCatle.inf.V1.Versions;
using Orleans;
using System;
using System.Threading.Tasks;

namespace clienttest
{
    class Program1
    {
        public  async Task ccc()
        {
            //await Task.Delay(5000);
            Console.WriteLine("시작");


            return;

            while(true)
            {
                try
                {
                    Console.WriteLine("입력");
                    var cc = Console.ReadLine();
                    if (cc == "EXIT")
                        return;
                    var client = new ClientBuilder()
                    .ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory())
                    .UseLocalhostClustering()
                    .Build();

                    await client.Connect();
                    var grain = client.GetGrain<IVersionProvider>(1);// Guid.NewGuid());
                    for (int i = 0; i < 100; i++)
                    {
                        await grain.UpdateVersion(cc+i.ToString());
                    }
                }
                catch(Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            
            //var client = new ClientBuilder()
            //        .ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory())
            //        .UseLocalhostClustering()
            //        .Build();
            

            //await client.Connect();

            //Console.WriteLine("접속");
            //var grain = client.GetGrain<IVersionProvider>(Guid.NewGuid());

            //await grain.UpdateVersion("와라");
            //Console.WriteLine(ff);


            Console.WriteLine("Hello World!");
        }
    }
}

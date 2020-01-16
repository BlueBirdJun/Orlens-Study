using EventStore.ClientAPI;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var conn = EventStoreConnection.Create(new Uri("tcp://admin:changeit@localhost:1113"),"InputFromFileConsoleApp");



        }
    }
}

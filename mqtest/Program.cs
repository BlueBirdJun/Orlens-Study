using System;
using ZeroMQ;

namespace mqtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var publisher = new ZSocket(ZSocketType.PUB))
            {
                string address = "tcp://*:5556";
                Console.WriteLine("I: Publisher.Bind'ing on {0}", address);
                publisher.Bind(address);

                // Initialize random number generator
                var rnd = new Random();

                while (true)
                {
                    // Get values that will fool the boss
                    int zipcode = rnd.Next(99999);
                    int temperature = rnd.Next(-55, +45);

                    // Send message to all subscribers
                    var update = string.Format("{0:D5} {1}", zipcode, temperature);
                    using (var updateFrame = new ZFrame(update))
                    {
                        publisher.Send(updateFrame);
                    }
                }
            }
        }
    }
}

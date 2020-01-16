using EventStore.ClientAPI;
using EventStore.ClientAPI.SystemData;
using System;
using System.Net;
using System.Text;

namespace eventstoretest
{
    class Program
    {
        const string STREAM = "a_test_stream";

        const string GROUP = "a_test_group";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConnectionSettings settings = ConnectionSettings.Create();
            UserCredentials credentials = new UserCredentials("admin", "changeit");

            var _conn = EventStoreConnection.Create(settings, credentials, "");

            

        }


        private static void CreateSubscription(IEventStoreConnection conn)
        {
            PersistentSubscriptionSettings settings = PersistentSubscriptionSettings.Create()
                .DoNotResolveLinkTos()
                .StartFromCurrent();

            try
            {
                conn.CreatePersistentSubscriptionAsync(STREAM, GROUP, settings, new UserCredentials("admin", "changeit")).Wait();
            }
            catch (AggregateException ex)
            {
                if (ex.InnerException.GetType() != typeof(InvalidOperationException)
                    && ex.InnerException?.Message != $"Subscription group {GROUP} on stream {STREAM} already exists")
                {
                    throw;
                }
            }
        }

        private static EventData GetEventDataFor(int i)
        {
            return new EventData(
                Guid.NewGuid(),
                "event",
                true,
                Encoding.ASCII.GetBytes("{\"somedata\" : " + i + "}"),
                Encoding.ASCII.GetBytes("{\"metadata\" : " + i + "}")
                );
        }
    }
}

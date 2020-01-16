using OCatle.inf.V1.EentSourcing;
using Orleans.EventSourcing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCatle.Grains.Common.EventSourcing
{
    public class HelloGrain : JournaledGrain<HelloGrainState>, IHelloGrain
    {
        public Task SayAsync(string message)
        {
            Console.WriteLine($"{nameof(HelloGrain)}: {message}");
            Console.WriteLine($"{nameof(HelloGrain)} UnconfirmedEvents.Count: {UnconfirmedEvents.Count()}");

            var newMessage = $"Hello {message}";

            RaiseEvent(new HelloGrainSayEvent(newMessage));

            Console.WriteLine($"{nameof(HelloGrain)} RaiseEvent");
            Console.WriteLine($"{nameof(HelloGrain)} UnconfirmedEvents.Count: {UnconfirmedEvents.Count()}");

            return ConfirmEvents();
        }

        protected override void TransitionState(HelloGrainState state, object @event)
        {
            base.TransitionState(state, @event);
        }
    }

    public class HelloGrainState
    {
        public string Message { get; set; }
    }

    public class HelloGrainSayEvent
    {
        public Guid Guid { get; }
        public DateTime Timestamp { get; }
        public string Message { get; set; }

        public HelloGrainSayEvent(string message)
        {
            Guid = Guid.NewGuid();
            Timestamp = DateTime.UtcNow;
            Message = message;
        }
    }

}

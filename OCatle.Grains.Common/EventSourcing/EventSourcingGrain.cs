using EventStore.ClientAPI;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OCatle.inf.V1.EentSourcing;
using OCatle.inf.V1.Versions;
using Orleans;
using Orleans.Concurrency;
using Orleans.EventSourcing;
using PS.Applications.Common.Interfaces;
using PS.Applications.TestCommand.Commands;
using PS.Common.OrlensHelper;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OCatle.Grains.Common.EventSourcing
{
    public class EventSourcingGrain : JournaledGrain<BankAccountState>, IEventSourcingGrain
    {
        private readonly IApplicationDbContext _app;
        private readonly IClusterClient _clusterClient;
        private readonly ILogger<EventSourcingGrain> _logger;
        private IMediator _mediator;
        private readonly IEventStoreConnection _conn;
        private string _stream;

        public EventSourcingGrain(IClusterClient clusterClient,
           //db_mechantcontext mec,
           IApplicationDbContext app,
           ILogger<EventSourcingGrain> logger,
           IMediator mediator
           )
        {
            this._clusterClient = clusterClient;
            this._logger = logger;
            this._app = app;
            this._mediator = mediator;

            var settings = ConnectionSettings
                .Create().
                EnableVerboseLogging()
                .UseConsoleLogger();

            _conn = EventStoreConnection.Create(settings, new IPEndPoint(IPAddress.Loopback, 8012));

            //this._mec = mec;
        }
        /*public override async Task OnActivateAsync()
        {
            _stream = $"{GetType().Name}-{this.GetPrimaryKey()}";

            await _conn.ConnectAsync();

            StreamEventsSlice currentSlice;
            var nextSliceStart = StreamPosition.Start;
            do
            {
                currentSlice = await _conn.ReadStreamEventsForwardAsync(_stream, nextSliceStart, 200, false);
                foreach (var evnt in currentSlice.Events)
                {
                    base.RaiseEvent(DeserializeEvent(evnt.Event));
                }

                nextSliceStart = (int)currentSlice.NextEventNumber;

            } while (!currentSlice.IsEndOfStream);

            await ConfirmEvents();
        }*/


        public Task<decimal> Balance()
        {
            return Task.FromResult(State.Balance);
        }

        public Task Deposit(decimal amount)
        {
            RaiseEvent(new Deposited
            {
                Amount = amount
            });
            return ConfirmEvents();
        }

        private async Task RaiseEvent(BankAccountEvent evnt)
        {
            base.RaiseEvent(evnt);
            await ConfirmEvents();

            await _conn.AppendToStreamAsync(_stream, Version - 2, ToEventData(Guid.NewGuid(), evnt, new Dictionary<string, object>()));
        }



        public Task Withdraw(decimal amount)
        {
            RaiseEvent(new Withdrawn
            {
                Amount = amount
            });
            return ConfirmEvents();
        }

        public async Task<string> GetTest(string message)
        {
            CreateComand.Request re = new CreateComand.Request() { name = message, memo = "zz" };
            await _mediator.Send(re);
            await Task.Delay(1000);

            return "완료";
        }

        private static EventData ToEventData(Guid eventId, object evnt, IDictionary<string, object> headers)
        {
            var data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(evnt));

            var eventHeaders = new Dictionary<string, object>(headers)
            {
                {
                    "EventClrType", evnt.GetType().AssemblyQualifiedName
                }
            };
            var metadata = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(eventHeaders));
            var typeName = evnt.GetType().Name;

            return new EventData(eventId, typeName, true, data, metadata);
        }

        private static object DeserializeEvent(RecordedEvent evntData)
        {
            var eventClrTypeName = JObject.Parse(Encoding.UTF8.GetString(evntData.Metadata)).Property("EventClrType").Value;
            return JsonConvert.DeserializeObject(Encoding.UTF8.GetString(evntData.Data), Type.GetType((string)eventClrTypeName));
        }
    }
}

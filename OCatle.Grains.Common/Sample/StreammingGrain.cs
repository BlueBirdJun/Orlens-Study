using MediatR;
using Microsoft.Extensions.Logging;
using OCatle.inf.V1.EentSourcing;
using OCatle.inf.V1.Streaming;
using OCatle.inf.V1.Versions;
using Orleans;
using Orleans.Concurrency;
using Orleans.Streams;
using PS.Applications.Common.Interfaces;
using PS.Applications.TestCommand.Commands;
using PS.Common.OrlensHelper;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace OCatle.Grains.Common.Sample
{
    public class StreammingGrain : GrainBase, IStreammingGrain
    {
        private readonly IApplicationDbContext _app;
        private readonly IClusterClient _clusterClient;
        private readonly ILogger<StreammingGrain> _logger;
        private IMediator _mediator;
        public StreammingGrain(IClusterClient clusterClient,
           //db_mechantcontext mec,
           IApplicationDbContext app,
           ILogger<StreammingGrain> logger,
           IMediator mediator
           )
        {
            this._clusterClient = clusterClient;
            this._logger = logger;
            this._app = app;
            this._mediator = mediator;
            //this._mec = mec;
        }

        private IAsyncStream<string> stream;

        public override Task OnActivateAsync()
        {
            var streamProvider = GetStreamProvider(StreamNames.PubSubProviderName);
            stream = streamProvider.GetStream<string>(Guid.NewGuid(), StreamNames.HelloGrainNamespace);
            return base.OnActivateAsync();
        }

        

        public Task<Guid> JoinAsync()
        {
            return Task.FromResult(stream.Guid);            
        }

        public async Task SayStreamAsync(string message)
        {
            //await stream.OnNextAsync(message);
            CreateComand.Request re = new CreateComand.Request() { name = message, memo = "zz" };
            await _mediator.Send(re); 
            //stream.
            //stream.OnNextBatchAsync()
            //await Task.Delay(1000);
            //await stream.OnCompletedAsync();
        }
    }
}

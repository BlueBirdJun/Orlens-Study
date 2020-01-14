using MediatR;
using Microsoft.Extensions.Logging;
using OCatle.inf.V1.EentSourcing;
using OCatle.inf.V1.Versions;
using Orleans;
using Orleans.Concurrency;
using PS.Applications.Common.Interfaces;
using PS.Applications.TestCommand.Commands;
using PS.Common.OrlensHelper;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OCatle.Grains.Common.EventSourcing
{
    public class EventSourcingGrain : GrainBase, IEventSourcingGrain
    {
        private readonly IApplicationDbContext _app;
        private readonly IClusterClient _clusterClient;
        private readonly ILogger<EventSourcingGrain> _logger;
        private IMediator _mediator;
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
            //this._mec = mec;
        }

        public async Task<string> GetTest(string message)
        {
            CreateComand.Request re = new CreateComand.Request() { name = message, memo = "zz" };
            await _mediator.Send(re);
            await Task.Delay(1000);

            return "완료";
        }
    }
}

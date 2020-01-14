using MediatR;
using Microsoft.Extensions.Logging;
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


namespace OCatle.Grains.Common.Verisons
{
    [StatelessWorker]
    public class VersionProvider : GrainBase, IVersionProvider
    {
        private readonly IApplicationDbContext _app;
        private readonly IClusterClient _clusterClient;
        private readonly ILogger<VersionProvider> _logger;
        private IMediator _mediator;
        public VersionProvider(IClusterClient clusterClient,
           //db_mechantcontext mec,
           IApplicationDbContext app,
           ILogger<VersionProvider> logger,
           IMediator mediator
           )
        {
            this._clusterClient = clusterClient;
            this._logger = logger;
            this._app = app;
            this._mediator = mediator;
            //this._mec = mec;
        }
        public async Task Gett1()
        {
            _logger.LogDebug("은녕 ");
            await Task.Delay(1000);

        }
        public async Task UpdateVersion(string source)
        {
            CreateComand.Request re = new CreateComand.Request() { name = source, memo = "zz" };
            await _mediator.Send(re);

            //Log.login("나오니?");
            //_logger.LogWarning("경고");
            ///_logger.LogDebug("은녕 ");
            //_app.brand.Add(new PS.Domain.Entities.tblbrand() { Brandname="안녕" });
            //CancellationToken cto = new CancellationToken();
            //await _app.SaveChangesAsync(cto);
            await Task.Delay(1000);
        }

         

        


    }
}

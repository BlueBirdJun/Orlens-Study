using MediatR;
using Microsoft.Extensions.Logging;
using OCatle.inf.V1.Versions;
using Orleans;
using Orleans.Concurrency;
using PS.Applications.Common.Interfaces;
using PS.Applications.TestCommand.Commands;
using PS.Common.OrlensHelper;
using PS.Database;
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
        //private readonly IApplicationDbContext _app;
        private readonly IClusterClient _clusterClient;
        private readonly ILogger<VersionProvider> _logger;
        private IMediator _mediator;
        //private readonly db_mechantcontext _mec;
        private readonly IMechantDbContext _mec;

        public VersionProvider(IClusterClient clusterClient,
           //db_mechantcontext mec,
          // IApplicationDbContext app,
           ILogger<VersionProvider> logger,
           IMediator mediator
           ,IMechantDbContext mec
           )
        {
            this._clusterClient = clusterClient;
            this._logger = logger;
            //this._app = app;
            this._mediator = mediator;
            this._mec = mec;

        }
        public async Task Gett1()
        {
            _logger.LogDebug("은녕 ");
            await Task.Delay(1000);

        }
        public async Task UpdateVersion(string source)
        {
            //_mec.brand.Add(new PS.Database.Models.db_Mechant.Tblbrand() { Brandname = "ccccc" });
            
            // _mec.SaveChangesAsync();

                
            //await _mec.SaveChangesAsync(new CancellationToken() { });
            //_mec.Tblbrand.Add(new PS.Database.Models.db_Mechant.Tblbrand() { Brandname="안녕"  });
            //await _mec.SaveChangesAsync();
            //PS.Applications.Brand.Commands.CreateCommand.Request data = new PS.Applications.Brand.Commands.CreateCommand.Request();

            //PS.Application.Commands.Brand.Commands.GetBrands.SeedData data = new PS.Applications.Common.Base.HandlerBase<PS.Application.Commands.Brand.Commands.GetBrands.Request, PS.Application.Commands.Brand.Commands.GetBrands.Response>.SeedData();
            //data.Data.dddd = "ccc";

            //var rt =  await _mediator.Send(data);


            return;
            CreateComand.Request re = new CreateComand.Request() { name = source, memo = "zz" };
            

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

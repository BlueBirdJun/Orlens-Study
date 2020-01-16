
using MediatR;
using Microsoft.Extensions.Logging;
using PS.Applications.Common.Interfaces;
using PS.Database;
using PS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PS.Applications.Brand.Commands
{
    public class CreateCommand
    {
        public class Request : IRequest<CreateCommand.Result>
        {
            public string name { get; set; }

            public string memo { get; set; }
        }

        public class Result
        {
            public string message { get; set; }
        }
        public class Handler : IRequestHandler<CreateCommand.Request, Result>
        {
            private readonly db_mechantcontext _mec;
            private readonly ILogger<CreateCommand> _logger;
            //private readonly IApplicationDbContext _context;
            public Handler(db_mechantcontext mec, ILogger<CreateCommand> logger)
            {
                this._logger = logger; 
                this._mec = mec;
            }

            public async Task<Result> Handle(CreateCommand.Request request, CancellationToken cancellationToken)
            {
                Result rs = new Result();
                //var entity = new TodoList();
                try
                {
                    _mec.Tblbrand.Add(new PS.Database.Models.db_Mechant.Tblbrand() { Brandname = "안녕111" });
                    await _mec.SaveChangesAsync();

                    return rs;
                }
                catch (Exception exc)
                {
                    return rs;
                }

            }
        }

    }
}

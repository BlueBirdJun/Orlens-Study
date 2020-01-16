using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PS.Applications.Version.Commands
{
    public class GetCommand  : BaseHandler <GetCommand.Request,GetCommand.Response>
    {
        public class Request
        {
            public string cccc { get; set; }
        }

        public class Response
        {
            public string dddd { get; set; }
        }

        public class Handler : IRequestHandler<GetCommand.SeedData, Result>
        {

            public Handler()
            {

            }
            public async Task<Result> Handle(GetCommand.SeedData req, CancellationToken cancellationToken)
            {
                Result rt = new BaseHandler<Request, Response>.Result();
                try
                {
                    rt.Data = new Response();
                    rt.Data.dddd = req.Data.cccc + "완료";

                }
                catch(Exception exc)
                {
                    rt.ErrorMessage(exc.Message);
                }
                return rt;
            }
        }

    }
}

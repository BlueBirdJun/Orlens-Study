using MediatR;
using PS.Applications.Common.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PS.Application.Commands.Brand.Commands
{
    public class GetBrands :HandlerBase<GetBrands.Request,GetBrands.Response>
    {
        public class Request
        {
            public string dddd { get; set; }
        }

        public class Response
        {
            public string cccc { get; set; }
        }

        public class Handler : IRequestHandler<GetBrands.SeedData, Result>
        {

            public Handler()
            {

            }
            public async Task<Result> Handle(GetBrands.SeedData req, CancellationToken cancellationToken)
            {
                Result rt = new HandlerBase<Request, Response>.Result();
                try
                {
                    req.Data.dddd = "cccc";

                    //rt.Data.dddd = req.Data.cccc + "완료";

                }
                catch (Exception exc)
                {
                    rt.ErrorMessage(exc.Message);
                }
                return rt;
            }
        }

    }
}

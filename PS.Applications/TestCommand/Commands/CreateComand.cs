
using MediatR;
using PS.Applications.Common.Interfaces;
using PS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PS.Applications.TestCommand.Commands
{
    public class CreateComand
    {
        public class Request : IRequest<CreateComand.Result>
        {
            public string name { get; set; }

            public string memo { get; set; }
        }

        public class Result
        {
            public string message { get; set; }
        }

        public class CreateCommandHandler : IRequestHandler<CreateComand.Request, Result>
        {
            private readonly IApplicationDbContext _context;
            public CreateCommandHandler(IApplicationDbContext context)
            {

                _context = context;
            }

            public async Task<Result> Handle(CreateComand.Request request, CancellationToken cancellationToken)
            {
                Result rs = new Result();
                //var entity = new TodoList();
                try
                {
                    //entity.Title = request.Title;
                    tbltest ot = new tbltest();
                    ot.Name = request.name;
                    ot.Memo = request.memo;
                    
                    
                    _context.tbltest.Add(ot);
                    //_context.TodoLists.Add(entity);
                    await _context.SaveChangesAsync(cancellationToken);

                    //await Task.Delay(100);
                    rs.message = "안녕";
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

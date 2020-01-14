using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PS.Common.OrlensHelper
{
    public class GrainBase : Grain, IIncomingGrainCallFilter
    {
        

        //protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        public IServiceProvider RequestServices { get; set; }

        public async Task Invoke(IIncomingGrainCallContext context)
        {
            var scope = this.ServiceProvider.CreateScope();
            try
            {
                this.RequestServices = scope.ServiceProvider;
                await context.Invoke();
            }
            finally
            {
                scope.Dispose();
                this.RequestServices = null;
            }
        }
    }
}

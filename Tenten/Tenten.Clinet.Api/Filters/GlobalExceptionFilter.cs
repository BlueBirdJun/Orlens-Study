using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using PS.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tenten.Clinet.Api.Filters
{
    public class GlobalExceptionFilter : ExceptionFilterAttribute
    {
        private readonly TraceId _traceId;
        private readonly ILoggerFactory _loggerFactory;

        public GlobalExceptionFilter(TraceId traceId,
        ILoggerFactory loggerFactory)

        {
            _traceId = traceId;
            _loggerFactory = loggerFactory;
        }

        public override void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult(new ErrorResponse(_traceId) { Message = context.Exception.Message })
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            _loggerFactory.CreateLogger(context.RouteData.Values["controller"].ToString())
                .LogError(context.Exception, "");
        }

        public override Task OnExceptionAsync(ExceptionContext context)
        {
            context.Result = new ObjectResult(new ErrorResponse(_traceId) { Message = context.Exception.Message })
            {
                StatusCode = StatusCodes.Status500InternalServerError

            };

            _loggerFactory.CreateLogger(context.RouteData.Values["controller"].ToString())
                .LogError(context.Exception, "");

            return Task.CompletedTask;
        }
    }
}

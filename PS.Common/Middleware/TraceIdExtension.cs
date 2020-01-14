using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PS.Common.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common.Middleware
{
    public static class TraceIdExtension
    {
        public static IServiceCollection AddTraceId(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<TraceId>(o =>
            {
                var httpContextAccessor = o.GetRequiredService<IHttpContextAccessor>();
                var traceId = httpContextAccessor.HttpContext.Items["TRACE_ID"];
                if (traceId == null)
                    throw new NullReferenceException(nameof(traceId));

                if (!Guid.TryParse(traceId.ToString(), out var guid))
                    throw new ArgumentNullException(nameof(guid));

                return TraceId.New(guid);
            });
            return serviceCollection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common.Entity
{
    public class ErrorResponse
    {
        public string TraceId { get; }
        public int Code { get; set; }
        public string Message { get; set; }

        public ErrorResponse(TraceId traceId)
        {
            this.TraceId = traceId.ToString();
        }
    }
}

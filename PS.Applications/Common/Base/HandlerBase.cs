using MediatR;
using PS.Common.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Applications.Common.Base
{
    public class HandlerBase<T, S> where T:new() where S :new()
    {
        public class SeedData : IRequest<Result>
        {
            public T Data { get; set; } = new T();
        }

        public class Result : BaseDto
        {
            public S Data { get; set; } = new S();
        }
    }
}

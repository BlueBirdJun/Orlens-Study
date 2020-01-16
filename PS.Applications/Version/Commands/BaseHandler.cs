using MediatR;
using Microsoft.Extensions.Logging;
using PS.Applications.Common.Interfaces;
using PS.Common.Entity;
using PS.Database;
using PS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PS.Applications.Version.Commands
{
    public class BaseHandler <T,S>
    {
        public class SeedData : IRequest<Result>
        {
            public T Data { get; set; }
        }

        public class Result : BaseDto
        {
            public S Data { get; set; }
        }
    }
}

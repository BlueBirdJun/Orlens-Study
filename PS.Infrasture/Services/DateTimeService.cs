using PS.Applications.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Infrasture.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}

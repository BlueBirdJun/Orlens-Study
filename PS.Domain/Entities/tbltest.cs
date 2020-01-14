using PS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public class tbltest : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
    }
}

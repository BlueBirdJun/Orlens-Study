using PS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public int Categorykey { get; set; }
        public int? Parentkey { get; set; }
        public string Categoryname { get; set; }
        public string Description { get; set; }
        public string Depth { get; set; }
    }
}

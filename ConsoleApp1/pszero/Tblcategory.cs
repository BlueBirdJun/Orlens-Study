using System;
using System.Collections.Generic;

namespace ConsoleApp1.pszero
{
    public partial class Tblcategory
    {
        public int Categorykey { get; set; }
        public int? Parentkey { get; set; }
        public string Categoryname { get; set; }
        public string Description { get; set; }
        public string Depth { get; set; }
        public DateTime? Createdate { get; set; }
    }
}

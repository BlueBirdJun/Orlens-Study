using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblBetweenProjectGroupItem
    {
        public int PjtCode { get; set; }
        public int Itemid { get; set; }
        public int? PjtgroupCode { get; set; }
        public int? PjtitemSort { get; set; }
    }
}

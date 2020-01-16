using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemOption
    {
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Isusing { get; set; }
        public string Optsellyn { get; set; }
        public string Optlimityn { get; set; }
        public int Optlimitno { get; set; }
        public int Optlimitsold { get; set; }
        public string OptionTypeName { get; set; }
        public string Optionname { get; set; }
        public decimal Optaddprice { get; set; }
        public decimal Optaddbuyprice { get; set; }
        public string Optrackcode { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblMakeglobProductOption
    {
        public int Idx { get; set; }
        public int ProductKey { get; set; }
        public int ProductCode { get; set; }
        public string Tenoptioncode { get; set; }
        public string OptionIndexName { get; set; }
        public string OptionIndexValue { get; set; }
        public string OptionIndexPrice { get; set; }
        public int? Stock { get; set; }
        public string Soldout { get; set; }
        public string Hidden { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

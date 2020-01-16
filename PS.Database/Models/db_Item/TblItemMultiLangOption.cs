using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemMultiLangOption
    {
        public int Itemid { get; set; }
        public string CountryCd { get; set; }
        public string Itemoption { get; set; }
        public string Isusing { get; set; }
        public string OptionTypeName { get; set; }
        public string Optionname { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItemMultiLang
    {
        public int Itemid { get; set; }
        public string CountryCd { get; set; }
        public string Itemname { get; set; }
        public string Itemcopy { get; set; }
        public string ItemContent { get; set; }
        public string Itemsource { get; set; }
        public string Itemsize { get; set; }
        public string Sourcearea { get; set; }
        public string Makername { get; set; }
        public string Useyn { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Keywords { get; set; }
        public string AreaCode11st { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblOutmallOptionManager
    {
        public int Idx { get; set; }
        public string Mallid { get; set; }
        public int Itemid { get; set; }
        public string Itemoption { get; set; }
        public string Itemname { get; set; }
        public string Optionname { get; set; }
        public string Newitemname { get; set; }
        public DateTime Regdate { get; set; }
        public string Reguserid { get; set; }
        public string MallGoodNo { get; set; }
        public string ItemnameChange { get; set; }
    }
}

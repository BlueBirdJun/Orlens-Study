using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblBetweenProjectGroupItem
    {
        public int Idx { get; set; }
        public int PjtCode { get; set; }
        public int Itemid { get; set; }
        public int? PjtgroupCode { get; set; }
        public int? PjtitemSort { get; set; }
        public int? MainMdpickSortNo { get; set; }
        public DateTime? MainMdpickXmlregdate { get; set; }
    }
}

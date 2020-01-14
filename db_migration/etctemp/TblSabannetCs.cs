using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblSabannetCs
    {
        public int Idx { get; set; }
        public string Divcd { get; set; }
        public string Gubunname { get; set; }
        public string SellSite { get; set; }
        public string OutMallOrderSerial { get; set; }
        public string OrgDetailKey { get; set; }
        public string CsdetailKey { get; set; }
        public string OrderSerial { get; set; }
        public int? ItemId { get; set; }
        public string Itemoption { get; set; }
        public int? Itemno { get; set; }
        public string OutMallItemName { get; set; }
        public string OutMallItemOptionName { get; set; }
        public string OrderName { get; set; }
        public string Currstate { get; set; }
        public string Deleteyn { get; set; }
        public DateTime? OutMallRegDate { get; set; }
        public DateTime RegDate { get; set; }
        public string FinUserId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblLtiMallOrdNoti
    {
        public string OrderNo { get; set; }
        public string OrderSeq { get; set; }
        public DateTime OrderDt { get; set; }
        public DateTime? PayDt { get; set; }
        public string GoodsId { get; set; }
        public string GoodsName { get; set; }
        public string EntpDtCode { get; set; }
        public string GoodsdtInfo { get; set; }
        public string OName { get; set; }
        public string OTel { get; set; }
        public string OHtel { get; set; }
        public string OEmail { get; set; }
        public string SName { get; set; }
        public string STel { get; set; }
        public string SHtel { get; set; }
        public string SPost { get; set; }
        public string SAddr { get; set; }
        public string CsMsg { get; set; }
        public int Qty { get; set; }
        public decimal SalePrice { get; set; }
        public string DelyType { get; set; }
        public decimal DelyCost { get; set; }
        public DateTime Datetime { get; set; }
        public string Documentid { get; set; }
        public DateTime Regdate { get; set; }
        public string Refip { get; set; }
        public int? NotiStatus { get; set; }
    }
}

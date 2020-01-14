using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblSabannetDetail
    {
        public int Idx { get; set; }
        public string SabanetNum { get; set; }
        public string MallId { get; set; }
        public string MallUserId { get; set; }
        public string CsStatus { get; set; }
        public DateTime? RegDm { get; set; }
        public string ProductId { get; set; }
        public string Subject { get; set; }
        public string Cnts { get; set; }
        public string InsNm { get; set; }
        public DateTime? InsDm { get; set; }
        public string RplyCnts { get; set; }
        public string UpdNm { get; set; }
        public DateTime? UpdDm { get; set; }
        public string CsGubun { get; set; }
        public string CompaynyGoodsCd { get; set; }
        public string OrderId { get; set; }
        public string SendDm { get; set; }
        public string ProductNm { get; set; }
        public string TenStatus { get; set; }
        public string Orderserial { get; set; }
        public int? Itemid { get; set; }
        public string SellSite { get; set; }
        public string MallProdId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXSiteTmporder
    {
        public int OutMallOrderSeq { get; set; }
        public string OrderSerial { get; set; }
        public string SellSite { get; set; }
        public string SellSiteName { get; set; }
        public string OutMallOrderSerial { get; set; }
        public DateTime? SellDate { get; set; }
        public string PayType { get; set; }
        public DateTime? PayDate { get; set; }
        public int MatchItemId { get; set; }
        public string Matchitemoption { get; set; }
        public string OrderItemId { get; set; }
        public string OrderItemName { get; set; }
        public string OrderItemOption { get; set; }
        public string OrderItemOptionName { get; set; }
        public string Prdcode { get; set; }
        public string Locationidmaker { get; set; }
        public string SellsiteUserId { get; set; }
        public string OrderName { get; set; }
        public string OrderEmail { get; set; }
        public string OrderTelNo { get; set; }
        public string OrderHpNo { get; set; }
        public string ReceiveName { get; set; }
        public string ReceiveTelNo { get; set; }
        public string ReceiveHpNo { get; set; }
        public string ReceiveZipCode { get; set; }
        public string ReceiveAddr1 { get; set; }
        public string ReceiveAddr2 { get; set; }
        public decimal? SellPrice { get; set; }
        public decimal? RealSellPrice { get; set; }
        public string Vatinclude { get; set; }
        public int? ItemOrderCount { get; set; }
        public int? DeliveryType { get; set; }
        public decimal? Deliveryprice { get; set; }
        public DateTime? RegDate { get; set; }
        public string Deliverymemo { get; set; }
        public string CountryCode { get; set; }
        public string RequireDetail { get; set; }
        public string MatchState { get; set; }
        public decimal? OrderDlvPay { get; set; }
        public string OrgDetailKey { get; set; }
        public int? SendState { get; set; }
        public int? SendReqCnt { get; set; }
        public string OutMallGoodsNo { get; set; }
        public int? OrderCsGbn { get; set; }
        public string RefOutMallOrderSerial { get; set; }
        public int? RefCsid { get; set; }
        public string EtcFinUser { get; set; }
        public int? Changeitemid { get; set; }
        public string Changeitemoption { get; set; }
        public int? OrgOrderCnt { get; set; }
        public int? RecvSendState { get; set; }
        public int? RecvSendReqCnt { get; set; }
        public string ShoplinkerOrderId { get; set; }
        public decimal? TenCpnUint { get; set; }
        public decimal? MallCpnUnit { get; set; }
        public decimal? PreUseUnitcost { get; set; }
        public string OutMallJmonth { get; set; }
        public decimal? OverseasPrice { get; set; }
        public decimal? OverseasDeliveryPrice { get; set; }
        public decimal? OverseasRealPrice { get; set; }
        public string Reserve01 { get; set; }
        public string BeasongNum11st { get; set; }
        public string RequireDetail11stYn { get; set; }
        public string SendSongjangNo { get; set; }
        public string SubSellSite { get; set; }
        public string OutMallOptionNo { get; set; }
        public string RequiredetailUtf8 { get; set; }
    }
}

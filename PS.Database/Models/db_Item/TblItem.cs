using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblItem
    {
        public int Itemid { get; set; }
        public string Makerid { get; set; }
        public string CateLarge { get; set; }
        public string CateMid { get; set; }
        public string CateSmall { get; set; }
        public string Itemdiv { get; set; }
        public string Itemgubun { get; set; }
        public string Itemname { get; set; }
        public decimal Sellcash { get; set; }
        public decimal Buycash { get; set; }
        public decimal Orgprice { get; set; }
        public decimal Orgsuplycash { get; set; }
        public decimal Sailprice { get; set; }
        public decimal Sailsuplycash { get; set; }
        public decimal Mileage { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public string Sellyn { get; set; }
        public string Limityn { get; set; }
        public string Danjongyn { get; set; }
        public string Sailyn { get; set; }
        public string Isusing { get; set; }
        public string Isextusing { get; set; }
        public string Mwdiv { get; set; }
        public int Specialuseritem { get; set; }
        public string Vatinclude { get; set; }
        public string Deliverytype { get; set; }
        public string AvailPayType { get; set; }
        public string Deliverarea { get; set; }
        public string Deliverfixday { get; set; }
        public string Ismobileitem { get; set; }
        public string Pojangok { get; set; }
        public int? Limitno { get; set; }
        public int? Limitsold { get; set; }
        public int Evalcnt { get; set; }
        public int? EvalCntPhoto { get; set; }
        public int Optioncnt { get; set; }
        public string Itemrackcode { get; set; }
        public string Upchemanagecode { get; set; }
        public DateTime? Reipgodate { get; set; }
        public string Brandname { get; set; }
        public string Titleimage { get; set; }
        public string Mainimage { get; set; }
        public string Smallimage { get; set; }
        public string Listimage { get; set; }
        public string Listimage120 { get; set; }
        public string Basicimage { get; set; }
        public string Icon1image { get; set; }
        public string Icon2image { get; set; }
        public string Itemcouponyn { get; set; }
        public int? Curritemcouponidx { get; set; }
        public string Itemcoupontype { get; set; }
        public int? Itemcouponvalue { get; set; }
        public int? Itemscore { get; set; }
        public int? ItemWeight { get; set; }
        public string DeliverOverseas { get; set; }
        public string TenOnlyYn { get; set; }
        public string Basicimage600 { get; set; }
        public string MainImage2 { get; set; }
        public string FrontMakerid { get; set; }
        public int? ReserveItemTp { get; set; }
        public string Mainimage3 { get; set; }
        public string Basicimage1000 { get; set; }
        public string Maskimage { get; set; }
        public string Maskimage1000 { get; set; }
        public short OrderMinNum { get; set; }
        public short OrderMaxNum { get; set; }
        public string Dispcate1 { get; set; }
        public string Limitdispyn { get; set; }
        public DateTime? SellStdate { get; set; }
        public string Tentenimage { get; set; }
        public string Tentenimage50 { get; set; }
        public string Tentenimage200 { get; set; }
        public string Tentenimage400 { get; set; }
        public string Tentenimage600 { get; set; }
        public string Tentenimage1000 { get; set; }
        public int? Evaloffcnt { get; set; }
        public int? AdultType { get; set; }
    }
}

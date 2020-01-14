using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblWaitItem
    {
        public int Itemid { get; set; }
        public string ItemserialLarge { get; set; }
        public string ItemserialMid { get; set; }
        public string ItemserialSmall { get; set; }
        public string Itemdiv { get; set; }
        public string Makerid { get; set; }
        public string Itemname { get; set; }
        public string Itemcontent { get; set; }
        public DateTime Regdate { get; set; }
        public string Designercomment { get; set; }
        public string Itemsource { get; set; }
        public string Itemsize { get; set; }
        public decimal Buycash { get; set; }
        public decimal Sellcash { get; set; }
        public decimal Mileage { get; set; }
        public string Sellyn { get; set; }
        public string Deliverytype { get; set; }
        public string Sourcearea { get; set; }
        public string Makername { get; set; }
        public string Limityn { get; set; }
        public string Limitdiv { get; set; }
        public DateTime? Limitstart { get; set; }
        public DateTime? Limitend { get; set; }
        public int? Limitno { get; set; }
        public int? Limitsold { get; set; }
        public DateTime? Oregdate { get; set; }
        public string Vatinclude { get; set; }
        public string Pojangok { get; set; }
        public int? Favcount { get; set; }
        public string Isusing { get; set; }
        public string Istenusing { get; set; }
        public string Isextusing { get; set; }
        public string Isutotypeusing { get; set; }
        public double? Discountrate { get; set; }
        public int? Linkitemid { get; set; }
        public string Currstate { get; set; }
        public string Itemgubun { get; set; }
        public string Stylegubun { get; set; }
        public string Itemstyle { get; set; }
        public string Usinghtml { get; set; }
        public string Keywords { get; set; }
        public string Mwdiv { get; set; }
        public string TenOnlyYn { get; set; }
        public string Deliverarea { get; set; }
        public string Deliverfixday { get; set; }
        public string Ordercomment { get; set; }
        public string Titleimage { get; set; }
        public string Mainimage { get; set; }
        public string Mainimage2 { get; set; }
        public string Smallimage { get; set; }
        public string Listimage { get; set; }
        public string Basicimage { get; set; }
        public string Icon1image { get; set; }
        public string Icon2image { get; set; }
        public string Addimage { get; set; }
        public string Storyimage { get; set; }
        public string Infoimage { get; set; }
        public string Imagecontent { get; set; }
        public int? Optioncnt { get; set; }
        public string RejectMsg { get; set; }
        public DateTime? RejectDate { get; set; }
        public string ReRegMsg { get; set; }
        public DateTime? ReRegDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public string Upchemanagecode { get; set; }
        public string CateLarge { get; set; }
        public string CateMid { get; set; }
        public string CateSmall { get; set; }
        public int RequireMakeDay { get; set; }
        public string SafetyYn { get; set; }
        public byte? SafetyDiv { get; set; }
        public string SafetyNum { get; set; }
        public string InfoDiv { get; set; }
        public decimal? FreightMin { get; set; }
        public decimal? FreightMax { get; set; }
        public short? OrderMinNum { get; set; }
        public short? OrderMaxNum { get; set; }
        public DateTime? Lastupdate { get; set; }
        public int? ItemWeight { get; set; }
        public string DeliverOverseas { get; set; }
        public byte? Sourcekind { get; set; }
        public string Addmsg { get; set; }
        public string Addcarve { get; set; }
        public string Addbox { get; set; }
        public string Addset { get; set; }
        public string Addcustom { get; set; }
    }
}

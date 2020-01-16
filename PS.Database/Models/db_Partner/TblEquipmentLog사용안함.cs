using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEquipmentLog사용안함
    {
        public int Idx { get; set; }
        public string EquipCode { get; set; }
        public string EquipGubun { get; set; }
        public string EquipName { get; set; }
        public string ModelName { get; set; }
        public string ManufactureCompany { get; set; }
        public string BuyCompanyCode { get; set; }
        public string BuyCompanyName { get; set; }
        public string BuyDate { get; set; }
        public decimal? BuyCost { get; set; }
        public decimal? BuyVat { get; set; }
        public decimal? BuySum { get; set; }
        public int? EquipNo { get; set; }
        public int? DurabilityMonth { get; set; }
        public string DetailQuality1 { get; set; }
        public string DetailQuality2 { get; set; }
        public string DetailQualityetc { get; set; }
        public string DetailIp { get; set; }
        public string EtcStr { get; set; }
        public string Usinguserid { get; set; }
        public string PartCode { get; set; }
        public string Regdate { get; set; }
        public string Lastupdate { get; set; }
        public string Reguserid { get; set; }
        public string Modiuserid { get; set; }
        public string DelId { get; set; }
        public string DelDate { get; set; }
    }
}

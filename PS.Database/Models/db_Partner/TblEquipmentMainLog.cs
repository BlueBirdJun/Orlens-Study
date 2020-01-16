using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEquipmentMainLog
    {
        public int Logidx { get; set; }
        public int Idx { get; set; }
        public string EquipCode { get; set; }
        public string EquipGubun { get; set; }
        public string EquipName { get; set; }
        public string EquipSpec { get; set; }
        public string EquipMainimage { get; set; }
        public int PropertyGubun { get; set; }
        public string ManufactureSn { get; set; }
        public string ManufactureCompany { get; set; }
        public string ManufactureManager { get; set; }
        public string ManufactureTel { get; set; }
        public string BuyCompanyName { get; set; }
        public DateTime? BuyDate { get; set; }
        public decimal? BuyCost { get; set; }
        public decimal? BuyVat { get; set; }
        public decimal? BuySum { get; set; }
        public string UsingUserid { get; set; }
        public DateTime? UsingDate { get; set; }
        public DateTime? OutDate { get; set; }
        public int State { get; set; }
        public int DurabilityMonth { get; set; }
        public string Etc { get; set; }
        public int? PartSn { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastupdate { get; set; }
        public string Reguserid { get; set; }
        public string Lastuserid { get; set; }
        public string Isusing { get; set; }
        public string Accountassetcode { get; set; }
        public int? Paymentrequestidx { get; set; }
        public string Logreguserid { get; set; }
        public DateTime Logregdate { get; set; }
        public string AccountGubun { get; set; }
        public int? DepartmentId { get; set; }
        public string LocateGubun { get; set; }
        public string BizsectionCd { get; set; }
        public decimal? MonthlyDeprice { get; set; }
        public decimal? RemainValue201412 { get; set; }
    }
}

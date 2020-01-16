using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblEquipmentIp
    {
        public int Ipidx { get; set; }
        public string Gubuncd { get; set; }
        public string CompanyIp { get; set; }
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public int? PartSn { get; set; }
        public string IsUsing { get; set; }
    }
}

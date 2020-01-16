using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Partner
{
    public partial class TblPartnerCtrSub
    {
        public int CtrSubKey { get; set; }
        public int CtrKey { get; set; }
        public string Sellplace { get; set; }
        public string Mwdiv { get; set; }
        public double Defaultmargin { get; set; }
        public string DefaultDeliveryType { get; set; }
        public decimal DefaultFreeBeasongLimit { get; set; }
        public decimal DefaultDeliverPay { get; set; }
    }
}

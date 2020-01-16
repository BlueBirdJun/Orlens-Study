using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblGsshopBrandDeliveryMapping
    {
        public string Makerid { get; set; }
        public string DeliveryCd { get; set; }
        public string DeliveryAddrCd { get; set; }
        public string Brandcd { get; set; }
        public DateTime Regdate { get; set; }
        public string Regid { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Updateid { get; set; }
    }
}

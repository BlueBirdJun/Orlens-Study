using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblFocusmOrderInfo
    {
        public string Orderserial { get; set; }
        public int Itemid { get; set; }
        public string TransactionId { get; set; }
        public string MediaCode { get; set; }
        public string AdCode { get; set; }
        public string Gadid { get; set; }
        public int? NumOfItem { get; set; }
        public int Status { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblXSiteCsMaster
    {
        public int Idx { get; set; }
        public string SellSite { get; set; }
        public string OutMallOrderSerial { get; set; }
        public string OutMallCsserial { get; set; }
        public string OrderSerial { get; set; }
        public string Divcd { get; set; }
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
        public string Deliverymemo { get; set; }
        public DateTime? OutMallRegDate { get; set; }
        public DateTime? RegDate { get; set; }
    }
}

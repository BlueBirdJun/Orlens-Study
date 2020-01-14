using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEmsServiceArea2014
    {
        public string CountryCode { get; set; }
        public string CountryNameKr { get; set; }
        public string CountryNameEn { get; set; }
        public string EmsAreaCode { get; set; }
        public int EmsMaxWeight { get; set; }
        public string ReceiverPay { get; set; }
        public string Isusing { get; set; }
        public string EtcContents { get; set; }
    }
}

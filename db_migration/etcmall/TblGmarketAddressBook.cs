using System;
using System.Collections.Generic;

namespace db_migration.etcmall
{
    public partial class TblGmarketAddressBook
    {
        public int Idx { get; set; }
        public int? AddressCode { get; set; }
        public string AddressTitle { get; set; }
        public string AddressName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Reqzipcode { get; set; }
        public string Reqzipaddr { get; set; }
        public string Reqaddress { get; set; }
        public int? BundleNo { get; set; }
    }
}

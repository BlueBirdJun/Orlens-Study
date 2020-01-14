using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMiracleof10secProduct
    {
        public int Idx { get; set; }
        public int Masteridx { get; set; }
        public int Itemid1 { get; set; }
        public string Itemname1 { get; set; }
        public int Itemprice1 { get; set; }
        public int Itemid2 { get; set; }
        public string Itemname2 { get; set; }
        public int Itemprice2 { get; set; }
        public byte Orderby { get; set; }
    }
}

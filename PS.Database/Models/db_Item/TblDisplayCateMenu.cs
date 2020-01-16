using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblDisplayCateMenu
    {
        public int Idx { get; set; }
        public short Catecode { get; set; }
        public string Type { get; set; }
        public short Number { get; set; }
        public string Value { get; set; }
        public string Useyn { get; set; }
    }
}

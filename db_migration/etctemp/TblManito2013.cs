using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblManito2013
    {
        public int Idx { get; set; }
        public int EvtCode { get; set; }
        public string Userid { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Tagno { get; set; }
        public string Etc1 { get; set; }
        public string Useyn { get; set; }
        public int Itemid { get; set; }
        public string Itemname { get; set; }
        public string Icon2image { get; set; }
        public string Device { get; set; }
        public DateTime Regdate { get; set; }
    }
}

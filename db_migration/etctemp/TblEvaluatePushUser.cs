using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblEvaluatePushUser
    {
        public long Idx { get; set; }
        public int Pushidx { get; set; }
        public string Userid { get; set; }
        public string Username { get; set; }
        public string Sendyn { get; set; }
        public string Writeyn { get; set; }
        public DateTime Regdate { get; set; }
    }
}

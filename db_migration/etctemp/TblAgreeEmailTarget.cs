using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblAgreeEmailTarget
    {
        public string Yyyymmdd { get; set; }
        public string Userid { get; set; }
        public string Uname { get; set; }
        public string Usermail { get; set; }
        public string AgreeEmailTen { get; set; }
        public string AgreeSmsten { get; set; }
        public string AgreeEmailFinger { get; set; }
        public string AgreeSmsfinger { get; set; }
        public string AgreePushTen { get; set; }
        public string AgreePushFinger { get; set; }
        public DateTime? Uregdate { get; set; }
        public string Uidsimple { get; set; }
    }
}

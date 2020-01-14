using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblMileExpireEmailTarget
    {
        public string Yyyymmdd { get; set; }
        public string Userid { get; set; }
        public string Uname { get; set; }
        public string Usermail { get; set; }
        public decimal MayExpireMile { get; set; }
        public decimal TotalMileage { get; set; }
    }
}

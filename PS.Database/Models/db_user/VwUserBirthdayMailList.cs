using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_user
{
    public partial class VwUserBirthdayMailList
    {
        public string Uid { get; set; }
        public string Umail { get; set; }
        public string Uname { get; set; }
        public string Ubirth { get; set; }
        public string CpstartDt { get; set; }
        public string CpendDt { get; set; }
        public string Mailok { get; set; }
        public string Fingersmailok { get; set; }
    }
}

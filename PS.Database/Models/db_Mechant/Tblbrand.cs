using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Mechant
{
    public partial class Tblbrand
    {
        public int Brandkey { get; set; }
        
        public string Brandname { get; set; }
        public string Korname { get; set; }
        public string Engname { get; set; }
        public string Address1 { get; set; }
        public string Addressdetail1 { get; set; }
        public string Zipcode1 { get; set; }
        public string Address2 { get; set; }
        public string Addressdetail2 { get; set; }
        public string Zipcode2 { get; set; }
        public string Cellnumber1 { get; set; }
        public string Cellnumber2 { get; set; }
        public string Ownername { get; set; }
        public string Managername { get; set; }
        public DateTime? Createdate { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Companyname { get; set; }
        public string Socnumber { get; set; }
        public string Email { get; set; }
        public string Homepage { get; set; }
    }
}

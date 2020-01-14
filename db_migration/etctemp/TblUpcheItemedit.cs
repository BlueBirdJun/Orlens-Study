using System;
using System.Collections.Generic;

namespace db_migration.etctemp
{
    public partial class TblUpcheItemedit
    {
        public int Idx { get; set; }
        public int Itemid { get; set; }
        public string Oldsellyn { get; set; }
        public string Olddispyn { get; set; }
        public string Oldlimityn { get; set; }
        public int? Oldlimitno { get; set; }
        public int? Oldlimitsold { get; set; }
        public string Sellyn { get; set; }
        public string Dispyn { get; set; }
        public string Limityn { get; set; }
        public int? Limitno { get; set; }
        public int? Limitsold { get; set; }
        public DateTime? Regdate { get; set; }
        public string Isupchebeasong { get; set; }
        public string Isfinish { get; set; }
        public string Etcstr { get; set; }
        public string Rejectstr { get; set; }
        public string Itemoption { get; set; }
        public string Itemoptionname { get; set; }
        public string Olditemname { get; set; }
        public string Itemname { get; set; }
        public decimal? Oldsellcash { get; set; }
        public decimal? Sellcash { get; set; }
        public decimal? Oldbuycash { get; set; }
        public decimal? Buycash { get; set; }
        public string IsCancel { get; set; }
        public string FinishId { get; set; }
        public DateTime? Finishdate { get; set; }
        public string Edittype { get; set; }
    }
}

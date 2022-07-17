using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.SearchObjects
{
    public class NarudzbaSearchObject
    {
        public int? KlijentID { get; set; }
        public int? DostavljacID { get; set; }
        public int? KoordinatorID { get; set; }
        public int? PoslovnicaID { get; set; }
        public DateTime? Datum { get; set; }
        public int? NarudzbaStatusID { get; set; }
        public List<string> IncludeList { get; set; }
        public int? excludeNarudzbaWithStatusId { get; set; }
    }
}

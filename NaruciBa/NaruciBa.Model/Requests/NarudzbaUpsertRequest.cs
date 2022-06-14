using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class NarudzbaUpsertRequest
    {
        public int? KlijentID { get; set; }
        public int? DostavljacID { get; set; }
        public int? KoordinatorID { get; set; }
        public int? PoslovnicaID { get; set; }
        public DateTime? Datum { get; set; }
        public decimal? UkupanIznos { get; set; }
        public decimal? BonusZaDostavljaca { get; set; }
        public string SlikaRacunaPutanja { get; set; }
        public int? NarudzbaStatusID { get; set; }
        public int? KuponID { get; set; }
    }
}

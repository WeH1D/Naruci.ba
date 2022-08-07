using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model
{
    public partial class Narudzba
    {
        public int NarudzbaID { get; set; }
        public int? KlijentID { get; set; }
        public int? DostavljacID { get; set; }
        public int? KoordinatorID { get; set; }
        public int? PoslovnicaID { get; set; }
        public DateTime? Datum { get; set; }
        public decimal? UkupanIznos { get; set; }
        public decimal? BonusZaDostavljaca { get; set; }
        public string SlikaRacunaPutanja { get; set; }
        public byte[] SlikaRacuna { get; set; }
        public int? NarudzbaStatusID { get; set; }
        public int? KuponID { get; set; }
    }
}

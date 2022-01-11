using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            NaruceniProizvods = new HashSet<NaruceniProizvod>();
        }

        public int NarudzbaID { get; set; }
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

        public virtual Dostavljac Dostavljac { get; set; }
        public virtual Klijent Klijent { get; set; }
        public virtual Koordinator Koordinator { get; set; }
        public virtual Kupon Kupon { get; set; }
        public virtual NarudzbaStatus NarudzbaStatus { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
        public virtual ICollection<NaruceniProizvod> NaruceniProizvods { get; set; }
    }
}

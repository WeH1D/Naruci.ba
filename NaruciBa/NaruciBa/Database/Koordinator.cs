using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Koordinator
    {
        public Koordinator()
        {
            Narudzbas = new HashSet<Narudzba>();
        }

        public int KoordinatorID { get; set; }
        public DateTime? DatumZaposlenja { get; set; }
        public int? KorisnikID { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}

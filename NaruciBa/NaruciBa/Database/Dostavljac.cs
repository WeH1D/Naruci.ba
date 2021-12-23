using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Dostavljac
    {
        public Dostavljac()
        {
            Narudzbas = new HashSet<Narudzba>();
        }

        public int DostavljacID { get; set; }
        public DateTime? DatumZaposlenja { get; set; }
        public int? KorisnikID { get; set; }
        public int? DostavljacStatus { get; set; }

        public virtual DostavljacStatus DostavljacStatusNavigation { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}

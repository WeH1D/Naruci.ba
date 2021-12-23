using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            DostavnaKvota = new HashSet<DostavnaKvotum>();
            Narudzbas = new HashSet<Narudzba>();
            PoslovnicaFavorits = new HashSet<PoslovnicaFavorit>();
            Recenzijas = new HashSet<Recenzija>();
        }

        public int KlijentID { get; set; }
        public int? KorisnikID { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<DostavnaKvotum> DostavnaKvota { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
        public virtual ICollection<PoslovnicaFavorit> PoslovnicaFavorits { get; set; }
        public virtual ICollection<Recenzija> Recenzijas { get; set; }
    }
}

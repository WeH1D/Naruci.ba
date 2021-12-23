using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Podkategorijas = new HashSet<Podkategorija>();
            TrgovackiLanacKategorijas = new HashSet<TrgovackiLanacKategorija>();
        }

        public int KategorijaID { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Podkategorija> Podkategorijas { get; set; }
        public virtual ICollection<TrgovackiLanacKategorija> TrgovackiLanacKategorijas { get; set; }
    }
}

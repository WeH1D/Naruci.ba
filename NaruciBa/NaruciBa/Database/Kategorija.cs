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
            PoslovnicaKategorijas = new HashSet<PoslovnicaKategorija>();
        }

        public int KategorijaID { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Podkategorija> Podkategorijas { get; set; }
        public virtual ICollection<PoslovnicaKategorija> PoslovnicaKategorijas { get; set; }
    }
}

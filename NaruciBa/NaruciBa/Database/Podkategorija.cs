using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Podkategorija
    {
        public Podkategorija()
        {
            Proizvods = new HashSet<Proizvod>();
        }

        public int PodkategorijaID { get; set; }
        public string Naziv { get; set; }
        public int? KategorijaID { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual ICollection<Proizvod> Proizvods { get; set; }
    }
}

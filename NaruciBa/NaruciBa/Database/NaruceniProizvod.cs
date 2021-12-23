using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class NaruceniProizvod
    {
        public int NaruceniProizvodID { get; set; }
        public int? ProizvodID { get; set; }
        public int? NarudzbaID { get; set; }
        public decimal? Kolicina { get; set; }
        public decimal? UkupnaCijena { get; set; }

        public virtual Narudzba Narudzba { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}

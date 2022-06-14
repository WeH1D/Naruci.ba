using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model
{
    public class NaruceniProizvod
    {
        public int NaruceniProizvodID { get; set; }
        public int? ProizvodID { get; set; }
        public int? NarudzbaID { get; set; }
        public decimal? Kolicina { get; set; }
        public decimal? UkupnaCijena { get; set; }
    }
}

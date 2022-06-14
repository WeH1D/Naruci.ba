using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class NaruceniProizvodUpsertRequest
    {
        public int? ProizvodID { get; set; }
        public int? NarudzbaID { get; set; }
        public decimal? Kolicina { get; set; }
        public decimal? UkupnaCijena { get; set; }
    }
}

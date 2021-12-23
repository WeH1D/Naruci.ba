using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Recenzija
    {
        public int RecenzijaID { get; set; }
        public int? Ocjena { get; set; }
        public string Komentar { get; set; }
        public int? KlijentID { get; set; }
        public int? PoslovnicaID { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class PoslovnicaFavorit
    {
        public int PoslovnicaFavoritID { get; set; }
        public int? KlijentID { get; set; }
        public int? PoslovnicaID { get; set; }
        public bool? Status { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
    }
}

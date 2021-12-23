using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class DostavnaKvotum
    {
        public int DostavnaKvotaID { get; set; }
        public int? PoslovnicaID { get; set; }
        public int? KlijentID { get; set; }
        public decimal? CijenaDostave { get; set; }
        public int? TrajanjeDostave { get; set; }
        public bool? Status { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
    }
}

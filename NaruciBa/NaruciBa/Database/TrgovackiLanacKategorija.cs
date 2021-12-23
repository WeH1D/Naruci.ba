using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class TrgovackiLanacKategorija
    {
        public int TrgovackiLanacKategorijaID { get; set; }
        public int? TrgovackiLanacID { get; set; }
        public int? KategorijaID { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual TrgovackiLanac TrgovackiLanac { get; set; }
    }
}

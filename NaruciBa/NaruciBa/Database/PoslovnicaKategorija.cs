using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class PoslovnicaKategorija
    {
        public int PoslovnicaKategorijaID { get; set; }
        public int? PoslovnicaID { get; set; }
        public int? KategorijaID { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class TrgovackiLanac
    {
        public TrgovackiLanac()
        {
            Poslovnicas = new HashSet<Poslovnica>();
        }

        public int TrgovackiLanacID { get; set; }
        public string Naziv { get; set; }
        public string SlikaPutanja { get; set; }

        public virtual ICollection<Poslovnica> Poslovnicas { get; set; }
    }
}

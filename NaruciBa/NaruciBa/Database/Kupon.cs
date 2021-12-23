using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Kupon
    {
        public Kupon()
        {
            KuponPoslovnicas = new HashSet<KuponPoslovnica>();
            Narudzbas = new HashSet<Narudzba>();
        }

        public int KuponID { get; set; }
        public decimal? Popust { get; set; }
        public bool? Postotak { get; set; }
        public int? BrojKupovina { get; set; }
        public bool? Aktivan { get; set; }
        public DateTime? DatumKreiranja { get; set; }

        public virtual ICollection<KuponPoslovnica> KuponPoslovnicas { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}

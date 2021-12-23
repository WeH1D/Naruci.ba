using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class NarudzbaStatus
    {
        public NarudzbaStatus()
        {
            Narudzbas = new HashSet<Narudzba>();
        }

        public int NarudzbaStatusID { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}

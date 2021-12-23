﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class TrgovackiLanac
    {
        public TrgovackiLanac()
        {
            Poslovnicas = new HashSet<Poslovnica>();
            TrgovackiLanacKategorijas = new HashSet<TrgovackiLanacKategorija>();
        }

        public int TrgovackiLanacID { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<Poslovnica> Poslovnicas { get; set; }
        public virtual ICollection<TrgovackiLanacKategorija> TrgovackiLanacKategorijas { get; set; }
    }
}
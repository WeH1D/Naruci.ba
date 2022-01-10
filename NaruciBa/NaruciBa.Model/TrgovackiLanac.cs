using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model
{
    public class TrgovackiLanac
    {
        public int TrgovackiLanacID { get; set; }
        public string Naziv { get; set; }
        public string SlikaPutanja{ get; set; }
        public byte[] Slika { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model
{
    public class Dostavljac
    {
        public int DostavljacID { get; set; }
        public DateTime? DatumZaposlenja { get; set; }
        public int? KorisnikID { get; set; }
        public int? DostavljacStatus { get; set; }
    }
}

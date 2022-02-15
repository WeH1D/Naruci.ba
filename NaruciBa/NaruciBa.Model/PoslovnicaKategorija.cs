using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model
{
    public class PoslovnicaKategorija
    {
        public int PoslovnicaKategorijaID { get; set; }
        public int? PoslovnicaID { get; set; }
        public int? KategorijaID { get; set; }
    }
}

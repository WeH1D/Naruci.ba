using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model
{
    public class Podkategorija
    {
        public int PodkategorijaID { get; set; }
        public string Naziv { get; set; }
        public int? KategorijaID { get; set; }
    }
}

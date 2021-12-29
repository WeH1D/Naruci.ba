using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.SearchObjects
{
    public class ProizvodSearchObject
    {
        public string? Sifra { get; set; }
        public string Naziv { get; set; }
        public int? PodkategorijaID { get; set; }
        public int? KategorijaID { get; set; }
        public int? PoslovnicaID { get; set; }
    }
}

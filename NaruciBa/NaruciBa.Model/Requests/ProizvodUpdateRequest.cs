using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class ProizvodUpdateRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal? Cijena { get; set; }
        public bool? Kg { get; set; }
        public int? PodkategorijaID { get; set; }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }
        public string SlikaPutanja { get; set; }
        public DateTime? DatumIzmjene { get; set; }
    }
}

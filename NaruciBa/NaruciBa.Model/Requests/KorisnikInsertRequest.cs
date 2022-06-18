using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class KorisnikInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public DateTime? DatumRodenja { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public string Password { get; set; }
        public byte[] Slika { get; set; }
        public int? GradID { get; set; }
        public DostavljacUpsertRequest? dostavljacInsert { get; set; }
        public KoordinatorInsertRequest? koordinatorInsert { get; set; }
    }
}

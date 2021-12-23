using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model
{
    public partial class Korisnik
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public DateTime? DatumRodenja { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public byte[] Slika { get; set; }
        public int? GradID { get; set; }
    }
}

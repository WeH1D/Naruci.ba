using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Dostavljacs = new HashSet<Dostavljac>();
            Klijents = new HashSet<Klijent>();
            Koordinators = new HashSet<Koordinator>();
        }

        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public DateTime? DatumRodenja { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string SlikaPutanja { get; set; }
        public int? GradID { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Dostavljac> Dostavljacs { get; set; }
        public virtual ICollection<Klijent> Klijents { get; set; }
        public virtual ICollection<Koordinator> Koordinators { get; set; }
    }
}

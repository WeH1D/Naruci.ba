using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Proizvod
    {
        public Proizvod()
        {
            NaruceniProizvods = new HashSet<NaruceniProizvod>();
        }

        public int ProizvodID { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal? Cijena { get; set; }
        public bool? Kg { get; set; }
        public int? PodkategorijaID { get; set; }
        public int? PoslovnicaID { get; set; }
        public bool? Status { get; set; }
        public string? SlikaPutanja { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual Podkategorija Podkategorija { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
        public virtual ICollection<NaruceniProizvod> NaruceniProizvods { get; set; }
    }
}

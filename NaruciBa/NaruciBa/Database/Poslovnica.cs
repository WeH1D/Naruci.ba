using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Poslovnica
    {
        public Poslovnica()
        {
            DostavnaKvota = new HashSet<DostavnaKvotum>();
            KuponPoslovnicas = new HashSet<KuponPoslovnica>();
            Narudzbas = new HashSet<Narudzba>();
            PoslovnicaFavorits = new HashSet<PoslovnicaFavorit>();
            Proizvods = new HashSet<Proizvod>();
            Recenzijas = new HashSet<Recenzija>();
            PoslovnicaKategorijas = new HashSet<PoslovnicaKategorija>();
        }

        public int PoslovnicaID { get; set; }
        public string Adresa { get; set; }
        public int? GradID { get; set; }
        public string KontaktTel { get; set; }
        public bool Status { get; set; }
        public string KontaktEmail { get; set; }
        public int? TrgovackiLanacID { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual TrgovackiLanac TrgovackiLanac { get; set; }
        public virtual ICollection<DostavnaKvotum> DostavnaKvota { get; set; }
        public virtual ICollection<KuponPoslovnica> KuponPoslovnicas { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
        public virtual ICollection<PoslovnicaFavorit> PoslovnicaFavorits { get; set; }
        public virtual ICollection<Proizvod> Proizvods { get; set; }
        public virtual ICollection<Recenzija> Recenzijas { get; set; }
        public virtual ICollection<PoslovnicaKategorija> PoslovnicaKategorijas { get; set; }
    }
}

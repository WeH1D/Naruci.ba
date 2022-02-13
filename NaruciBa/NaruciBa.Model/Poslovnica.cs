using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model
{
    public class Poslovnica
    {
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
    }
}

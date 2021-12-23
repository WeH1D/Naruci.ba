using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Korisniks = new HashSet<Korisnik>();
            Poslovnicas = new HashSet<Poslovnica>();
        }

        public int GradID { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Korisnik> Korisniks { get; set; }
        public virtual ICollection<Poslovnica> Poslovnicas { get; set; }
    }
}

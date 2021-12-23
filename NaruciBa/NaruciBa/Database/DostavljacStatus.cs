using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class DostavljacStatus
    {
        public DostavljacStatus()
        {
            Dostavljacs = new HashSet<Dostavljac>();
        }

        public int DostavljacStatusID { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Dostavljac> Dostavljacs { get; set; }
    }
}

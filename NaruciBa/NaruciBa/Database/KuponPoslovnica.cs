using System;
using System.Collections.Generic;

#nullable disable

namespace NaruciBa.Database
{
    public partial class KuponPoslovnica
    {
        public int KuponPoslovnicaID { get; set; }
        public int? KuponID { get; set; }
        public int? PoslovnicaID { get; set; }

        public virtual Kupon Kupon { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
    }
}

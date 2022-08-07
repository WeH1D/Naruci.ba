using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class KoordinatorInsertRequest
    {
        public DateTime? DatumZaposlenja { get; set; }
        public int? KorisnikID { get; set; }
    }
}

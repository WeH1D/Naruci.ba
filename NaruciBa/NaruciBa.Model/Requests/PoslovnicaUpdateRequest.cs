using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class PoslovnicaUpdateRequest
    {
        public string KontaktTel { get; set; }
        public string KontaktEmail { get; set; }
        public DateTime? DatumIzmjene { get; set; }
    }
}

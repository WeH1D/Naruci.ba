using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class DostavljacInsertRequest
    {
        public DateTime? DatumZaposlenja { get; set; }
        public int? DostavljacStatus { get; set; }
    }
}

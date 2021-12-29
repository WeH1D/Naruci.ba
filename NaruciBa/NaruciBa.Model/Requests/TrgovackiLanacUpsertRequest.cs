using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class TrgovackiLanacUpsertRequest
    {
        public string Naziv { get; set; }
        public byte[] ? Slika { get; set; }
    }
}

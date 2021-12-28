using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class PodkategorijaUpsertRequest
    {
        public string Naziv { get; set; }
        public int? KategorijaID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.SearchObjects
{
    public class PoslovnicaSearchObject
    {
        public int? GradID { get; set; }
        public int? TrgovackiLanacID { get; set; }
        public List<string> IncludeList { get; set; }
    }
}

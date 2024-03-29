﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NaruciBa.Model.Requests
{
    public class PoslovnicaInsertRequest
    {
        public string Adresa { get; set; }
        public int? GradID { get; set; }
        public string KontaktTel { get; set; }
        public string KontaktEmail { get; set; }
        public int? TrgovackiLanacID { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public DateTime? DatumIzmjene { get; set; }
    }
}

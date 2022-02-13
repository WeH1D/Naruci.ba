using AutoMapper;
using NaruciBa.Model;
using NaruciBa.Model.SearchObjects;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class TrgovackiLanacKategorijaService : BaseReadService<TrgovackiLanacKategorija, Database.TrgovackiLanacKategorija, TrgovackiLanacKategorijaSearchObject>, ITrgovackiLanacKategorijaService
    {
        public TrgovackiLanacKategorijaService(Database.NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

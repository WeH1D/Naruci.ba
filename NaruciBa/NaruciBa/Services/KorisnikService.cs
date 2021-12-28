using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class KorisnikService : BaseReadService<Model.Korisnik, Database.Korisnik>, IKorisnikService
    {
        public KorisnikService(NaruciBaContext context, IMapper mapper)
            :base(context, mapper)
        {

        }
    }
}

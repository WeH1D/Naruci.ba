using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class KategorijaService : BaseCRUDService<Model.Kategorija, Database.Kategorija, object, KategorijaUpsertRequest, KategorijaUpsertRequest>, IKategorijaService
    {
        public KategorijaService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }
    }
}

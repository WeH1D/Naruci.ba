using AutoMapper;
using NaruciBa.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class DostavljacService : BaseCRUDService<Model.Dostavljac, Database.Dostavljac, object, Model.Requests.DostavljacUpsertRequest, Model.Requests.DostavljacUpsertRequest>, Interfaces.IDostavljacService
    {
        public DostavljacService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

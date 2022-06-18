using AutoMapper;
using NaruciBa.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class DostavljacStatusService : BaseCRUDService<Model.DostavljacStatus, Database.DostavljacStatus, object, Model.Requests.DostavljacStatusUpsertRequest, Model.Requests.DostavljacStatusUpsertRequest>, Interfaces.IDostavljacStatus
    {
        public DostavljacStatusService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

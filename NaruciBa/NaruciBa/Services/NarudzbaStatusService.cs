using AutoMapper;
using NaruciBa.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class NarudzbaStatusService : BaseCRUDService<Model.NarudzbaStatus, Database.NarudzbaStatus, Model.SearchObjects.NarudzbaStatusSearchObject, Model.Requests.NarudzbaStatusUpsertRequest, Model.Requests.NarudzbaStatusUpsertRequest>, Interfaces.INarudzbaStatusService
    {
        public NarudzbaStatusService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

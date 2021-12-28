using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class PodkategorijaService: BaseReadService<Model.Podkategorija, Database.Podkategorija>, IPodkategorijaService
    {
        public PodkategorijaService(NaruciBaContext context, IMapper mapper)
           : base(context, mapper)
        {
        }
    }
}

using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class GradService : BaseReadService<Model.Grad, Database.Grad, object>, IGradService
    {
        public GradService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }
    }
}

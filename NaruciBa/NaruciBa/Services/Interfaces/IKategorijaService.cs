using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaruciBa.Model.Requests;

namespace NaruciBa.Services.Interfaces
{
    public interface IKategorijaService : ICRUDService<Model.Kategorija, object, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
    }
}

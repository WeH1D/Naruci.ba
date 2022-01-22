using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaruciBa.Model.Requests;
using NaruciBa.Model.SearchObjects;

namespace NaruciBa.Services.Interfaces
{
    public interface IKategorijaService : ICRUDService<Model.Kategorija, object, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        public Task<List<Model.Kategorija>> getKategorijeFromProizvodiList(KategorijaSearchObject search);
    }
}

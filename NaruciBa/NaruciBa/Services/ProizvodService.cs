using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using NaruciBa.Model.SearchObjects;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class ProizvodService : BaseCRUDService<Model.Proizvod, Database.Proizvod, ProizvodSearchObject, ProizvodInsertRequest, ProizvodUpdateRequest>, IProizvodService
    {
        public ProizvodService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Proizvod> Get(ProizvodSearchObject search = null)
        {
            var entity = Context.Set<Database.Proizvod>().AsQueryable();
            if(!string.IsNullOrEmpty(search.Naziv))
            {
                entity = entity.Where(a => a.Naziv.Contains(search.Naziv));
            }
            if (!string.IsNullOrEmpty(search.Sifra))
            {
                entity = entity.Where(a => a.Sifra.Contains(search.Sifra));
            }
            if(search.PoslovnicaID.HasValue)
            {
                entity = entity.Where(a => a.PoslovnicaID == search.PoslovnicaID);
            }
            if(search.PodkategorijaID.HasValue)
            {
                entity = entity.Where(a => a.PodkategorijaID == search.PodkategorijaID);
            }
            if(search.KategorijaID.HasValue)
            {
                entity = entity.Include(a => a.Podkategorija).Where(a => a.Podkategorija.KategorijaID == search.KategorijaID);
            }
            var list = entity.ToList();
            return _mapper.Map<List<Model.Proizvod>>(list);
        }
    }
}

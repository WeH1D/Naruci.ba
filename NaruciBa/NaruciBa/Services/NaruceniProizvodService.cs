using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class NaruceniProizvodService : BaseCRUDService<Model.NaruceniProizvod, Database.NaruceniProizvod, Model.SearchObjects.NaruceniPorizvodSearchObject, Model.Requests.NaruceniProizvodUpsertRequest, Model.Requests.NaruceniProizvodUpsertRequest>, Interfaces.INaruceniProizvod
    {
        public NaruceniProizvodService(NaruciBaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async override Task<Model.NaruceniProizvod> Insert(NaruceniProizvodUpsertRequest request)
        {
            var prod = await base.Insert(request);
            await updateUkupnaCijenaNarudzbeAsync(prod.NarudzbaID);
            return prod;
        }

        public async override Task<Model.NaruceniProizvod> Update(int id, NaruceniProizvodUpsertRequest request)
        {
            var prod = await base.Update(id, request);
            await updateUkupnaCijenaNarudzbeAsync(prod.NarudzbaID);
            return prod;
        }

        public async override Task<Model.NaruceniProizvod> Delete(int id)
        {
            var prod = await base.Delete(id);
            await updateUkupnaCijenaNarudzbeAsync(prod.NarudzbaID);
            return prod;
        }

        public async override Task<IEnumerable<Model.NaruceniProizvod>> Get(Model.SearchObjects.NaruceniPorizvodSearchObject search = null)
        {

            var entity = Context.Set<Database.NaruceniProizvod>().AsQueryable();
            if (search.NarudzbaID.HasValue)
            {
                entity = entity.Where(a => a.NarudzbaID == search.NarudzbaID);
            }
       
            var list = await entity.ToListAsync();
            return _mapper.Map<List<Model.NaruceniProizvod>>(list);
        }
        public async Task updateUkupnaCijenaNarudzbeAsync(int? narudzbaId)
        {
            if(narudzbaId != null)
            {
                var narudzba = Context.Narudzbas.Find(narudzbaId);
                var proizvodiUNarudzbi = Context.NaruceniProizvods.Where(a => a.NarudzbaID == narudzbaId);
                narudzba.UkupanIznos = 0;
                foreach (var prod in proizvodiUNarudzbi)
                {
                    narudzba.UkupanIznos += prod.UkupnaCijena;
                }
                await Context.SaveChangesAsync();
            }
        }
    }
}

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using NaruciBa.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services
{
    public class TrgovackiLanacService : BaseCRUDService<Model.TrgovackiLanac, Database.TrgovackiLanac, object, TrgovackiLanacUpsertRequest, TrgovackiLanacUpsertRequest>, ITrgovackiLanacService
    {
        public ImageHelper imageHelper = new ImageHelper();
        public TrgovackiLanacService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<Model.TrgovackiLanac> Insert(TrgovackiLanacUpsertRequest request)
        {
            var entity = _mapper.Map<Database.TrgovackiLanac>(request);
            await Context.TrgovackiLanacs.AddAsync(entity);
            await Context.SaveChangesAsync();

            entity.SlikaPutanja = await imageHelper.InsertImage("TrgovackiLanac", entity.TrgovackiLanacID, request.SlikaPutanja, request.Slika);
            await Context.SaveChangesAsync();

            return _mapper.Map<Model.TrgovackiLanac>(entity);
        }

        public async override Task<IEnumerable<Model.TrgovackiLanac>> Get(object search = null)
        {
            var entity = Context.Set<Database.TrgovackiLanac>();

            var list = await entity.ToListAsync();
            var result = _mapper.Map<List<Model.TrgovackiLanac>>(list);

            foreach (var item in result)
            {
                var directory = Path.Combine(Directory.GetCurrentDirectory(), "Images", "TrgovackiLanac", $"{item.SlikaPutanja}");
                item.Slika = await imageHelper.FindImage(directory);
            }

            return result;
        }

        public async override Task<Model.TrgovackiLanac> GetById(int id)
        {
            var entity = await Context.TrgovackiLanacs.FindAsync(id);

            var result = _mapper.Map<Model.TrgovackiLanac>(entity);

            var directory = Path.Combine(Directory.GetCurrentDirectory(), "Images", "TrgovackiLanac", $"{result.SlikaPutanja}");
            result.Slika = await imageHelper.FindImage(directory);

            return result;
        }
    }
}

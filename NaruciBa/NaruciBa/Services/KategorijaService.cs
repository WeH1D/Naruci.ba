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
    public class KategorijaService : BaseCRUDService<Model.Kategorija, Database.Kategorija, object, KategorijaUpsertRequest, KategorijaUpsertRequest>, IKategorijaService
    {
        public KategorijaService(NaruciBaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async Task<List<Model.Kategorija>> getKategorijeFromProizvodiList(KategorijaSearchObject search) {
            if (search.proizvodiID.Any())
            {
                List<Model.Kategorija> kategorije = new List<Model.Kategorija>();
                foreach (var proizvodID in search.proizvodiID)
                {
                    var dbProizvod = await Context.Proizvods
                        .Include(a => a.Podkategorija)
                        .Include(a => a.Podkategorija.Kategorija)
                        .Where(a => a.ProizvodID == proizvodID)
                        .FirstOrDefaultAsync();
                    if(dbProizvod != null)
                    {
                        var dbKategorija = dbProizvod.Podkategorija.Kategorija;
                        kategorije.Add(_mapper.Map<Model.Kategorija>(dbKategorija));
                    }

                }
                kategorije = kategorije.Distinct().ToList();
                return kategorije;
            }
            throw new Exception("Invalid request, proizvodiID list is empty.");
        }
    }
}

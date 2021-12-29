using AutoMapper;
using NaruciBa.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Mapping
{
    public class NaruciBaProfile : Profile
    {
        public NaruciBaProfile()
        {
            CreateMap<Database.Korisnik, Model.Korisnik>();

            CreateMap<Database.Podkategorija, Model.Podkategorija>();
            CreateMap<PodkategorijaUpsertRequest, Database.Podkategorija>();

            CreateMap<Database.Kategorija, Model.Kategorija>();
            CreateMap<KategorijaUpsertRequest, Database.Kategorija>();

            CreateMap<Database.TrgovackiLanac, Model.TrgovackiLanac>();
            CreateMap<TrgovackiLanacUpsertRequest, Database.TrgovackiLanac>();

            CreateMap<Database.Poslovnica, Model.Poslovnica>();
            CreateMap<PoslovnicaInsertRequest, Database.Poslovnica>();
            CreateMap<PoslovnicaUpdateRequest, Database.Poslovnica>();

            CreateMap<Database.Proizvod, Model.Proizvod>();
            CreateMap<ProizvodInsertRequest, Database.Proizvod>();
            CreateMap<ProizvodUpdateRequest, Database.Proizvod>();

            CreateMap<Database.Grad, Model.Grad>();

        }
    }
}

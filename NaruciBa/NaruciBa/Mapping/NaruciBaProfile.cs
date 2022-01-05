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
            CreateMap<Database.Korisnik, Model.Korisnik>().ReverseMap();

            CreateMap<Database.Podkategorija, Model.Podkategorija>().ReverseMap();
            CreateMap<PodkategorijaUpsertRequest, Database.Podkategorija>();

            CreateMap<Database.Kategorija, Model.Kategorija>().ReverseMap();
            CreateMap<KategorijaUpsertRequest, Database.Kategorija>();

            CreateMap<Database.TrgovackiLanac, Model.TrgovackiLanac>().ReverseMap();
            CreateMap<TrgovackiLanacUpsertRequest, Database.TrgovackiLanac>();

            CreateMap<Database.Poslovnica, Model.Poslovnica>().ReverseMap();
            CreateMap<PoslovnicaInsertRequest, Database.Poslovnica>();
            CreateMap<PoslovnicaUpdateRequest, Database.Poslovnica>();

            CreateMap<Database.Proizvod, Model.Proizvod>().ReverseMap();
            CreateMap<ProizvodInsertRequest, Database.Proizvod>();
            CreateMap<ProizvodUpdateRequest, Database.Proizvod>();

            CreateMap<Database.Korisnik, Model.Korisnik>().ReverseMap();
            CreateMap<KorisnikInsertRequest, Database.Korisnik>();

            CreateMap<Database.Grad, Model.Grad>().ReverseMap();

        }
    }
}

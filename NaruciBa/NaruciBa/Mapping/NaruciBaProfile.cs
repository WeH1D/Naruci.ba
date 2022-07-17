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
            CreateMap<PoslovnicaUpdateRequest, Database.Poslovnica>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null)); ;

            CreateMap<Database.Proizvod, Model.Proizvod>().ReverseMap();
            CreateMap<ProizvodInsertRequest, Database.Proizvod>();
            CreateMap<ProizvodUpdateRequest, Database.Proizvod>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null)); ;

            CreateMap<Database.Korisnik, Model.Korisnik>().ReverseMap();
            CreateMap<KorisnikInsertRequest, Database.Korisnik>();

            CreateMap<Database.Grad, Model.Grad>().ReverseMap();

            CreateMap<Database.PoslovnicaKategorija, Model.PoslovnicaKategorija>().ReverseMap();

            CreateMap<Database.Narudzba, Model.Narudzba>().ReverseMap();
            CreateMap<NarudzbaUpsertRequest, Database.Narudzba>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null)); ;

            CreateMap<Database.NarudzbaStatus, Model.NarudzbaStatus>().ReverseMap();
            CreateMap<NarudzbaStatusUpsertRequest, Database.NarudzbaStatus>();

            CreateMap<Database.NaruceniProizvod, Model.NaruceniProizvod>().ReverseMap();
            CreateMap<NaruceniProizvodUpsertRequest, Database.NaruceniProizvod>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null)); ;

            CreateMap<Database.Klijent, Model.Klijent>().ReverseMap();

            CreateMap<Database.Dostavljac, Model.Dostavljac>().ReverseMap();
            CreateMap<DostavljacUpsertRequest, Database.Dostavljac>().ReverseMap();

            CreateMap<Database.DostavljacStatus, Model.DostavljacStatus>().ReverseMap();
            CreateMap<DostavljacStatusUpsertRequest, Database.DostavljacStatus>();


        }
    }
}

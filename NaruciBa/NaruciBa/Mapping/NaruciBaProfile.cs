using AutoMapper;
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
        }
    }
}

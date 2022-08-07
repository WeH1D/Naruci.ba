using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Services.Interfaces
{
    public interface IKorisnikService : ICRUDService<Model.Korisnik, Model.SearchObjects.KorisnikSearchObject, KorisnikInsertRequest, KorisnikInsertRequest>
    {
    }
}

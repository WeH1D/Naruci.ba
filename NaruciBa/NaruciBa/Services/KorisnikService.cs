using AutoMapper;
using NaruciBa.Database;
using NaruciBa.Model.Requests;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace NaruciBa.Services
{
    public class KorisnikService : BaseCRUDService<Model.Korisnik, Database.Korisnik, object, KorisnikInsertRequest, object>, IKorisnikService
    {
        public KorisnikService(NaruciBaContext context, IMapper mapper)
            :base(context, mapper)
        {

        }

        public override Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            if(Context.Korisniks.Where(a => a.Email == request.Email).Any())
            {
                throw new Exception("Korisnik sa istim emailom vec postoji");
            }

            var salt = GenerateSalt();
            var hash = GenerateHash(salt, request.Password);

            Database.Korisnik korisnik = _mapper.Map<Database.Korisnik>(request);

            korisnik.PasswordHash = hash;
            korisnik.PasswordSalt = salt;
            korisnik.DatumKreiranja = DateTime.Now;
            korisnik.DatumIzmjene = DateTime.Now;

            Context.Korisniks.Add(korisnik);
            Context.SaveChanges();

            if (request.dostavljacInsert != null)
            {
                Database.Dostavljac dostavljac = new Dostavljac()
                {
                    KorisnikID = korisnik.KorisnikID,
                    DatumZaposlenja = request.dostavljacInsert.DatumZaposlenja,
                    DostavljacStatus = request.dostavljacInsert.DostavljacStatus

                };
                Context.Dostavljacs.Add(dostavljac);
            }
            else if (request.koordinatorInsert != null)
            {
                Database.Koordinator koordinator = new Koordinator()
                {
                    KorisnikID = korisnik.KorisnikID,
                    DatumZaposlenja = request.koordinatorInsert.DatumZaposlenja

                };
                Context.Koordinators.Add(koordinator);
            }
            else
            {
                Database.Klijent klijent = new Klijent()
                {
                    KorisnikID = korisnik.KorisnikID,
                };
                Context.Klijents.Add(klijent);
            }

            Context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(korisnik);
        }


        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }
    }
}

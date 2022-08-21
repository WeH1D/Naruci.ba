using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa.Database
{
    public partial class NaruciBaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 2,
                Ime = "desktop",
                Prezime = "admin",
                Adresa = "Adresa admina 24",
                Email = "desktop@gmail.com",
                Telefon = "06411123233",
                DatumRodenja = DateTime.Now,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now,
                PasswordHash = "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=",
                PasswordSalt = "p9av83cBc37tVxOqcJlaPA==",
                GradID = 1
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 1003,
                Ime = "mobile",
                Prezime = "test",
                Adresa = "Adresa mobile 23 L",
                Email = "mobile@gmail.com",
                Telefon = "064166323233",
                DatumRodenja = DateTime.Now,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now,
                PasswordHash = "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=",
                PasswordSalt = "p9av83cBc37tVxOqcJlaPA==",
                GradID = 1
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 1007,
                Ime = "Velid",
                Prezime = "Hatic",
                Adresa = "Neka Adresa",
                Email = "velid@gmail.com",
                Telefon = "06234344455",
                DatumRodenja = DateTime.Now,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now,
                PasswordHash = "dX4PhU98Jw/EfxV3XgaPJq0paX8=",
                PasswordSalt = "BehlC7xXAX9C1z5zPdFzGg==",
                GradID = 1
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 1012,
                Ime = "Emir",
                Prezime = "Hodzic",
                Adresa = "Prva ulica 42",
                Email = "emir@gmail.com",
                Telefon = "06234344455",
                DatumRodenja = DateTime.Now,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now,
                PasswordHash = "+9yvonO1LEAd2j5PcQ4rlx04EKA=",
                PasswordSalt = "nq+mmwzWQEmtnVQLQwFwIQ==",
                GradID = 1
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 1013,
                Ime = "Ahmo",
                Prezime = "Ahmic",
                Adresa = "Druga ulica 12",
                Email = "ahmo@gmail.com",
                Telefon = "0623554555",
                DatumRodenja = DateTime.Now,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now,
                PasswordHash = "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=",
                PasswordSalt = "p9av83cBc37tVxOqcJlaPA==",
                GradID = 1
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 1014,
                Ime = "Haso",
                Prezime = "Hasanovic",
                Adresa = "Treca ulica 2",
                Email = "haso@gmail.com",
                Telefon = "0623554555",
                DatumRodenja = DateTime.Now,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now,
                PasswordHash = "IJJHgLDhwaX399tMxsqh/bQ7SjM=",
                PasswordSalt = "caGo+QqT++vaqQFQrhE2eA==",
                GradID = 1
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 1015,
                Ime = "Dostavljac",
                Prezime = "Test",
                Adresa = "Cetvrta ulica 23",
                Email = "dostavljac@gmail.com",
                Telefon = "0623554555",
                DatumRodenja = DateTime.Now,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now,
                PasswordHash = "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=",
                PasswordSalt = "p9av83cBc37tVxOqcJlaPA==",
                GradID = 1
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 1016,
                Ime = "Ajdin",
                Prezime = "Ajdinovic",
                Adresa = "Peta ulica 23",
                Email = "ajdin@gmail.com",
                Telefon = "0623554555",
                DatumRodenja = DateTime.Now,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now,
                PasswordHash = "KollFEuC5A6+fRdbD7iF4UeSNBM=",
                PasswordSalt = "JQS8wY5Hq1Jf7IFACDkYmQ==",
                GradID = 1
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik()
            {
                KorisnikID = 2016,
                Ime = "Bekir",
                Prezime = "Becirovic",
                Adresa = "Sesta ulica 35",
                Email = "bekir@gmail.com",
                Telefon = "0623554555",
                DatumRodenja = DateTime.Now,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now,
                PasswordHash = "m4SNoQUsSWimY2iEcmlcH4JX3nw=",
                PasswordSalt = "sad/ufjxSKTwXWAq1kUISw==",
                GradID = 3
            });

            modelBuilder.Entity<Koordinator>().HasData(new Koordinator()
            {
                KorisnikID = 2,
                KoordinatorID = 1,
                DatumZaposlenja = DateTime.Now,
            });

            modelBuilder.Entity<Klijent>().HasData(new Klijent()
            {
                KlijentID = 1,
                KorisnikID = 2
            });
            modelBuilder.Entity<Klijent>().HasData(new Klijent()
            {
                KlijentID = 2,
                KorisnikID = 1003
            });
            modelBuilder.Entity<Klijent>().HasData(new Klijent()
            {
                KlijentID = 6,
                KorisnikID = 1007
            });
            modelBuilder.Entity<Klijent>().HasData(new Klijent()
            {
                KlijentID = 11,
                KorisnikID = 1012
            });
            modelBuilder.Entity<Klijent>().HasData(new Klijent()
            {
                KlijentID = 12,
                KorisnikID = 1016
            });

            modelBuilder.Entity<Dostavljac>().HasData(new Dostavljac()
            {
                DostavljacID = 1,
                KorisnikID = 1013,
                DatumZaposlenja = DateTime.Now,
                DostavljacStatus = 1
            });
            modelBuilder.Entity<Dostavljac>().HasData(new Dostavljac()
            {
                DostavljacID = 2,
                KorisnikID = 1014,
                DatumZaposlenja = DateTime.Now,
                DostavljacStatus = 1
            });
            modelBuilder.Entity<Dostavljac>().HasData(new Dostavljac()
            {
                DostavljacID = 3,
                KorisnikID = 1015,
                DatumZaposlenja = DateTime.Now,
                DostavljacStatus = 2
            });
            modelBuilder.Entity<Dostavljac>().HasData(new Dostavljac()
            {
                DostavljacID = 4,
                KorisnikID = 2016,
                DatumZaposlenja = DateTime.Now,
                DostavljacStatus = 1
            });

            modelBuilder.Entity<DostavljacStatus>().HasData(new DostavljacStatus()
            {
                DostavljacStatusID = 1,
                Naziv = "slobodan"
            });
            modelBuilder.Entity<DostavljacStatus>().HasData(new DostavljacStatus()
            {
                DostavljacStatusID = 2,
                Naziv = "u narudzbi"
            });
            modelBuilder.Entity<DostavljacStatus>().HasData(new DostavljacStatus()
            {
                DostavljacStatusID = 3,
                Naziv = "neaktivan"
            });

            modelBuilder.Entity<Grad>().HasData(new Grad()
            {
                GradID = 1,
                Naziv = "Tuzla"
            });
            modelBuilder.Entity<Grad>().HasData(new Grad()
            {
                GradID = 2,
                Naziv = "Sarajevo"
            });
            modelBuilder.Entity<Grad>().HasData(new Grad()
            {
                GradID = 3,
                Naziv = "Mostar"
            });
            modelBuilder.Entity<Grad>().HasData(new Grad()
            {
                GradID = 4,
                Naziv = "Banja Luka"
            });
            modelBuilder.Entity<Grad>().HasData(new Grad()
            {
                GradID = 5,
                Naziv = "Zenica"
            });
            modelBuilder.Entity<Grad>().HasData(new Grad()
            {
                GradID = 6,
                Naziv = "Zavidovici"
            });

            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 15,
                Naziv = "Hrana i Pice"
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 16,
                Naziv = "Higijena"
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 17,
                Naziv = "Elektronika"
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 18,
                Naziv = "Kucni Ljubimci"
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 19,
                Naziv = "Bebe"
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 20,
                Naziv = "Skola"
            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 21,
                Naziv = "Vozila"
            });

            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 1029,
                ProizvodID = 12,
                NarudzbaID = 14,
                Kolicina = (decimal?)3.00,
                UkupnaCijena = (decimal?)6.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 1030,
                ProizvodID = 13,
                NarudzbaID = 15,
                Kolicina = (decimal?)1.00,
                UkupnaCijena = (decimal?)3.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 1031,
                ProizvodID = 11,
                NarudzbaID = 16,
                Kolicina = (decimal?)3.00,
                UkupnaCijena = (decimal?)6.9
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 1032,
                ProizvodID = 13,
                NarudzbaID = 17,
                Kolicina = (decimal?)3.00,
                UkupnaCijena = (decimal?)9.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 1033,
                ProizvodID = 11,
                NarudzbaID = 19,
                Kolicina = (decimal?)1.00,
                UkupnaCijena = (decimal?)2.30
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 1035,
                ProizvodID = 1011,
                NarudzbaID = 19,
                Kolicina = (decimal?)4.00,
                UkupnaCijena = (decimal?)14.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 1036,
                ProizvodID = 13,
                NarudzbaID = 20,
                Kolicina = (decimal?)2.00,
                UkupnaCijena = (decimal?)6.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 1037,
                ProizvodID = 13,
                NarudzbaID = 21,
                Kolicina = (decimal?)4.00,
                UkupnaCijena = (decimal?)12.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 2033,
                ProizvodID = 11,
                NarudzbaID = 1019,
                Kolicina = (decimal?)3.00,
                UkupnaCijena = (decimal?)6.90
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 2034,
                ProizvodID = 12,
                NarudzbaID = 1019,
                Kolicina = (decimal?)2.00,
                UkupnaCijena = (decimal?)4.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 2035,
                ProizvodID = 11,
                NarudzbaID = 1021,
                Kolicina = (decimal?)5.00,
                UkupnaCijena = (decimal?)11.50
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 3033,
                ProizvodID = 11,
                NarudzbaID = 2020,
                Kolicina = (decimal?)2.00,
                UkupnaCijena = (decimal?)4.60
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 3034,
                ProizvodID = 12,
                NarudzbaID = 2021,
                Kolicina = (decimal?)3.00,
                UkupnaCijena = (decimal?)6.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 3035,
                ProizvodID = 12,
                NarudzbaID = 2022,
                Kolicina = (decimal?)2.00,
                UkupnaCijena = (decimal?)4.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 4033,
                ProizvodID = 11,
                NarudzbaID = 3020,
                Kolicina = (decimal?)4.00,
                UkupnaCijena = (decimal?)9.20
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 4034,
                ProizvodID = 13,
                NarudzbaID = 3021,
                Kolicina = (decimal?)2.00,
                UkupnaCijena = (decimal?)6.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 4035,
                ProizvodID = 11,
                NarudzbaID = 3022,
                Kolicina = (decimal?)3.00,
                UkupnaCijena = (decimal?)6.90
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 4036,
                ProizvodID = 12,
                NarudzbaID = 3023,
                Kolicina = (decimal?)5.00,
                UkupnaCijena = (decimal?)10.00
            });
            modelBuilder.Entity<NaruceniProizvod>().HasData(new NaruceniProizvod()
            {
                NaruceniProizvodID = 4037,
                ProizvodID = 11,
                NarudzbaID = 3023,
                Kolicina = (decimal?)2.00,
                UkupnaCijena = (decimal?)4.60
            });

            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus()
            {
                NarudzbaStatusID = 1,
                Naziv = "Zapoceta"
            });
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus()
            {
                NarudzbaStatusID = 2,
                Naziv = "Aktivna"
            });
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus()
            {
                NarudzbaStatusID = 3,
                Naziv = "Zaprimljena"
            });
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus()
            {
                NarudzbaStatusID = 4,
                Naziv = "U kupovini"
            });
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus()
            {
                NarudzbaStatusID = 5,
                Naziv = "Dostava"
            });
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus()
            {
                NarudzbaStatusID = 6,
                Naziv = "Zavrsena"
            });
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus()
            {
                NarudzbaStatusID = 7,
                Naziv = "Otkazana"
            });

            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 1,
                KlijentID = 2,
                DostavljacID = 2,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)16.60,
                NarudzbaStatusID = 7
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 6,
                KlijentID = 11,
                DostavljacID = 1,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)12.05,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 9,
                KlijentID = 2,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)9.75,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 8,
                KlijentID = 2,
                DostavljacID = 3,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)16.60,
                NarudzbaStatusID = 7
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 10,
                KlijentID = 2,
                DostavljacID = 1,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)4.60,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 11,
                KlijentID = 2,
                DostavljacID = 1,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)2.30,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 12,
                KlijentID = 2,
                DostavljacID = 1,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)18.32,
                SlikaRacunaPutanja = "narudzba_12.jpg",
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 13,
                KlijentID = 2,
                DostavljacID = 2,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)11.25,
                SlikaRacunaPutanja = "narudzba_13.jpg",
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 14,
                KlijentID = 2,
                DostavljacID = 4,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)6.0,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 15,
                KlijentID = 2,
                DostavljacID = 3,
                PoslovnicaID = 2,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)3.00,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 16,
                KlijentID = 2,
                DostavljacID = 3,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)6.90,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 17,
                KlijentID = 2,
                DostavljacID = 3,
                PoslovnicaID = 2,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)9.00,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 19,
                KlijentID = 12,
                DostavljacID = 1,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)16.30,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 20,
                KlijentID = 12,
                DostavljacID = 1,
                PoslovnicaID = 2,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)6.00,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 21,
                KlijentID = 12,
                DostavljacID = 1,
                PoslovnicaID = 2,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)12.00,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 1019,
                KlijentID = 12,
                DostavljacID = 4,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)10.90,
                NarudzbaStatusID = 6
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 1021,
                KlijentID = 12,
                DostavljacID = 3,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)11.50,
                SlikaRacunaPutanja = "narudzba_1021.jpg",
                NarudzbaStatusID = 3
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 2020,
                KlijentID = 12,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)4.60,
                NarudzbaStatusID = 2
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 2021,
                KlijentID = 12,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)6.00,
                NarudzbaStatusID = 2
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 2022,
                KlijentID = 12,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)4.00,
                NarudzbaStatusID = 2
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 3020,
                KlijentID = 12,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)9.20,
                NarudzbaStatusID = 2
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 3021,
                KlijentID = 12,
                PoslovnicaID = 2,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)6.00,
                NarudzbaStatusID = 2
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 3022,
                KlijentID = 12,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)6.90,
                NarudzbaStatusID = 2
            });
            modelBuilder.Entity<Narudzba>().HasData(new Narudzba()
            {
                NarudzbaID = 3023,
                KlijentID = 2,
                PoslovnicaID = 1,
                Datum = DateTime.Now,
                UkupanIznos = (decimal?)14.60,
                NarudzbaStatusID = 1
            });

            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 38,
                Naziv = "Voce",
                KategorijaID = 15
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 39,
                Naziv = "Povrce",
                KategorijaID = 15
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 40,
                Naziv = "Mesni Proizvodi",
                KategorijaID = 15
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 41,
                Naziv = "Mlijecni Proizvodi",
                KategorijaID = 15
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 42,
                Naziv = "Zacini",
                KategorijaID = 15
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 43,
                Naziv = "Samponi/sapuni",
                KategorijaID = 16
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 44,
                Naziv = "Zubi",
                KategorijaID = 16
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 50,
                Naziv = "Ruksaci/torbe",
                KategorijaID = 20
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 52,
                Naziv = "Pribor",
                KategorijaID = 20
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 53,
                Naziv = "Knjige",
                KategorijaID = 20
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 54,
                Naziv = "Pokloni",
                KategorijaID = 20
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 55,
                Naziv = "Hrana za ljubimce",
                KategorijaID = 18
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 56,
                Naziv = "Igracke za ljubimce",
                KategorijaID = 18
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 57,
                Naziv = "Higijena ljubimaca",
                KategorijaID = 18
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 58,
                Naziv = "Ljubimci ostalo",
                KategorijaID = 18
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 59,
                Naziv = "Igracke za bebe",
                KategorijaID = 19
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 60,
                Naziv = "Hrana za bebe",
                KategorijaID = 19
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 61,
                Naziv = "Higijena za bebe",
                KategorijaID = 19
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 62,
                Naziv = "Pohrana podataka",
                KategorijaID = 17
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 63,
                Naziv = "Kompjuterska oprema",
                KategorijaID = 17
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 64,
                Naziv = "Laptopi",
                KategorijaID = 17
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 65,
                Naziv = "Mobiteli",
                KategorijaID = 17
            });
            modelBuilder.Entity<Podkategorija>().HasData(new Podkategorija()
            {
                PodkategorijaID = 66,
                Naziv = "Mirisi",
                KategorijaID = 16
            });

            modelBuilder.Entity<Poslovnica>().HasData(new Poslovnica()
            {
                PoslovnicaID = 1,
                Adresa = "Mitra Trifunovica",
                GradID = 1,
                KontaktTel = "035288699",
                Status = true,
                KontaktEmail = "managmentbcctuzla@confluence.ba",
                TrgovackiLanacID = 1,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now
            });
            modelBuilder.Entity<Poslovnica>().HasData(new Poslovnica()
            {
                PoslovnicaID = 2,
                Adresa = "Ismeta Mujezinovica D9",
                GradID = 1,
                KontaktTel = "035365580",
                Status = true,
                KontaktEmail = "bingoSjenjak@gmail.com",
                TrgovackiLanacID = 1,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now
            });
            modelBuilder.Entity<Poslovnica>().HasData(new Poslovnica()
            {
                PoslovnicaID = 3,
                Adresa = "Bulevar 2. Armije BiH 1",
                GradID = 1,
                KontaktTel = "00023233344",
                Status = true,
                KontaktEmail = "konzum@gmail.com",
                TrgovackiLanacID = 2,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now
            });
            modelBuilder.Entity<Poslovnica>().HasData(new Poslovnica()
            {
                PoslovnicaID = 4,
                Adresa = "Stupine B-14",
                GradID = 1,
                KontaktTel = "0643536266",
                Status = true,
                KontaktEmail = "genelecTuzla@gmail.com",
                TrgovackiLanacID = 3,
                DatumKreiranja = DateTime.Now,
                DatumIzmjene = DateTime.Now
            });

            modelBuilder.Entity<PoslovnicaKategorija>().HasData(new PoslovnicaKategorija()
            {
                PoslovnicaKategorijaID = 6,
                PoslovnicaID = 1,
                KategorijaID = 15
            });
            modelBuilder.Entity<PoslovnicaKategorija>().HasData(new PoslovnicaKategorija()
            {
                PoslovnicaKategorijaID = 7,
                PoslovnicaID = 2,
                KategorijaID = 16
            });
            modelBuilder.Entity<PoslovnicaKategorija>().HasData(new PoslovnicaKategorija()
            {
                PoslovnicaKategorijaID = 1006,
                PoslovnicaID = 1,
                KategorijaID = 16
            });
            modelBuilder.Entity<PoslovnicaKategorija>().HasData(new PoslovnicaKategorija()
            {
                PoslovnicaKategorijaID = 1007,
                PoslovnicaID = 3,
                KategorijaID = 15
            });
            modelBuilder.Entity<PoslovnicaKategorija>().HasData(new PoslovnicaKategorija()
            {
                PoslovnicaKategorijaID = 1008,
                PoslovnicaID = 3,
                KategorijaID = 16
            });
            modelBuilder.Entity<PoslovnicaKategorija>().HasData(new PoslovnicaKategorija()
            {
                PoslovnicaKategorijaID = 1009,
                PoslovnicaID = 3,
                KategorijaID = 19
            });
            modelBuilder.Entity<PoslovnicaKategorija>().HasData(new PoslovnicaKategorija()
            {
                PoslovnicaKategorijaID = 1010,
                PoslovnicaID = 2,
                KategorijaID = 15
            });
            modelBuilder.Entity<PoslovnicaKategorija>().HasData(new PoslovnicaKategorija()
            {
                PoslovnicaKategorijaID = 1011,
                PoslovnicaID = 2,
                KategorijaID = 18
            });
            modelBuilder.Entity<PoslovnicaKategorija>().HasData(new PoslovnicaKategorija()
            {
                PoslovnicaKategorijaID = 1012,
                PoslovnicaID = 4,
                KategorijaID = 17
            });

            modelBuilder.Entity<TrgovackiLanac>().HasData(new TrgovackiLanac()
            {
                TrgovackiLanacID = 1,
                Naziv = "Bingo",
                SlikaPutanja = "trgovackilanac_1.jpg"
            });
            modelBuilder.Entity<TrgovackiLanac>().HasData(new TrgovackiLanac()
            {
                TrgovackiLanacID = 2,
                Naziv = "Konzum",
                SlikaPutanja = "trgovackilanac_2.jpg"
            });
            modelBuilder.Entity<TrgovackiLanac>().HasData(new TrgovackiLanac()
            {
                TrgovackiLanacID = 3,
                Naziv = "Genelec",
                SlikaPutanja = "trgovackilanac_3.jpg"
            });

            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 11,
                Sifra = "0000",
                Naziv = "Jabuka",
                Opis = "Svjeza jabuka",
                Cijena = (decimal?)2.30,
                Kg = true,
                PodkategorijaID = 38,
                PoslovnicaID = 1,
                Status = true,
                SlikaPutanja = "proizvod_11.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 12,
                Sifra = "0001",
                Naziv = "Banana",
                Opis = "Svjeza banana",
                Cijena = (decimal?)2.00,
                Kg = true,
                PodkategorijaID = 38,
                PoslovnicaID = 1,
                Status = true,
                SlikaPutanja = "proizvod_12.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 13,
                Sifra = "0023",
                Naziv = "Head & Shoulders",
                Opis = "sampon protiv peruti",
                Cijena = (decimal?)3.00,
                Kg = false,
                PodkategorijaID = 43,
                PoslovnicaID = 2,
                Status = true,
                SlikaPutanja = "proizvod_13.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1011,
                Sifra = "0004",
                Naziv = "Sampon",
                Opis = "sampon protiv peruti",
                Cijena = (decimal?)3.50,
                Kg = false,
                PodkategorijaID = 43,
                PoslovnicaID = 1,
                Status = true,
                SlikaPutanja = "proizvod_13.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1012,
                Sifra = "0034",
                Naziv = "Paradajz",
                Opis = "Paradajz",
                Cijena = (decimal?)2.00,
                Kg = true,
                PodkategorijaID = 39,
                PoslovnicaID = 1,
                Status = true,
                SlikaPutanja = "proizvod_1012.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1013,
                Sifra = "0064",
                Naziv = "Ananas",
                Opis = "Svjezi ananas",
                Cijena = (decimal?)4.50,
                Kg = true,
                PodkategorijaID = 38,
                PoslovnicaID = 1,
                Status = true,
                SlikaPutanja = "proizvod_1013.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1014,
                Sifra = "23455",
                Naziv = "Jabuka",
                Opis = "Svjeza crvena jabuka",
                Cijena = (decimal?)1.20,
                Kg = true,
                PodkategorijaID = 38,
                PoslovnicaID = 3,
                Status = true,
                SlikaPutanja = "proizvod_1014.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1015,
                Sifra = "3436",
                Naziv = "Banana",
                Opis = "Svjeza banana",
                Cijena = (decimal?)2.30,
                Kg = true,
                PodkategorijaID = 38,
                PoslovnicaID = 3,
                Status = true,
                SlikaPutanja = "proizvod_1015.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1016,
                Sifra = "56773",
                Naziv = "Narandza",
                Opis = "Svjeza narandza",
                Cijena = (decimal?)2.50,
                Kg = true,
                PodkategorijaID = 38,
                PoslovnicaID = 3,
                Status = true,
                SlikaPutanja = "proizvod_1016.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1017,
                Sifra = "6888",
                Naziv = "Schauma",
                Opis = "sampon protiv peruti schauma",
                Cijena = (decimal?)6.50,
                Kg = false,
                PodkategorijaID = 43,
                PoslovnicaID = 3,
                Status = true,
                SlikaPutanja = "proizvod_1017.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1018,
                Sifra = "00680",
                Naziv = "Hipp hrana za bebe",
                Opis = "Hrana za bebe do 3 godine",
                Cijena = (decimal?)8.50,
                Kg = false,
                PodkategorijaID = 60,
                PoslovnicaID = 3,
                Status = true,
                SlikaPutanja = "proizvod_1018.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1019,
                Sifra = "06456",
                Naziv = "Sampon za bebe",
                Opis = "Neiritirajuci sampon za bebe",
                Cijena = (decimal?)5.00,
                Kg = false,
                PodkategorijaID = 61,
                PoslovnicaID = 3,
                Status = true,
                SlikaPutanja = "proizvod_1019.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1020,
                Sifra = "6888",
                Naziv = "Banana",
                Opis = "Svjeza banana",
                Cijena = (decimal?)2.30,
                Kg = true,
                PodkategorijaID = 38,
                PoslovnicaID = 2,
                Status = true,
                SlikaPutanja = "proizvod_1020.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1021,
                Sifra = "4754",
                Naziv = "Mrkva",
                Opis = "Svjeza mrkva",
                Cijena = (decimal?)0.50,
                Kg = true,
                PodkategorijaID = 39,
                PoslovnicaID = 2,
                Status = true,
                SlikaPutanja = "proizvod_1021.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1022,
                Sifra = "65774",
                Naziv = "Pedigree",
                Opis = "Hrana za pse",
                Cijena = (decimal?)8.50,
                Kg = false,
                PodkategorijaID = 55,
                PoslovnicaID = 2,
                Status = true,
                SlikaPutanja = "proizvod_1022.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1023,
                Sifra = "75856",
                Naziv = "Friskies",
                Opis = "Hrana za macke",
                Cijena = (decimal?)7.50,
                Kg = false,
                PodkategorijaID = 55,
                PoslovnicaID = 2,
                Status = true,
                SlikaPutanja = "proizvod_1023.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1024,
                Sifra = "658648",
                Naziv = "Dell Lattitude E5440",
                Opis = "15.6'' 1.7GhZ 8GB",
                Cijena = (decimal?)1500.00,
                Kg = false,
                PodkategorijaID = 64,
                PoslovnicaID = 4,
                Status = true,
                SlikaPutanja = "proizvod_1024.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1025,
                Sifra = "567888",
                Naziv = "MSI GS70",
                Opis = "17 inch 16GB i7-8400 2.5 GHz",
                Cijena = (decimal?)2500.00,
                Kg = false,
                PodkategorijaID = 64,
                PoslovnicaID = 4,
                Status = true,
                SlikaPutanja = "proizvod_1025.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });
            modelBuilder.Entity<Proizvod>().HasData(new Proizvod()
            {
                ProizvodID = 1026,
                Sifra = "476767",
                Naziv = "Iphone 12 Pro",
                Opis = "256GB Purple",
                Cijena = (decimal?)2500.00,
                Kg = false,
                PodkategorijaID = 65,
                PoslovnicaID = 4,
                Status = true,
                SlikaPutanja = "proizvod_1026.jpg",
                DatumIzmjene = DateTime.Now,
                DatumKreiranja = DateTime.Now
            });

        }
    }
}

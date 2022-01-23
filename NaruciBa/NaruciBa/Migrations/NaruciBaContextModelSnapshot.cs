﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NaruciBa.Database;

namespace NaruciBa.Migrations
{
    [DbContext(typeof(NaruciBaContext))]
    partial class NaruciBaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NaruciBa.Database.Dostavljac", b =>
                {
                    b.Property<int>("DostavljacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumZaposlenja")
                        .HasColumnType("datetime");

                    b.Property<int?>("DostavljacStatus")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("DostavljacID");

                    b.HasIndex("DostavljacStatus");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Dostavljac");
                });

            modelBuilder.Entity("NaruciBa.Database.DostavljacStatus", b =>
                {
                    b.Property<int>("DostavljacStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DostavljacStatusID");

                    b.ToTable("DostavljacStatus");
                });

            modelBuilder.Entity("NaruciBa.Database.DostavnaKvotum", b =>
                {
                    b.Property<int>("DostavnaKvotaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("CijenaDostave")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("KlijentID")
                        .HasColumnType("int");

                    b.Property<int?>("PoslovnicaID")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TrajanjeDostave")
                        .HasColumnType("int");

                    b.HasKey("DostavnaKvotaID")
                        .HasName("PK__Dostavna__D746976E58B9E5D3");

                    b.HasIndex("KlijentID");

                    b.HasIndex("PoslovnicaID");

                    b.ToTable("DostavnaKvota");
                });

            modelBuilder.Entity("NaruciBa.Database.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GradID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("NaruciBa.Database.Kategorija", b =>
                {
                    b.Property<int>("KategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("KategorijaID");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("NaruciBa.Database.Klijent", b =>
                {
                    b.Property<int>("KlijentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("KlijentID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("NaruciBa.Database.Koordinator", b =>
                {
                    b.Property<int>("KoordinatorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumZaposlenja")
                        .HasColumnType("datetime");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("KoordinatorID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Koordinator");
                });

            modelBuilder.Entity("NaruciBa.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DatumIzmjene")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DatumKreiranja")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DatumRodenja")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordSalt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SlikaPutanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("KorisnikID");

                    b.HasIndex("GradID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("NaruciBa.Database.Kupon", b =>
                {
                    b.Property<int>("KuponID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<int?>("BrojKupovina")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatumKreiranja")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Popust")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("Postotak")
                        .HasColumnType("bit");

                    b.HasKey("KuponID");

                    b.ToTable("Kupon");
                });

            modelBuilder.Entity("NaruciBa.Database.KuponPoslovnica", b =>
                {
                    b.Property<int>("KuponPoslovnicaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KuponID")
                        .HasColumnType("int");

                    b.Property<int?>("PoslovnicaID")
                        .HasColumnType("int");

                    b.HasKey("KuponPoslovnicaID");

                    b.HasIndex("KuponID");

                    b.HasIndex("PoslovnicaID");

                    b.ToTable("KuponPoslovnica");
                });

            modelBuilder.Entity("NaruciBa.Database.NaruceniProizvod", b =>
                {
                    b.Property<int>("NaruceniProizvodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Kolicina")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("NarudzbaID")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodID")
                        .HasColumnType("int");

                    b.Property<decimal?>("UkupnaCijena")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("NaruceniProizvodID");

                    b.HasIndex("NarudzbaID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("NaruceniProizvod");
                });

            modelBuilder.Entity("NaruciBa.Database.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("BonusZaDostavljaca")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int?>("DostavljacID")
                        .HasColumnType("int");

                    b.Property<int?>("KlijentID")
                        .HasColumnType("int");

                    b.Property<int?>("KoordinatorID")
                        .HasColumnType("int");

                    b.Property<int?>("KuponID")
                        .HasColumnType("int");

                    b.Property<int?>("NarudzbaStatusID")
                        .HasColumnType("int");

                    b.Property<int?>("PoslovnicaID")
                        .HasColumnType("int");

                    b.Property<string>("SlikaRacunaPutanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("UkupanIznos")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("NarudzbaID");

                    b.HasIndex("DostavljacID");

                    b.HasIndex("KlijentID");

                    b.HasIndex("KoordinatorID");

                    b.HasIndex("KuponID");

                    b.HasIndex("NarudzbaStatusID");

                    b.HasIndex("PoslovnicaID");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("NaruciBa.Database.NarudzbaStatus", b =>
                {
                    b.Property<int>("NarudzbaStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NarudzbaStatusID");

                    b.ToTable("NarudzbaStatus");
                });

            modelBuilder.Entity("NaruciBa.Database.Podkategorija", b =>
                {
                    b.Property<int>("PodkategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PodkategorijaID");

                    b.HasIndex("KategorijaID");

                    b.ToTable("Podkategorija");
                });

            modelBuilder.Entity("NaruciBa.Database.Poslovnica", b =>
                {
                    b.Property<int>("PoslovnicaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DatumIzmjene")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DatumKreiranja")
                        .HasColumnType("datetime");

                    b.Property<int?>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("KontaktEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KontaktTel")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrgovackiLanacID")
                        .HasColumnType("int");

                    b.HasKey("PoslovnicaID");

                    b.HasIndex("GradID");

                    b.HasIndex("TrgovackiLanacID");

                    b.ToTable("Poslovnica");
                });

            modelBuilder.Entity("NaruciBa.Database.PoslovnicaFavorit", b =>
                {
                    b.Property<int>("PoslovnicaFavoritID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KlijentID")
                        .HasColumnType("int");

                    b.Property<int?>("PoslovnicaID")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("PoslovnicaFavoritID");

                    b.HasIndex("KlijentID");

                    b.HasIndex("PoslovnicaID");

                    b.ToTable("PoslovnicaFavorit");
                });

            modelBuilder.Entity("NaruciBa.Database.Proizvod", b =>
                {
                    b.Property<int>("ProizvodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("DatumIzmjene")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DatumKreiranja")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Kg")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Opis")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("PodkategorijaID")
                        .HasColumnType("int");

                    b.Property<int?>("PoslovnicaID")
                        .HasColumnType("int");

                    b.Property<string>("Sifra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlikaPutanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ProizvodID");

                    b.HasIndex("PodkategorijaID");

                    b.HasIndex("PoslovnicaID");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("NaruciBa.Database.Recenzija", b =>
                {
                    b.Property<int>("RecenzijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KlijentID")
                        .HasColumnType("int");

                    b.Property<string>("Komentar")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int?>("PoslovnicaID")
                        .HasColumnType("int");

                    b.HasKey("RecenzijaID");

                    b.HasIndex("KlijentID");

                    b.HasIndex("PoslovnicaID");

                    b.ToTable("Recenzija");
                });

            modelBuilder.Entity("NaruciBa.Database.TrgovackiLanac", b =>
                {
                    b.Property<int>("TrgovackiLanacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SlikaPutanja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrgovackiLanacID");

                    b.ToTable("TrgovackiLanac");
                });

            modelBuilder.Entity("NaruciBa.Database.TrgovackiLanacKategorija", b =>
                {
                    b.Property<int>("TrgovackiLanacKategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<int?>("TrgovackiLanacID")
                        .HasColumnType("int");

                    b.HasKey("TrgovackiLanacKategorijaID");

                    b.HasIndex("KategorijaID");

                    b.HasIndex("TrgovackiLanacID");

                    b.ToTable("TrgovackiLanacKategorija");
                });

            modelBuilder.Entity("NaruciBa.Database.Dostavljac", b =>
                {
                    b.HasOne("NaruciBa.Database.DostavljacStatus", "DostavljacStatusNavigation")
                        .WithMany("Dostavljacs")
                        .HasForeignKey("DostavljacStatus")
                        .HasConstraintName("FK__Dostavlja__Dosta__4B7734FF");

                    b.HasOne("NaruciBa.Database.Korisnik", "Korisnik")
                        .WithMany("Dostavljacs")
                        .HasForeignKey("KorisnikID")
                        .HasConstraintName("FK__Dostavlja__Koris__4A8310C6");

                    b.Navigation("DostavljacStatusNavigation");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("NaruciBa.Database.DostavnaKvotum", b =>
                {
                    b.HasOne("NaruciBa.Database.Klijent", "Klijent")
                        .WithMany("DostavnaKvota")
                        .HasForeignKey("KlijentID")
                        .HasConstraintName("FK__DostavnaK__Klije__6EC0713C");

                    b.HasOne("NaruciBa.Database.Poslovnica", "Poslovnica")
                        .WithMany("DostavnaKvota")
                        .HasForeignKey("PoslovnicaID")
                        .HasConstraintName("FK__DostavnaK__Poslo__6DCC4D03");

                    b.Navigation("Klijent");

                    b.Navigation("Poslovnica");
                });

            modelBuilder.Entity("NaruciBa.Database.Klijent", b =>
                {
                    b.HasOne("NaruciBa.Database.Korisnik", "Korisnik")
                        .WithMany("Klijents")
                        .HasForeignKey("KorisnikID")
                        .HasConstraintName("FK__Klijent__Korisni__51300E55");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("NaruciBa.Database.Koordinator", b =>
                {
                    b.HasOne("NaruciBa.Database.Korisnik", "Korisnik")
                        .WithMany("Koordinators")
                        .HasForeignKey("KorisnikID")
                        .HasConstraintName("FK__Koordinat__Koris__4E53A1AA");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("NaruciBa.Database.Korisnik", b =>
                {
                    b.HasOne("NaruciBa.Database.Grad", "Grad")
                        .WithMany("Korisniks")
                        .HasForeignKey("GradID")
                        .HasConstraintName("FK__Korisnik__GradID__45BE5BA9");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("NaruciBa.Database.KuponPoslovnica", b =>
                {
                    b.HasOne("NaruciBa.Database.Kupon", "Kupon")
                        .WithMany("KuponPoslovnicas")
                        .HasForeignKey("KuponID")
                        .HasConstraintName("FK__KuponPosl__Kupon__756D6ECB");

                    b.HasOne("NaruciBa.Database.Poslovnica", "Poslovnica")
                        .WithMany("KuponPoslovnicas")
                        .HasForeignKey("PoslovnicaID")
                        .HasConstraintName("FK__KuponPosl__Poslo__76619304");

                    b.Navigation("Kupon");

                    b.Navigation("Poslovnica");
                });

            modelBuilder.Entity("NaruciBa.Database.NaruceniProizvod", b =>
                {
                    b.HasOne("NaruciBa.Database.Narudzba", "Narudzba")
                        .WithMany("NaruceniProizvods")
                        .HasForeignKey("NarudzbaID")
                        .HasConstraintName("FK__NaruceniP__Narud__01D345B0");

                    b.HasOne("NaruciBa.Database.Proizvod", "Proizvod")
                        .WithMany("NaruceniProizvods")
                        .HasForeignKey("ProizvodID")
                        .HasConstraintName("FK__NaruceniP__Proiz__00DF2177");

                    b.Navigation("Narudzba");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("NaruciBa.Database.Narudzba", b =>
                {
                    b.HasOne("NaruciBa.Database.Dostavljac", "Dostavljac")
                        .WithMany("Narudzbas")
                        .HasForeignKey("DostavljacID")
                        .HasConstraintName("FK__Narudzba__Dostav__7A3223E8");

                    b.HasOne("NaruciBa.Database.Klijent", "Klijent")
                        .WithMany("Narudzbas")
                        .HasForeignKey("KlijentID")
                        .HasConstraintName("FK__Narudzba__Klijen__793DFFAF");

                    b.HasOne("NaruciBa.Database.Koordinator", "Koordinator")
                        .WithMany("Narudzbas")
                        .HasForeignKey("KoordinatorID")
                        .HasConstraintName("FK__Narudzba__Koordi__7B264821");

                    b.HasOne("NaruciBa.Database.Kupon", "Kupon")
                        .WithMany("Narudzbas")
                        .HasForeignKey("KuponID")
                        .HasConstraintName("FK__Narudzba__KuponI__7E02B4CC");

                    b.HasOne("NaruciBa.Database.NarudzbaStatus", "NarudzbaStatus")
                        .WithMany("Narudzbas")
                        .HasForeignKey("NarudzbaStatusID")
                        .HasConstraintName("FK__Narudzba__Narudz__7D0E9093");

                    b.HasOne("NaruciBa.Database.Poslovnica", "Poslovnica")
                        .WithMany("Narudzbas")
                        .HasForeignKey("PoslovnicaID")
                        .HasConstraintName("FK__Narudzba__Poslov__7C1A6C5A");

                    b.Navigation("Dostavljac");

                    b.Navigation("Klijent");

                    b.Navigation("Koordinator");

                    b.Navigation("Kupon");

                    b.Navigation("NarudzbaStatus");

                    b.Navigation("Poslovnica");
                });

            modelBuilder.Entity("NaruciBa.Database.Podkategorija", b =>
                {
                    b.HasOne("NaruciBa.Database.Kategorija", "Kategorija")
                        .WithMany("Podkategorijas")
                        .HasForeignKey("KategorijaID")
                        .HasConstraintName("FK__Podkatego__Kateg__5BAD9CC8");

                    b.Navigation("Kategorija");
                });

            modelBuilder.Entity("NaruciBa.Database.Poslovnica", b =>
                {
                    b.HasOne("NaruciBa.Database.Grad", "Grad")
                        .WithMany("Poslovnicas")
                        .HasForeignKey("GradID")
                        .HasConstraintName("FK__Poslovnic__GradI__55F4C372");

                    b.HasOne("NaruciBa.Database.TrgovackiLanac", "TrgovackiLanac")
                        .WithMany("Poslovnicas")
                        .HasForeignKey("TrgovackiLanacID")
                        .HasConstraintName("FK__Poslovnic__Trgov__56E8E7AB");

                    b.Navigation("Grad");

                    b.Navigation("TrgovackiLanac");
                });

            modelBuilder.Entity("NaruciBa.Database.PoslovnicaFavorit", b =>
                {
                    b.HasOne("NaruciBa.Database.Klijent", "Klijent")
                        .WithMany("PoslovnicaFavorits")
                        .HasForeignKey("KlijentID")
                        .HasConstraintName("FK__Poslovnic__Klije__662B2B3B");

                    b.HasOne("NaruciBa.Database.Poslovnica", "Poslovnica")
                        .WithMany("PoslovnicaFavorits")
                        .HasForeignKey("PoslovnicaID")
                        .HasConstraintName("FK__Poslovnic__Poslo__671F4F74");

                    b.Navigation("Klijent");

                    b.Navigation("Poslovnica");
                });

            modelBuilder.Entity("NaruciBa.Database.Proizvod", b =>
                {
                    b.HasOne("NaruciBa.Database.Podkategorija", "Podkategorija")
                        .WithMany("Proizvods")
                        .HasForeignKey("PodkategorijaID")
                        .HasConstraintName("FK__Proizvod__Podkat__5E8A0973");

                    b.HasOne("NaruciBa.Database.Poslovnica", "Poslovnica")
                        .WithMany("Proizvods")
                        .HasForeignKey("PoslovnicaID")
                        .HasConstraintName("FK__Proizvod__Poslov__5F7E2DAC");

                    b.Navigation("Podkategorija");

                    b.Navigation("Poslovnica");
                });

            modelBuilder.Entity("NaruciBa.Database.Recenzija", b =>
                {
                    b.HasOne("NaruciBa.Database.Klijent", "Klijent")
                        .WithMany("Recenzijas")
                        .HasForeignKey("KlijentID")
                        .HasConstraintName("FK__Recenzija__Klije__69FBBC1F");

                    b.HasOne("NaruciBa.Database.Poslovnica", "Poslovnica")
                        .WithMany("Recenzijas")
                        .HasForeignKey("PoslovnicaID")
                        .HasConstraintName("FK__Recenzija__Poslo__6AEFE058");

                    b.Navigation("Klijent");

                    b.Navigation("Poslovnica");
                });

            modelBuilder.Entity("NaruciBa.Database.TrgovackiLanacKategorija", b =>
                {
                    b.HasOne("NaruciBa.Database.Kategorija", "Kategorija")
                        .WithMany("TrgovackiLanacKategorijas")
                        .HasForeignKey("KategorijaID")
                        .HasConstraintName("FK__Trgovacki__Kateg__634EBE90");

                    b.HasOne("NaruciBa.Database.TrgovackiLanac", "TrgovackiLanac")
                        .WithMany("TrgovackiLanacKategorijas")
                        .HasForeignKey("TrgovackiLanacID")
                        .HasConstraintName("FK__Trgovacki__Trgov__625A9A57");

                    b.Navigation("Kategorija");

                    b.Navigation("TrgovackiLanac");
                });

            modelBuilder.Entity("NaruciBa.Database.Dostavljac", b =>
                {
                    b.Navigation("Narudzbas");
                });

            modelBuilder.Entity("NaruciBa.Database.DostavljacStatus", b =>
                {
                    b.Navigation("Dostavljacs");
                });

            modelBuilder.Entity("NaruciBa.Database.Grad", b =>
                {
                    b.Navigation("Korisniks");

                    b.Navigation("Poslovnicas");
                });

            modelBuilder.Entity("NaruciBa.Database.Kategorija", b =>
                {
                    b.Navigation("Podkategorijas");

                    b.Navigation("TrgovackiLanacKategorijas");
                });

            modelBuilder.Entity("NaruciBa.Database.Klijent", b =>
                {
                    b.Navigation("DostavnaKvota");

                    b.Navigation("Narudzbas");

                    b.Navigation("PoslovnicaFavorits");

                    b.Navigation("Recenzijas");
                });

            modelBuilder.Entity("NaruciBa.Database.Koordinator", b =>
                {
                    b.Navigation("Narudzbas");
                });

            modelBuilder.Entity("NaruciBa.Database.Korisnik", b =>
                {
                    b.Navigation("Dostavljacs");

                    b.Navigation("Klijents");

                    b.Navigation("Koordinators");
                });

            modelBuilder.Entity("NaruciBa.Database.Kupon", b =>
                {
                    b.Navigation("KuponPoslovnicas");

                    b.Navigation("Narudzbas");
                });

            modelBuilder.Entity("NaruciBa.Database.Narudzba", b =>
                {
                    b.Navigation("NaruceniProizvods");
                });

            modelBuilder.Entity("NaruciBa.Database.NarudzbaStatus", b =>
                {
                    b.Navigation("Narudzbas");
                });

            modelBuilder.Entity("NaruciBa.Database.Podkategorija", b =>
                {
                    b.Navigation("Proizvods");
                });

            modelBuilder.Entity("NaruciBa.Database.Poslovnica", b =>
                {
                    b.Navigation("DostavnaKvota");

                    b.Navigation("KuponPoslovnicas");

                    b.Navigation("Narudzbas");

                    b.Navigation("PoslovnicaFavorits");

                    b.Navigation("Proizvods");

                    b.Navigation("Recenzijas");
                });

            modelBuilder.Entity("NaruciBa.Database.Proizvod", b =>
                {
                    b.Navigation("NaruceniProizvods");
                });

            modelBuilder.Entity("NaruciBa.Database.TrgovackiLanac", b =>
                {
                    b.Navigation("Poslovnicas");

                    b.Navigation("TrgovackiLanacKategorijas");
                });
#pragma warning restore 612, 618
        }
    }
}

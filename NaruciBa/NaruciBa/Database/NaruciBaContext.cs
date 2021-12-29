using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NaruciBa.Database
{
    public partial class NaruciBaContext : DbContext
    {
        public NaruciBaContext()
        {
        }

        public NaruciBaContext(DbContextOptions<NaruciBaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dostavljac> Dostavljacs { get; set; }
        public virtual DbSet<DostavljacStatus> DostavljacStatuses { get; set; }
        public virtual DbSet<DostavnaKvotum> DostavnaKvota { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Kategorija> Kategorijas { get; set; }
        public virtual DbSet<Klijent> Klijents { get; set; }
        public virtual DbSet<Koordinator> Koordinators { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Kupon> Kupons { get; set; }
        public virtual DbSet<KuponPoslovnica> KuponPoslovnicas { get; set; }
        public virtual DbSet<NaruceniProizvod> NaruceniProizvods { get; set; }
        public virtual DbSet<Narudzba> Narudzbas { get; set; }
        public virtual DbSet<NarudzbaStatus> NarudzbaStatuses { get; set; }
        public virtual DbSet<Podkategorija> Podkategorijas { get; set; }
        public virtual DbSet<Poslovnica> Poslovnicas { get; set; }
        public virtual DbSet<PoslovnicaFavorit> PoslovnicaFavorits { get; set; }
        public virtual DbSet<Proizvod> Proizvods { get; set; }
        public virtual DbSet<Recenzija> Recenzijas { get; set; }
        public virtual DbSet<TrgovackiLanac> TrgovackiLanacs { get; set; }
        public virtual DbSet<TrgovackiLanacKategorija> TrgovackiLanacKategorijas { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=localhost, 1433;Initial Catalog=NaruciBa; user=sa; Password=QWEasd123!");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Dostavljac>(entity =>
            {
                entity.ToTable("Dostavljac");

                entity.Property(e => e.DatumZaposlenja).HasColumnType("datetime");

                entity.HasOne(d => d.DostavljacStatusNavigation)
                    .WithMany(p => p.Dostavljacs)
                    .HasForeignKey(d => d.DostavljacStatus)
                    .HasConstraintName("FK__Dostavlja__Dosta__4B7734FF");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Dostavljacs)
                    .HasForeignKey(d => d.KorisnikID)
                    .HasConstraintName("FK__Dostavlja__Koris__4A8310C6");
            });

            modelBuilder.Entity<DostavljacStatus>(entity =>
            {
                entity.ToTable("DostavljacStatus");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<DostavnaKvotum>(entity =>
            {
                entity.HasKey(e => e.DostavnaKvotaID)
                    .HasName("PK__Dostavna__D746976E58B9E5D3");

                entity.Property(e => e.CijenaDostave).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.DostavnaKvota)
                    .HasForeignKey(d => d.KlijentID)
                    .HasConstraintName("FK__DostavnaK__Klije__6EC0713C");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.DostavnaKvota)
                    .HasForeignKey(d => d.PoslovnicaID)
                    .HasConstraintName("FK__DostavnaK__Poslo__6DCC4D03");
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.ToTable("Kategorija");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.ToTable("Klijent");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Klijents)
                    .HasForeignKey(d => d.KorisnikID)
                    .HasConstraintName("FK__Klijent__Korisni__51300E55");
            });

            modelBuilder.Entity<Koordinator>(entity =>
            {
                entity.ToTable("Koordinator");

                entity.Property(e => e.DatumZaposlenja).HasColumnType("datetime");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Koordinators)
                    .HasForeignKey(d => d.KorisnikID)
                    .HasConstraintName("FK__Koordinat__Koris__4E53A1AA");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.Adresa).HasMaxLength(100);

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");

                entity.Property(e => e.DatumRodenja).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Ime).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(50);

                entity.Property(e => e.PasswordSalt).HasMaxLength(50);

                entity.Property(e => e.Prezime).HasMaxLength(50);

                entity.Property(e => e.Slika).HasColumnType("image");

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.GradID)
                    .HasConstraintName("FK__Korisnik__GradID__45BE5BA9");
            });

            modelBuilder.Entity<Kupon>(entity =>
            {
                entity.ToTable("Kupon");

                entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");

                entity.Property(e => e.Popust).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<KuponPoslovnica>(entity =>
            {
                entity.ToTable("KuponPoslovnica");

                entity.HasOne(d => d.Kupon)
                    .WithMany(p => p.KuponPoslovnicas)
                    .HasForeignKey(d => d.KuponID)
                    .HasConstraintName("FK__KuponPosl__Kupon__756D6ECB");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.KuponPoslovnicas)
                    .HasForeignKey(d => d.PoslovnicaID)
                    .HasConstraintName("FK__KuponPosl__Poslo__76619304");
            });

            modelBuilder.Entity<NaruceniProizvod>(entity =>
            {
                entity.ToTable("NaruceniProizvod");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UkupnaCijena).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NaruceniProizvods)
                    .HasForeignKey(d => d.NarudzbaID)
                    .HasConstraintName("FK__NaruceniP__Narud__01D345B0");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.NaruceniProizvods)
                    .HasForeignKey(d => d.ProizvodID)
                    .HasConstraintName("FK__NaruceniP__Proiz__00DF2177");
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.ToTable("Narudzba");

                entity.Property(e => e.BonusZaDostavljaca).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.SlikaRacuna).HasColumnType("image");

                entity.Property(e => e.UkupanIznos).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Dostavljac)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.DostavljacID)
                    .HasConstraintName("FK__Narudzba__Dostav__7A3223E8");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.KlijentID)
                    .HasConstraintName("FK__Narudzba__Klijen__793DFFAF");

                entity.HasOne(d => d.Koordinator)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.KoordinatorID)
                    .HasConstraintName("FK__Narudzba__Koordi__7B264821");

                entity.HasOne(d => d.Kupon)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.KuponID)
                    .HasConstraintName("FK__Narudzba__KuponI__7E02B4CC");

                entity.HasOne(d => d.NarudzbaStatus)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.NarudzbaStatusID)
                    .HasConstraintName("FK__Narudzba__Narudz__7D0E9093");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.PoslovnicaID)
                    .HasConstraintName("FK__Narudzba__Poslov__7C1A6C5A");
            });

            modelBuilder.Entity<NarudzbaStatus>(entity =>
            {
                entity.ToTable("NarudzbaStatus");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<Podkategorija>(entity =>
            {
                entity.ToTable("Podkategorija");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Podkategorijas)
                    .HasForeignKey(d => d.KategorijaID)
                    .HasConstraintName("FK__Podkatego__Kateg__5BAD9CC8");
            });

            modelBuilder.Entity<Poslovnica>(entity =>
            {
                entity.ToTable("Poslovnica");

                entity.Property(e => e.Adresa).HasMaxLength(100);

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");

                entity.Property(e => e.KontaktEmail).HasMaxLength(50);

                entity.Property(e => e.KontaktTel).HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Poslovnicas)
                    .HasForeignKey(d => d.GradID)
                    .HasConstraintName("FK__Poslovnic__GradI__55F4C372");

                entity.HasOne(d => d.TrgovackiLanac)
                    .WithMany(p => p.Poslovnicas)
                    .HasForeignKey(d => d.TrgovackiLanacID)
                    .HasConstraintName("FK__Poslovnic__Trgov__56E8E7AB");
            });

            modelBuilder.Entity<PoslovnicaFavorit>(entity =>
            {
                entity.ToTable("PoslovnicaFavorit");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.PoslovnicaFavorits)
                    .HasForeignKey(d => d.KlijentID)
                    .HasConstraintName("FK__Poslovnic__Klije__662B2B3B");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.PoslovnicaFavorits)
                    .HasForeignKey(d => d.PoslovnicaID)
                    .HasConstraintName("FK__Poslovnic__Poslo__671F4F74");
            });

            modelBuilder.Entity<Proizvod>(entity =>
            {
                entity.ToTable("Proizvod");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.Slika).HasColumnType("image");

                entity.HasOne(d => d.Podkategorija)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.PodkategorijaID)
                    .HasConstraintName("FK__Proizvod__Podkat__5E8A0973");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.PoslovnicaID)
                    .HasConstraintName("FK__Proizvod__Poslov__5F7E2DAC");
            });

            modelBuilder.Entity<Recenzija>(entity =>
            {
                entity.ToTable("Recenzija");

                entity.Property(e => e.Komentar).HasMaxLength(200);

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Recenzijas)
                    .HasForeignKey(d => d.KlijentID)
                    .HasConstraintName("FK__Recenzija__Klije__69FBBC1F");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.Recenzijas)
                    .HasForeignKey(d => d.PoslovnicaID)
                    .HasConstraintName("FK__Recenzija__Poslo__6AEFE058");
            });

            modelBuilder.Entity<TrgovackiLanac>(entity =>
            {
                entity.ToTable("TrgovackiLanac");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.Slika).HasColumnType("image");
            });

            modelBuilder.Entity<TrgovackiLanacKategorija>(entity =>
            {
                entity.ToTable("TrgovackiLanacKategorija");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.TrgovackiLanacKategorijas)
                    .HasForeignKey(d => d.KategorijaID)
                    .HasConstraintName("FK__Trgovacki__Kateg__634EBE90");

                entity.HasOne(d => d.TrgovackiLanac)
                    .WithMany(p => p.TrgovackiLanacKategorijas)
                    .HasForeignKey(d => d.TrgovackiLanacID)
                    .HasConstraintName("FK__Trgovacki__Trgov__625A9A57");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

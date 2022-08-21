using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaruciBa.Migrations
{
    public partial class initialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DostavljacStatus",
                columns: table => new
                {
                    DostavljacStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DostavljacStatus", x => x.DostavljacStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradID);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "Kupon",
                columns: table => new
                {
                    KuponID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Popust = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Postotak = table.Column<bool>(type: "bit", nullable: true),
                    BrojKupovina = table.Column<int>(type: "int", nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupon", x => x.KuponID);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaStatus",
                columns: table => new
                {
                    NarudzbaStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStatus", x => x.NarudzbaStatusID);
                });

            migrationBuilder.CreateTable(
                name: "TrgovackiLanac",
                columns: table => new
                {
                    TrgovackiLanacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SlikaPutanja = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrgovackiLanac", x => x.TrgovackiLanacID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DatumRodenja = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SlikaPutanja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK__Korisnik__GradID__45BE5BA9",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Podkategorija",
                columns: table => new
                {
                    PodkategorijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KategorijaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podkategorija", x => x.PodkategorijaID);
                    table.ForeignKey(
                        name: "FK__Podkatego__Kateg__5BAD9CC8",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Poslovnica",
                columns: table => new
                {
                    PoslovnicaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GradID = table.Column<int>(type: "int", nullable: true),
                    KontaktTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    KontaktEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrgovackiLanacID = table.Column<int>(type: "int", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poslovnica", x => x.PoslovnicaID);
                    table.ForeignKey(
                        name: "FK__Poslovnic__GradI__55F4C372",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Poslovnic__Trgov__56E8E7AB",
                        column: x => x.TrgovackiLanacID,
                        principalTable: "TrgovackiLanac",
                        principalColumn: "TrgovackiLanacID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dostavljac",
                columns: table => new
                {
                    DostavljacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumZaposlenja = table.Column<DateTime>(type: "datetime", nullable: true),
                    KorisnikID = table.Column<int>(type: "int", nullable: true),
                    DostavljacStatus = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostavljac", x => x.DostavljacID);
                    table.ForeignKey(
                        name: "FK__Dostavlja__Dosta__4B7734FF",
                        column: x => x.DostavljacStatus,
                        principalTable: "DostavljacStatus",
                        principalColumn: "DostavljacStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Dostavlja__Koris__4A8310C6",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Klijent",
                columns: table => new
                {
                    KlijentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijent", x => x.KlijentID);
                    table.ForeignKey(
                        name: "FK__Klijent__Korisni__51300E55",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Koordinator",
                columns: table => new
                {
                    KoordinatorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumZaposlenja = table.Column<DateTime>(type: "datetime", nullable: true),
                    KorisnikID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koordinator", x => x.KoordinatorID);
                    table.ForeignKey(
                        name: "FK__Koordinat__Koris__4E53A1AA",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KuponPoslovnica",
                columns: table => new
                {
                    KuponPoslovnicaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KuponID = table.Column<int>(type: "int", nullable: true),
                    PoslovnicaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KuponPoslovnica", x => x.KuponPoslovnicaID);
                    table.ForeignKey(
                        name: "FK__KuponPosl__Kupon__756D6ECB",
                        column: x => x.KuponID,
                        principalTable: "Kupon",
                        principalColumn: "KuponID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__KuponPosl__Poslo__76619304",
                        column: x => x.PoslovnicaID,
                        principalTable: "Poslovnica",
                        principalColumn: "PoslovnicaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PoslovnicaKategorija",
                columns: table => new
                {
                    PoslovnicaKategorijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoslovnicaID = table.Column<int>(type: "int", nullable: true),
                    KategorijaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoslovnicaKategorija", x => x.PoslovnicaKategorijaID);
                    table.ForeignKey(
                        name: "FK__Trgovacki__Kateg__634EBE90",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_poslovnicaKategorija_Poslovnica",
                        column: x => x.PoslovnicaID,
                        principalTable: "Poslovnica",
                        principalColumn: "PoslovnicaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    ProizvodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sifra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Kg = table.Column<bool>(type: "bit", nullable: true),
                    PodkategorijaID = table.Column<int>(type: "int", nullable: true),
                    PoslovnicaID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    SlikaPutanja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.ProizvodID);
                    table.ForeignKey(
                        name: "FK__Proizvod__Podkat__5E8A0973",
                        column: x => x.PodkategorijaID,
                        principalTable: "Podkategorija",
                        principalColumn: "PodkategorijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Proizvod__Poslov__5F7E2DAC",
                        column: x => x.PoslovnicaID,
                        principalTable: "Poslovnica",
                        principalColumn: "PoslovnicaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DostavnaKvota",
                columns: table => new
                {
                    DostavnaKvotaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoslovnicaID = table.Column<int>(type: "int", nullable: true),
                    KlijentID = table.Column<int>(type: "int", nullable: true),
                    CijenaDostave = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrajanjeDostave = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dostavna__D746976E58B9E5D3", x => x.DostavnaKvotaID);
                    table.ForeignKey(
                        name: "FK__DostavnaK__Klije__6EC0713C",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__DostavnaK__Poslo__6DCC4D03",
                        column: x => x.PoslovnicaID,
                        principalTable: "Poslovnica",
                        principalColumn: "PoslovnicaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PoslovnicaFavorit",
                columns: table => new
                {
                    PoslovnicaFavoritID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlijentID = table.Column<int>(type: "int", nullable: true),
                    PoslovnicaID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoslovnicaFavorit", x => x.PoslovnicaFavoritID);
                    table.ForeignKey(
                        name: "FK__Poslovnic__Klije__662B2B3B",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Poslovnic__Poslo__671F4F74",
                        column: x => x.PoslovnicaID,
                        principalTable: "Poslovnica",
                        principalColumn: "PoslovnicaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    RecenzijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(type: "int", nullable: true),
                    Komentar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    KlijentID = table.Column<int>(type: "int", nullable: true),
                    PoslovnicaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.RecenzijaID);
                    table.ForeignKey(
                        name: "FK__Recenzija__Klije__69FBBC1F",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Recenzija__Poslo__6AEFE058",
                        column: x => x.PoslovnicaID,
                        principalTable: "Poslovnica",
                        principalColumn: "PoslovnicaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlijentID = table.Column<int>(type: "int", nullable: true),
                    DostavljacID = table.Column<int>(type: "int", nullable: true),
                    KoordinatorID = table.Column<int>(type: "int", nullable: true),
                    PoslovnicaID = table.Column<int>(type: "int", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    UkupanIznos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BonusZaDostavljaca = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SlikaRacunaPutanja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NarudzbaStatusID = table.Column<int>(type: "int", nullable: true),
                    KuponID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaID);
                    table.ForeignKey(
                        name: "FK__Narudzba__Dostav__7A3223E8",
                        column: x => x.DostavljacID,
                        principalTable: "Dostavljac",
                        principalColumn: "DostavljacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Narudzba__Klijen__793DFFAF",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Narudzba__Koordi__7B264821",
                        column: x => x.KoordinatorID,
                        principalTable: "Koordinator",
                        principalColumn: "KoordinatorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Narudzba__KuponI__7E02B4CC",
                        column: x => x.KuponID,
                        principalTable: "Kupon",
                        principalColumn: "KuponID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Narudzba__Narudz__7D0E9093",
                        column: x => x.NarudzbaStatusID,
                        principalTable: "NarudzbaStatus",
                        principalColumn: "NarudzbaStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Narudzba__Poslov__7C1A6C5A",
                        column: x => x.PoslovnicaID,
                        principalTable: "Poslovnica",
                        principalColumn: "PoslovnicaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NaruceniProizvod",
                columns: table => new
                {
                    NaruceniProizvodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodID = table.Column<int>(type: "int", nullable: true),
                    NarudzbaID = table.Column<int>(type: "int", nullable: true),
                    Kolicina = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UkupnaCijena = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaruceniProizvod", x => x.NaruceniProizvodID);
                    table.ForeignKey(
                        name: "FK__NaruceniP__Narud__01D345B0",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__NaruceniP__Proiz__00DF2177",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DostavljacStatus",
                columns: new[] { "DostavljacStatusID", "Naziv" },
                values: new object[,]
                {
                    { 1, "slobodan" },
                    { 2, "u narudzbi" },
                    { 3, "neaktivan" }
                });

            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "GradID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Tuzla" },
                    { 2, "Sarajevo" },
                    { 3, "Mostar" },
                    { 4, "Banja Luka" },
                    { 5, "Zenica" },
                    { 6, "Zavidovici" }
                });

            migrationBuilder.InsertData(
                table: "Kategorija",
                columns: new[] { "KategorijaID", "Naziv" },
                values: new object[,]
                {
                    { 21, "Vozila" },
                    { 20, "Skola" },
                    { 19, "Bebe" },
                    { 18, "Kucni Ljubimci" },
                    { 17, "Elektronika" },
                    { 16, "Higijena" },
                    { 15, "Hrana i Pice" }
                });

            migrationBuilder.InsertData(
                table: "NarudzbaStatus",
                columns: new[] { "NarudzbaStatusID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Zapoceta" },
                    { 2, "Aktivna" },
                    { 3, "Zaprimljena" },
                    { 4, "U kupovini" },
                    { 5, "Dostava" },
                    { 6, "Zavrsena" },
                    { 7, "Otkazana" }
                });

            migrationBuilder.InsertData(
                table: "TrgovackiLanac",
                columns: new[] { "TrgovackiLanacID", "Naziv", "SlikaPutanja" },
                values: new object[,]
                {
                    { 1, "Bingo", "trgovackilanac_1.jpg" },
                    { 2, "Konzum", "trgovackilanac_2.jpg" },
                    { 3, "Genelec", "trgovackilanac_3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "KorisnikID", "Adresa", "DatumIzmjene", "DatumKreiranja", "DatumRodenja", "Email", "GradID", "Ime", "PasswordHash", "PasswordSalt", "Prezime", "SlikaPutanja", "Telefon" },
                values: new object[,]
                {
                    { 2, "Adresa admina 24", new DateTime(2022, 8, 21, 15, 4, 44, 820, DateTimeKind.Local).AddTicks(5243), new DateTime(2022, 8, 21, 15, 4, 44, 820, DateTimeKind.Local).AddTicks(4625), new DateTime(2022, 8, 21, 15, 4, 44, 815, DateTimeKind.Local).AddTicks(9679), "desktop@gmail.com", 1, "desktop", "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=", "p9av83cBc37tVxOqcJlaPA==", "admin", null, "06411123233" },
                    { 1003, "Adresa mobile 23 L", new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(971), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(948), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(875), "mobile@gmail.com", 1, "mobile", "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=", "p9av83cBc37tVxOqcJlaPA==", "test", null, "064166323233" },
                    { 1007, "Neka Adresa", new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1463), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1428), "velid@gmail.com", 1, "Velid", "dX4PhU98Jw/EfxV3XgaPJq0paX8=", "BehlC7xXAX9C1z5zPdFzGg==", "Hatic", null, "06234344455" },
                    { 1012, "Prva ulica 42", new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1616), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1605), "emir@gmail.com", 1, "Emir", "+9yvonO1LEAd2j5PcQ4rlx04EKA=", "nq+mmwzWQEmtnVQLQwFwIQ==", "Hodzic", null, "06234344455" },
                    { 1013, "Druga ulica 12", new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1704), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1698), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1689), "ahmo@gmail.com", 1, "Ahmo", "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=", "p9av83cBc37tVxOqcJlaPA==", "Ahmic", null, "0623554555" },
                    { 1014, "Treca ulica 2", new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1798), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1791), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1781), "haso@gmail.com", 1, "Haso", "IJJHgLDhwaX399tMxsqh/bQ7SjM=", "caGo+QqT++vaqQFQrhE2eA==", "Hasanovic", null, "0623554555" },
                    { 1015, "Cetvrta ulica 23", new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1881), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1873), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1863), "dostavljac@gmail.com", 1, "Dostavljac", "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=", "p9av83cBc37tVxOqcJlaPA==", "Test", null, "0623554555" },
                    { 1016, "Peta ulica 23", new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1960), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1952), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(1942), "ajdin@gmail.com", 1, "Ajdin", "KollFEuC5A6+fRdbD7iF4UeSNBM=", "JQS8wY5Hq1Jf7IFACDkYmQ==", "Ajdinovic", null, "0623554555" },
                    { 2016, "Sesta ulica 35", new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(2034), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(2027), new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(2018), "bekir@gmail.com", 3, "Bekir", "m4SNoQUsSWimY2iEcmlcH4JX3nw=", "sad/ufjxSKTwXWAq1kUISw==", "Becirovic", null, "0623554555" }
                });

            migrationBuilder.InsertData(
                table: "Podkategorija",
                columns: new[] { "PodkategorijaID", "KategorijaID", "Naziv" },
                values: new object[,]
                {
                    { 57, 18, "Higijena ljubimaca" },
                    { 58, 18, "Ljubimci ostalo" },
                    { 59, 19, "Igracke za bebe" },
                    { 60, 19, "Hrana za bebe" },
                    { 54, 20, "Pokloni" },
                    { 50, 20, "Ruksaci/torbe" },
                    { 52, 20, "Pribor" },
                    { 53, 20, "Knjige" },
                    { 56, 18, "Igracke za ljubimce" },
                    { 61, 19, "Higijena za bebe" },
                    { 55, 18, "Hrana za ljubimce" },
                    { 62, 17, "Pohrana podataka" },
                    { 64, 17, "Laptopi" },
                    { 63, 17, "Kompjuterska oprema" },
                    { 66, 16, "Mirisi" },
                    { 44, 16, "Zubi" },
                    { 43, 16, "Samponi/sapuni" },
                    { 42, 15, "Zacini" },
                    { 41, 15, "Mlijecni Proizvodi" },
                    { 40, 15, "Mesni Proizvodi" },
                    { 39, 15, "Povrce" },
                    { 38, 15, "Voce" },
                    { 65, 17, "Mobiteli" }
                });

            migrationBuilder.InsertData(
                table: "Poslovnica",
                columns: new[] { "PoslovnicaID", "Adresa", "DatumIzmjene", "DatumKreiranja", "GradID", "KontaktEmail", "KontaktTel", "Status", "TrgovackiLanacID" },
                values: new object[,]
                {
                    { 3, "Bulevar 2. Armije BiH 1", new DateTime(2022, 8, 21, 15, 4, 44, 829, DateTimeKind.Local).AddTicks(4624), new DateTime(2022, 8, 21, 15, 4, 44, 829, DateTimeKind.Local).AddTicks(4614), 1, "konzum@gmail.com", "00023233344", true, 2 },
                    { 1, "Mitra Trifunovica", new DateTime(2022, 8, 21, 15, 4, 44, 829, DateTimeKind.Local).AddTicks(2989), new DateTime(2022, 8, 21, 15, 4, 44, 829, DateTimeKind.Local).AddTicks(2289), 1, "managmentbcctuzla@confluence.ba", "035288699", true, 1 },
                    { 2, "Ismeta Mujezinovica D9", new DateTime(2022, 8, 21, 15, 4, 44, 829, DateTimeKind.Local).AddTicks(4429), new DateTime(2022, 8, 21, 15, 4, 44, 829, DateTimeKind.Local).AddTicks(4377), 1, "bingoSjenjak@gmail.com", "035365580", true, 1 },
                    { 4, "Stupine B-14", new DateTime(2022, 8, 21, 15, 4, 44, 829, DateTimeKind.Local).AddTicks(4679), new DateTime(2022, 8, 21, 15, 4, 44, 829, DateTimeKind.Local).AddTicks(4673), 1, "genelecTuzla@gmail.com", "0643536266", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "Dostavljac",
                columns: new[] { "DostavljacID", "DatumZaposlenja", "DostavljacStatus", "KorisnikID" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 21, 15, 4, 44, 824, DateTimeKind.Local).AddTicks(9506), 1, 1013 },
                    { 2, new DateTime(2022, 8, 21, 15, 4, 44, 825, DateTimeKind.Local).AddTicks(766), 1, 1014 },
                    { 3, new DateTime(2022, 8, 21, 15, 4, 44, 825, DateTimeKind.Local).AddTicks(854), 2, 1015 },
                    { 4, new DateTime(2022, 8, 21, 15, 4, 44, 825, DateTimeKind.Local).AddTicks(892), 1, 2016 }
                });

            migrationBuilder.InsertData(
                table: "Klijent",
                columns: new[] { "KlijentID", "KorisnikID" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1003 },
                    { 6, 1007 },
                    { 11, 1012 },
                    { 12, 1016 }
                });

            migrationBuilder.InsertData(
                table: "Koordinator",
                columns: new[] { "KoordinatorID", "DatumZaposlenja", "KorisnikID" },
                values: new object[] { 1, new DateTime(2022, 8, 21, 15, 4, 44, 823, DateTimeKind.Local).AddTicks(6907), 2 });

            migrationBuilder.InsertData(
                table: "PoslovnicaKategorija",
                columns: new[] { "PoslovnicaKategorijaID", "KategorijaID", "PoslovnicaID" },
                values: new object[,]
                {
                    { 1012, 17, 4 },
                    { 1009, 19, 3 },
                    { 1008, 16, 3 },
                    { 1007, 15, 3 },
                    { 1011, 18, 2 },
                    { 7, 16, 2 },
                    { 1010, 15, 2 },
                    { 1006, 16, 1 },
                    { 6, 15, 1 }
                });

            migrationBuilder.InsertData(
                table: "Proizvod",
                columns: new[] { "ProizvodID", "Cijena", "DatumIzmjene", "DatumKreiranja", "Kg", "Naziv", "Opis", "PodkategorijaID", "PoslovnicaID", "Sifra", "SlikaPutanja", "Status" },
                values: new object[,]
                {
                    { 1024, 1500m, new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(154), new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(159), false, "Dell Lattitude E5440", "15.6'' 1.7GhZ 8GB", 64, 4, "658648", "proizvod_1024.jpg", true },
                    { 1019, 5m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9949), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9954), false, "Sampon za bebe", "Neiritirajuci sampon za bebe", 61, 3, "06456", "proizvod_1019.jpg", true },
                    { 1018, 8.5m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9909), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9914), false, "Hipp hrana za bebe", "Hrana za bebe do 3 godine", 60, 3, "00680", "proizvod_1018.jpg", true },
                    { 1017, 6.5m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9868), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9873), false, "Schauma", "sampon protiv peruti schauma", 43, 3, "6888", "proizvod_1017.jpg", true },
                    { 1016, 2.5m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9823), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9829), true, "Narandza", "Svjeza narandza", 38, 3, "56773", "proizvod_1016.jpg", true },
                    { 1015, 2.3m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9776), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9783), true, "Banana", "Svjeza banana", 38, 3, "3436", "proizvod_1015.jpg", true },
                    { 1014, 1.2m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9647), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9653), true, "Jabuka", "Svjeza crvena jabuka", 38, 3, "23455", "proizvod_1014.jpg", true },
                    { 1013, 4.5m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9603), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9609), true, "Ananas", "Svjezi ananas", 38, 1, "0064", "proizvod_1013.jpg", true },
                    { 1012, 2m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9553), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9559), true, "Paradajz", "Paradajz", 39, 1, "0034", "proizvod_1012.jpg", true },
                    { 12, 2m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9353), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9387), true, "Banana", "Svjeza banana", 38, 1, "0001", "proizvod_12.jpg", true },
                    { 1023, 7.5m, new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(113), new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(118), false, "Friskies", "Hrana za macke", 55, 2, "75856", "proizvod_1023.jpg", true },
                    { 1022, 8.5m, new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(73), new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(78), false, "Pedigree", "Hrana za pse", 55, 2, "65774", "proizvod_1022.jpg", true },
                    { 1021, 0.5m, new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(33), new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(38), true, "Mrkva", "Svjeza mrkva", 39, 2, "4754", "proizvod_1021.jpg", true },
                    { 1020, 2.3m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9991), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9998), true, "Banana", "Svjeza banana", 38, 2, "6888", "proizvod_1020.jpg", true },
                    { 13, 3m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9466), false, "Head & Shoulders", "sampon protiv peruti", 43, 2, "0023", "proizvod_13.jpg", true },
                    { 1011, 3.5m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(9515), false, "Sampon", "sampon protiv peruti", 43, 1, "0004", "proizvod_13.jpg", true },
                    { 1025, 2500m, new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(197), new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(202), false, "MSI GS70", "17 inch 16GB i7-8400 2.5 GHz", 64, 4, "567888", "proizvod_1025.jpg", true },
                    { 11, 2.3m, new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(7828), new DateTime(2022, 8, 21, 15, 4, 44, 830, DateTimeKind.Local).AddTicks(8373), true, "Jabuka", "Svjeza jabuka", 38, 1, "0000", "proizvod_11.jpg", true },
                    { 1026, 2500m, new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(238), new DateTime(2022, 8, 21, 15, 4, 44, 831, DateTimeKind.Local).AddTicks(243), false, "Iphone 12 Pro", "256GB Purple", 65, 4, "476767", "proizvod_1026.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "Narudzba",
                columns: new[] { "NarudzbaID", "BonusZaDostavljaca", "Datum", "DostavljacID", "KlijentID", "KoordinatorID", "KuponID", "NarudzbaStatusID", "PoslovnicaID", "SlikaRacunaPutanja", "UkupanIznos" },
                values: new object[,]
                {
                    { 9, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(3334), null, 2, null, null, 6, 1, null, 9.75m },
                    { 3022, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5973), null, 12, null, null, 2, 1, null, 6.9m },
                    { 3021, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5901), null, 12, null, null, 2, 2, null, 6m },
                    { 3020, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5841), null, 12, null, null, 2, 1, null, 9.2m },
                    { 2022, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5787), null, 12, null, null, 2, 1, null, 4m },
                    { 2021, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5732), null, 12, null, null, 2, 1, null, 6m },
                    { 2020, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5666), null, 12, null, null, 2, 1, null, 4.6m },
                    { 1021, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5573), 3, 12, null, null, 3, 1, "narudzba_1021.jpg", 11.5m },
                    { 21, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5437), 1, 12, null, null, 6, 2, null, 12m },
                    { 20, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5379), 1, 12, null, null, 6, 2, null, 6m },
                    { 19, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5312), 1, 12, null, null, 6, 1, null, 16.3m },
                    { 17, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5201), 3, 2, null, null, 6, 2, null, 9m },
                    { 16, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5019), 3, 2, null, null, 6, 1, null, 6.9m },
                    { 15, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(4936), 3, 2, null, null, 6, 2, null, 3m },
                    { 8, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(3381), 3, 2, null, null, 7, 1, null, 16.6m },
                    { 13, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(4708), 2, 2, null, null, 6, 1, "narudzba_13.jpg", 11.25m },
                    { 1, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(1449), 2, 2, null, null, 7, 1, null, 16.6m },
                    { 12, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(3807), 1, 2, null, null, 6, 1, "narudzba_12.jpg", 18.32m },
                    { 11, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(3622), 1, 2, null, null, 6, 1, null, 2.3m },
                    { 10, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(3439), 1, 2, null, null, 6, 1, null, 4.6m },
                    { 6, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(3210), 1, 11, null, null, 6, 1, null, 12.05m },
                    { 3023, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(6055), null, 2, null, null, 1, 1, null, 14.6m },
                    { 14, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(4847), 4, 2, null, null, 6, 1, null, 6m },
                    { 1019, null, new DateTime(2022, 8, 21, 15, 4, 44, 827, DateTimeKind.Local).AddTicks(5497), 4, 12, null, null, 6, 1, null, 10.9m }
                });

            migrationBuilder.InsertData(
                table: "NaruceniProizvod",
                columns: new[] { "NaruceniProizvodID", "Kolicina", "NarudzbaID", "ProizvodID", "UkupnaCijena" },
                values: new object[,]
                {
                    { 4036, 5m, 3023, 12, 10m },
                    { 1029, 3m, 14, 12, 6m },
                    { 4035, 3m, 3022, 11, 6.9m },
                    { 4034, 2m, 3021, 13, 6m },
                    { 4033, 4m, 3020, 11, 9.2m },
                    { 3035, 2m, 2022, 12, 4m },
                    { 3034, 3m, 2021, 12, 6m },
                    { 3033, 2m, 2020, 11, 4.6m },
                    { 2033, 3m, 1019, 11, 6.9m },
                    { 2035, 5m, 1021, 11, 11.5m },
                    { 1036, 2m, 20, 13, 6m },
                    { 1035, 4m, 19, 1011, 14m },
                    { 1033, 1m, 19, 11, 2.3m },
                    { 1032, 3m, 17, 13, 9m },
                    { 1031, 3m, 16, 11, 6.9m },
                    { 1030, 1m, 15, 13, 3m },
                    { 4037, 2m, 3023, 11, 4.6m },
                    { 1037, 4m, 21, 13, 12m },
                    { 2034, 2m, 1019, 12, 4m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dostavljac_DostavljacStatus",
                table: "Dostavljac",
                column: "DostavljacStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Dostavljac_KorisnikID",
                table: "Dostavljac",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_DostavnaKvota_KlijentID",
                table: "DostavnaKvota",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_DostavnaKvota_PoslovnicaID",
                table: "DostavnaKvota",
                column: "PoslovnicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Klijent_KorisnikID",
                table: "Klijent",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Koordinator_KorisnikID",
                table: "Koordinator",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_GradID",
                table: "Korisnik",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_KuponPoslovnica_KuponID",
                table: "KuponPoslovnica",
                column: "KuponID");

            migrationBuilder.CreateIndex(
                name: "IX_KuponPoslovnica_PoslovnicaID",
                table: "KuponPoslovnica",
                column: "PoslovnicaID");

            migrationBuilder.CreateIndex(
                name: "IX_NaruceniProizvod_NarudzbaID",
                table: "NaruceniProizvod",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_NaruceniProizvod_ProizvodID",
                table: "NaruceniProizvod",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_DostavljacID",
                table: "Narudzba",
                column: "DostavljacID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KlijentID",
                table: "Narudzba",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KoordinatorID",
                table: "Narudzba",
                column: "KoordinatorID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KuponID",
                table: "Narudzba",
                column: "KuponID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_NarudzbaStatusID",
                table: "Narudzba",
                column: "NarudzbaStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_PoslovnicaID",
                table: "Narudzba",
                column: "PoslovnicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Podkategorija_KategorijaID",
                table: "Podkategorija",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Poslovnica_GradID",
                table: "Poslovnica",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Poslovnica_TrgovackiLanacID",
                table: "Poslovnica",
                column: "TrgovackiLanacID");

            migrationBuilder.CreateIndex(
                name: "IX_PoslovnicaFavorit_KlijentID",
                table: "PoslovnicaFavorit",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_PoslovnicaFavorit_PoslovnicaID",
                table: "PoslovnicaFavorit",
                column: "PoslovnicaID");

            migrationBuilder.CreateIndex(
                name: "IX_PoslovnicaKategorija_KategorijaID",
                table: "PoslovnicaKategorija",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_PoslovnicaKategorija_PoslovnicaID",
                table: "PoslovnicaKategorija",
                column: "PoslovnicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_PodkategorijaID",
                table: "Proizvod",
                column: "PodkategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_PoslovnicaID",
                table: "Proizvod",
                column: "PoslovnicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_KlijentID",
                table: "Recenzija",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_PoslovnicaID",
                table: "Recenzija",
                column: "PoslovnicaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DostavnaKvota");

            migrationBuilder.DropTable(
                name: "KuponPoslovnica");

            migrationBuilder.DropTable(
                name: "NaruceniProizvod");

            migrationBuilder.DropTable(
                name: "PoslovnicaFavorit");

            migrationBuilder.DropTable(
                name: "PoslovnicaKategorija");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "Dostavljac");

            migrationBuilder.DropTable(
                name: "Klijent");

            migrationBuilder.DropTable(
                name: "Koordinator");

            migrationBuilder.DropTable(
                name: "Kupon");

            migrationBuilder.DropTable(
                name: "NarudzbaStatus");

            migrationBuilder.DropTable(
                name: "Podkategorija");

            migrationBuilder.DropTable(
                name: "Poslovnica");

            migrationBuilder.DropTable(
                name: "DostavljacStatus");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "TrgovackiLanac");

            migrationBuilder.DropTable(
                name: "Grad");
        }
    }
}

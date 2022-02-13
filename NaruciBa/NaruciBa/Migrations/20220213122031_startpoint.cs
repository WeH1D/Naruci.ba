using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaruciBa.Migrations
{
    public partial class startpoint : Migration
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
                name: "TrgovackiLanacKategorija",
                columns: table => new
                {
                    TrgovackiLanacKategorijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrgovackiLanacID = table.Column<int>(type: "int", nullable: true),
                    KategorijaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrgovackiLanacKategorija", x => x.TrgovackiLanacKategorijaID);
                    table.ForeignKey(
                        name: "FK__Trgovacki__Kateg__634EBE90",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Trgovacki__Trgov__625A9A57",
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

            migrationBuilder.CreateIndex(
                name: "IX_TrgovackiLanacKategorija_KategorijaID",
                table: "TrgovackiLanacKategorija",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_TrgovackiLanacKategorija_TrgovackiLanacID",
                table: "TrgovackiLanacKategorija",
                column: "TrgovackiLanacID");
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
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "TrgovackiLanacKategorija");

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

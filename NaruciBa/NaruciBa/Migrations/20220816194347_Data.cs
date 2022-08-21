using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaruciBa.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrgovackiLanacKategorija");

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
                    { 2, "Adresa admina 24", new DateTime(2022, 8, 16, 21, 43, 46, 143, DateTimeKind.Local).AddTicks(8308), new DateTime(2022, 8, 16, 21, 43, 46, 143, DateTimeKind.Local).AddTicks(7253), new DateTime(2022, 8, 16, 21, 43, 46, 139, DateTimeKind.Local).AddTicks(6980), "desktop@gmail.com", 1, "desktop", "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=", "p9av83cBc37tVxOqcJlaPA==", "admin", null, "06411123233" },
                    { 1003, "Adresa mobile 23 L", new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6024), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6002), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(5963), "mobile@gmail.com", 1, "mobile", "Sd+f8RaMfx6JgSeSCurQ7c4m1HQ=", "p9av83cBc37tVxOqcJlaPA==", "test", null, "064166323233" },
                    { 1007, "Neka Adresa", new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6242), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6237), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6228), "velid@gmail.com", 1, "Velid", "dX4PhU98Jw/EfxV3XgaPJq0paX8=", "BehlC7xXAX9C1z5zPdFzGg==", "Hatic", null, "06234344455" },
                    { 1012, "Prva ulica 42", new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6295), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6289), "emir@gmail.com", 1, "Emir", "+9yvonO1LEAd2j5PcQ4rlx04EKA=", "nq+mmwzWQEmtnVQLQwFwIQ==", "Hodzic", null, "06234344455" },
                    { 1013, "Druga ulica 12", new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6353), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6348), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6342), "dostavljac@gmail.com", 1, "Dostavljac", "1EugEl7M4ngH6hgmNFEry4+bVbw=", "yzXzdHFnuImEw1YSJfo34Q==", "Test", null, "0623554555" },
                    { 1014, "Treca ulica 2", new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6411), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6406), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6401), "haso@gmail.com", 1, "Haso", "IJJHgLDhwaX399tMxsqh/bQ7SjM=", "caGo+QqT++vaqQFQrhE2eA==", "Hasanovic", null, "0623554555" },
                    { 1015, "Cetvrta ulica 23", new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6460), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6455), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6450), "ahmo@gmail.com", 1, "Ahmo", "2sX8hpEPmsgJ+ysbl+VPhj5ou3I=", "FvicmQyCFpqFNCGzgiCwaQ==", "Ahmic", null, "0623554555" },
                    { 1016, "Peta ulica 23", new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6507), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6501), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6495), "ajdin@gmail.com", 1, "Ajdin", "KollFEuC5A6+fRdbD7iF4UeSNBM=", "JQS8wY5Hq1Jf7IFACDkYmQ==", "Ajdinovic", null, "0623554555" },
                    { 2016, "Sesta ulica 35", new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6552), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6547), new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(6542), "bekir@gmail.com", 3, "Bekir", "m4SNoQUsSWimY2iEcmlcH4JX3nw=", "sad/ufjxSKTwXWAq1kUISw==", "Becirovic", null, "0623554555" }
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
                    { 3, "Bulevar 2. Armije BiH 1", new DateTime(2022, 8, 16, 21, 43, 46, 149, DateTimeKind.Local).AddTicks(9245), new DateTime(2022, 8, 16, 21, 43, 46, 149, DateTimeKind.Local).AddTicks(9240), 1, "konzum@gmail.com", "00023233344", true, 2 },
                    { 1, "Mitra Trifunovica", new DateTime(2022, 8, 16, 21, 43, 46, 149, DateTimeKind.Local).AddTicks(8472), new DateTime(2022, 8, 16, 21, 43, 46, 149, DateTimeKind.Local).AddTicks(8156), 1, "managmentbcctuzla@confluence.ba", "035288699", true, 1 },
                    { 2, "Ismeta Mujezinovica D9", new DateTime(2022, 8, 16, 21, 43, 46, 149, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 8, 16, 21, 43, 46, 149, DateTimeKind.Local).AddTicks(9136), 1, "bingoSjenjak@gmail.com", "035365580", true, 1 },
                    { 4, "Stupine B-14", new DateTime(2022, 8, 16, 21, 43, 46, 149, DateTimeKind.Local).AddTicks(9282), new DateTime(2022, 8, 16, 21, 43, 46, 149, DateTimeKind.Local).AddTicks(9278), 1, "genelecTuzla@gmail.com", "0643536266", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "Dostavljac",
                columns: new[] { "DostavljacID", "DatumZaposlenja", "DostavljacStatus", "KorisnikID" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 16, 21, 43, 46, 146, DateTimeKind.Local).AddTicks(8385), 1, 1013 },
                    { 2, new DateTime(2022, 8, 16, 21, 43, 46, 146, DateTimeKind.Local).AddTicks(9542), 1, 1014 },
                    { 3, new DateTime(2022, 8, 16, 21, 43, 46, 146, DateTimeKind.Local).AddTicks(9637), 2, 1015 },
                    { 4, new DateTime(2022, 8, 16, 21, 43, 46, 146, DateTimeKind.Local).AddTicks(9684), 1, 2016 }
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
                values: new object[] { 1, new DateTime(2022, 8, 16, 21, 43, 46, 145, DateTimeKind.Local).AddTicks(9635), 2 });

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
                    { 1024, 1500m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(457), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(461), false, "Dell Lattitude E5440", "15.6'' 1.7GhZ 8GB", 64, 4, "658648", "proizvod_1024.jpg", true },
                    { 1019, 5m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(265), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(269), false, "Sampon za bebe", "Neiritirajuci sampon za bebe", 61, 3, "06456", "proizvod_1019.jpg", true },
                    { 1018, 8.5m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(191), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(195), false, "Hipp hrana za bebe", "Hrana za bebe do 3 godine", 60, 3, "00680", "proizvod_1018.jpg", true },
                    { 1017, 6.5m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(22), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(25), false, "Schauma", "sampon protiv peruti schauma", 43, 3, "6888", "proizvod_1017.jpg", true },
                    { 1016, 2.5m, new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9989), new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9993), true, "Narandza", "Svjeza narandza", 38, 3, "56773", "proizvod_1016.jpg", true },
                    { 1015, 2.3m, new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9958), new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9962), true, "Banana", "Svjeza crvena banana", 38, 3, "3436", "proizvod_1015.jpg", true },
                    { 1014, 1.2m, new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9926), new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9930), true, "Jabuka", "Svjeza crvena jabuka", 38, 3, "23455", "proizvod_1014.jpg", true },
                    { 1013, 4.5m, new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9894), new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9898), true, "Ananas", "Svjezi ananas", 38, 1, "0064", null, true },
                    { 1012, 2m, new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9858), new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9862), true, "Paradajz", "Paradajz", 39, 1, "0034", null, true },
                    { 12, 2m, new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9719), true, "Banana", "Svjeza banana", 38, 1, "0001", "proizvod_12.jpg", true },
                    { 1023, 7.5m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(427), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(430), false, "Friskies", "Hrana za macke", 55, 2, "75856", "proizvod_1023.jpg", true },
                    { 1022, 8.5m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(350), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(353), false, "Pedigree", "Hrana za pse", 55, 2, "65774", "proizvod_1022.jpg", true },
                    { 1021, 0.5m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(323), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(326), true, "Mrkva", "Svjeza mrkva", 39, 2, "4754", "proizvod_1021.jpg", true },
                    { 1020, 2.3m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(295), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(298), true, "Banana", "Svjeza banana", 38, 2, "6888", "proizvod_1020.jpg", true },
                    { 13, 3m, new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9788), new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9793), false, "Head & Shoulders", "sampon protiv peruti", 43, 2, "0023", "proizvod_13.jpg", true },
                    { 1011, 3.5m, new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9824), new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(9828), false, "Sampon", "sampon protiv peruti", 43, 1, "0004", null, true },
                    { 1025, 2500m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(486), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(490), false, "MSI GS70", "17 inch 16GB i7-8400 2.5 GHz", 64, 4, "567888", "proizvod_1025.jpg", true },
                    { 11, 2.3m, new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 8, 16, 21, 43, 46, 150, DateTimeKind.Local).AddTicks(8732), true, "Jabuka", "Svjeza jabuka", 38, 1, "0000", "proizvod_11.jpg", true },
                    { 1026, 2500m, new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(514), new DateTime(2022, 8, 16, 21, 43, 46, 151, DateTimeKind.Local).AddTicks(518), false, "Iphone 12 Pro", "256GB Purple", 65, 4, "476767", "proizvod_1026.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "Narudzba",
                columns: new[] { "NarudzbaID", "BonusZaDostavljaca", "Datum", "DostavljacID", "KlijentID", "KoordinatorID", "KuponID", "NarudzbaStatusID", "PoslovnicaID", "SlikaRacunaPutanja", "UkupanIznos" },
                values: new object[,]
                {
                    { 9, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(8619), null, 2, null, null, 6, 1, null, 9.75m },
                    { 3022, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9581), null, 12, null, null, 2, 1, null, 6.9m },
                    { 3021, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9557), null, 12, null, null, 2, 2, null, 6m },
                    { 3020, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9533), null, 12, null, null, 2, 1, null, 9.2m },
                    { 2022, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9506), null, 12, null, null, 2, 1, null, 4m },
                    { 2021, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9435), null, 12, null, null, 2, 1, null, 6m },
                    { 2020, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9410), null, 12, null, null, 2, 1, null, 4.6m },
                    { 1021, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9384), 3, 12, null, null, 3, 1, "narudzba_1021.jpg", 11.5m },
                    { 21, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9335), 1, 12, null, null, 6, 2, null, 12m },
                    { 20, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9309), 1, 12, null, null, 6, 2, null, 6m },
                    { 19, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9284), 1, 12, null, null, 6, 1, null, 16.3m },
                    { 17, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9259), 3, 2, null, null, 6, 2, null, 9m },
                    { 16, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9234), 3, 2, null, null, 6, 1, null, 6.9m },
                    { 15, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9209), 3, 2, null, null, 6, 2, null, 3m },
                    { 8, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(8648), 3, 2, null, null, 7, 1, null, 16.6m },
                    { 13, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9127), 2, 2, null, null, 6, 1, "narudzba_13.jpg", 11.25m },
                    { 1, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(7476), 2, 2, null, null, 7, 1, null, 16.6m },
                    { 12, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(8777), 1, 2, null, null, 6, 1, "narudzba_12.jpg", 18.32m },
                    { 11, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(8702), 1, 2, null, null, 6, 1, null, 2.3m },
                    { 10, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(8673), 1, 2, null, null, 6, 1, null, 4.6m },
                    { 6, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(8551), 1, 11, null, null, 6, 1, null, 12.05m },
                    { 3023, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9606), null, 2, null, null, 1, 1, null, 14.6m },
                    { 14, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9179), 4, 2, null, null, 6, 1, null, 6m },
                    { 1019, null, new DateTime(2022, 8, 16, 21, 43, 46, 148, DateTimeKind.Local).AddTicks(9359), 4, 12, null, null, 6, 1, null, 10.9m }
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
                name: "IX_PoslovnicaKategorija_KategorijaID",
                table: "PoslovnicaKategorija",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_PoslovnicaKategorija_PoslovnicaID",
                table: "PoslovnicaKategorija",
                column: "PoslovnicaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoslovnicaKategorija");

            migrationBuilder.DeleteData(
                table: "DostavljacStatus",
                keyColumn: "DostavljacStatusID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Klijent",
                keyColumn: "KlijentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Klijent",
                keyColumn: "KlijentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Koordinator",
                keyColumn: "KoordinatorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 3033);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 3034);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 3035);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 4033);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 4034);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 4035);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 4036);

            migrationBuilder.DeleteData(
                table: "NaruceniProizvod",
                keyColumn: "NaruceniProizvodID",
                keyValue: 4037);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NarudzbaStatus",
                keyColumn: "NarudzbaStatusID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NarudzbaStatus",
                keyColumn: "NarudzbaStatusID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Klijent",
                keyColumn: "KlijentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3021);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3022);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3023);

            migrationBuilder.DeleteData(
                table: "NarudzbaStatus",
                keyColumn: "NarudzbaStatusID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Klijent",
                keyColumn: "KlijentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Klijent",
                keyColumn: "KlijentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "NarudzbaStatus",
                keyColumn: "NarudzbaStatusID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NarudzbaStatus",
                keyColumn: "NarudzbaStatusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NarudzbaStatus",
                keyColumn: "NarudzbaStatusID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NarudzbaStatus",
                keyColumn: "NarudzbaStatusID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Podkategorija",
                keyColumn: "PodkategorijaID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrgovackiLanac",
                keyColumn: "TrgovackiLanacID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrgovackiLanac",
                keyColumn: "TrgovackiLanacID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DostavljacStatus",
                keyColumn: "DostavljacStatusID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DostavljacStatus",
                keyColumn: "DostavljacStatusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "TrgovackiLanac",
                keyColumn: "TrgovackiLanacID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "TrgovackiLanacKategorija",
                columns: table => new
                {
                    TrgovackiLanacKategorijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorijaID = table.Column<int>(type: "int", nullable: true),
                    TrgovackiLanacID = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_TrgovackiLanacKategorija_KategorijaID",
                table: "TrgovackiLanacKategorija",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_TrgovackiLanacKategorija_TrgovackiLanacID",
                table: "TrgovackiLanacKategorija",
                column: "TrgovackiLanacID");
        }
    }
}

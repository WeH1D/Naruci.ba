using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaruciBa.Migrations
{
    public partial class DATA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 1,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 145, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 2,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 145, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 3,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 145, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 4,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 145, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Koordinator",
                keyColumn: "KoordinatorID",
                keyValue: 1,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 142, DateTimeKind.Local).AddTicks(9309), new DateTime(2022, 8, 21, 14, 20, 53, 142, DateTimeKind.Local).AddTicks(8901), new DateTime(2022, 8, 21, 14, 20, 53, 139, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1003,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(1917), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(1901), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1007,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2111), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2107), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1012,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2146), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2143), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1013,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2174), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2171), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1014,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2206), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2204), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1015,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2234), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2232), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1016,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2261), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2258), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2016,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2288), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2286), new DateTime(2022, 8, 21, 14, 20, 53, 144, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 6,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 8,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 9,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 11,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 12,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 13,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 14,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 15,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 16,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 17,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 19,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 20,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 21,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 1019,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 1021,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 2020,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 2021,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 2022,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3020,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3021,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3022,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3023,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 20, 53, 146, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 147, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 8, 21, 14, 20, 53, 147, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 147, DateTimeKind.Local).AddTicks(7310), new DateTime(2022, 8, 21, 14, 20, 53, 147, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 147, DateTimeKind.Local).AddTicks(7558), new DateTime(2022, 8, 21, 14, 20, 53, 147, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 147, DateTimeKind.Local).AddTicks(7592), new DateTime(2022, 8, 21, 14, 20, 53, 147, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 11,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(7253), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 12,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8691), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 13,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8768), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1011,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8807), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1012,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8843), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1013,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8884), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1014,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8921), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1015,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9015), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1016,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9055), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1017,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9094), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1018,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9131), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1019,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9167), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1020,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9202), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1021,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9238), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1022,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9274), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1023,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9310), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1024,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9346), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1025,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9384), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1026,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9420), new DateTime(2022, 8, 21, 14, 20, 53, 149, DateTimeKind.Local).AddTicks(9425) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 1,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 595, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 2,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 595, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 3,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 595, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Dostavljac",
                keyColumn: "DostavljacID",
                keyValue: 4,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 595, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Koordinator",
                keyColumn: "KoordinatorID",
                keyValue: 1,
                column: "DatumZaposlenja",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 595, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 592, DateTimeKind.Local).AddTicks(7499), new DateTime(2022, 8, 21, 14, 8, 1, 592, DateTimeKind.Local).AddTicks(6850), new DateTime(2022, 8, 21, 14, 8, 1, 587, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1003,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(6702), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(6683), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1007,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(6897), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(6894), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1012,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1013,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7052), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7048), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1014,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7100), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7097), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1015,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7145), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7142), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1016,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7184), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7180), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2016,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumRodenja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7219), new DateTime(2022, 8, 21, 14, 8, 1, 594, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 6,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 8,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 9,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 11,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 12,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 13,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 14,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 15,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 16,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 17,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 19,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 20,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 21,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 1019,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 1021,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 2020,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 2021,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 2022,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3020,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3021,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3022,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 3023,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 8, 1, 597, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 599, DateTimeKind.Local).AddTicks(2), new DateTime(2022, 8, 21, 14, 8, 1, 598, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 599, DateTimeKind.Local).AddTicks(741), new DateTime(2022, 8, 21, 14, 8, 1, 599, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 599, DateTimeKind.Local).AddTicks(832), new DateTime(2022, 8, 21, 14, 8, 1, 599, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Poslovnica",
                keyColumn: "PoslovnicaID",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 599, DateTimeKind.Local).AddTicks(875), new DateTime(2022, 8, 21, 14, 8, 1, 599, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 11,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(7036), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 12,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8529), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 13,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8638), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1011,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8691), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1012,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8737), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1013,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8788), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1014,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8834), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1015,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8876), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1016,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8915), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1017,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9150), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1018,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9191), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1019,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9228), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1020,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9265), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1021,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9301), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1022,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9336), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1023,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9372), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1024,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9408), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1025,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9446), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Proizvod",
                keyColumn: "ProizvodID",
                keyValue: 1026,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9482), new DateTime(2022, 8, 21, 14, 8, 1, 600, DateTimeKind.Local).AddTicks(9487) });
        }
    }
}

import 'package:json_annotation/json_annotation.dart';

part 'Korisnik.g.dart';

@JsonSerializable()
class Korisnik {
  final int korisnikID;
  final String ime;
  final String prezime;
  final String adresa;
  final String email;
  final String telefon;
  final DateTime? datumRodenja;
  final DateTime? datumKreiranja;
  final DateTime? datumIzmjene;
  final String? slika;
  final int? gradID;

  Korisnik(
      {required this.korisnikID,
      required this.ime,
      required this.prezime,
      required this.adresa,
      required this.email,
      required this.telefon,
      required this.datumRodenja,
      required this.datumKreiranja,
      required this.datumIzmjene,
      required this.slika,
      required this.gradID});

  /// Connect the generated [_$KorisnikFromJson] function to the `fromJson`
  /// factory.
  factory Korisnik.fromJson(Map<String, dynamic> json) =>
      _$KorisnikFromJson(json);

  /// Connect the generated [_$KorisnikToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$KorisnikToJson(this);
}

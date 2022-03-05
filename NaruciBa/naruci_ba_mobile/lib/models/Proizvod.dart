import 'dart:typed_data';

import 'package:json_annotation/json_annotation.dart';

part 'Proizvod.g.dart';

@JsonSerializable()
class Proizvod {
  final int proizvodID;
  final String naziv;
  final String sifra;
  final String opis;
  final double? cijena;
  final bool? kg;
  final int? podkategorijaID;
  final int? poslovnicaID;
  final bool? status;
  final String? slika;
  final String? slikaPutanja;
  final DateTime? datumKreiranja;
  final DateTime? datumIzmjene;

  Proizvod(
      {required this.proizvodID,
      required this.naziv,
      required this.sifra,
      required this.opis,
      required this.cijena,
      required this.kg,
      required this.podkategorijaID,
      required this.poslovnicaID,
      required this.status,
      required this.slika,
      required this.slikaPutanja,
      required this.datumKreiranja,
      required this.datumIzmjene});

  /// Connect the generated [_$PersonFromJson] function to the `fromJson`
  /// factory.
  factory Proizvod.fromJson(Map<String, dynamic> json) =>
      _$ProizvodFromJson(json);

  /// Connect the generated [_$PoslovnicaToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$ProizvodToJson(this);
}
